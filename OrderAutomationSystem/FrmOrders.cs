using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts.Designer.Native;
using OrderAutomationSystem.Entities;

namespace OrderAutomationSystem
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }

        private OrderDal _orderDal = new OrderDal();



        private void FrmOrders_Load(object sender, EventArgs e)
        {
            LoadCity();
            LoadOrders2();
            LoadStock2();
            Clean();
        }

        // Bütün siparişleri direk order tablosundan lsiteleme
        // private void LoadOrders()
        ///{
        //   grcSiparişler.DataSource = _orderDal.GetAll();
        //  }

        //// grid contrele Ürünleri listeleme için 
        //void LoadStock3()
        //{
        //    using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
        //    {
        //        var entity = from s in context.Stocks
        //            join p in context.Suppliers on s.SupplierId equals p.SupplierId
        //            select new
        //            {
        //                ÜrünAdı = s.StockName,
        //                Tedarikçi = p.SupplierName,
        //                Fiyat = s.SalePrice
        //            };
        //        gridControl1.DataSource = entity.ToList();
        //    }
        //}

        //Bütün siparişleri sipariş ve ürünler tablosundan alarak listeleleme
        void LoadOrders2()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = from o in context.Orders
                             join s in context.Stocks on o.StockId equals s.StockId
                             select new
                             {
                                 SiparişId = o.OrderId,
                                 KullanıcıAdı = o.UserName,
                                 Ürün = s.StockName,
                                 Adet = o.Piece,
                                 Fiyat = o.UnitPrice,
                                 ToplamFiyat = o.TotalPrice,
                                 SİparişTarihi = o.OrderDate,
                                 Şehir = o.City,
                                 İlçe = o.Country,
                                 Adres = o.DeliveryAddress,
                                 TeslimAlan = o.Receiver,
                                 TeslimKontrol = o.Received
                             };
                grcSiparişler.DataSource = entity.ToList();
            }
        }

        void Clean()
        {
            txtAdres.Text = "";
            txtTarih.Text = "";
            txtTeslimAlan.Text = "";
            txtAdet.Text = "";
            txtFiyat.Text = "";
            lkupİl.EditValue = null;
            lkupİlçe.EditValue = null;
            lkuÜrün.EditValue = null;
            TxtToplamFiyat.Text = "";
            txtKullanıcıAdı.Text = "";


        }
        void Total()
        {
            decimal adet, fiyat, toplamfiyat;
            adet = Convert.ToDecimal(txtAdet.Text);
            fiyat = Convert.ToDecimal(txtFiyat.Text);
            toplamfiyat = adet * fiyat;
            TxtToplamFiyat.Text = toplamfiyat.ToString();
        }




        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _orderDal.Add(new Order
                {
                    UserName = txtKullanıcıAdı.Text,
                    StockId = Convert.ToInt32(lkuÜrün.EditValue),
                    Piece = Convert.ToInt32(txtAdet.Text),
                    UnitPrice = Convert.ToDecimal(txtFiyat.Text),
                    TotalPrice = Convert.ToDecimal(TxtToplamFiyat.Text),
                    OrderDate = txtTarih.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    DeliveryAddress = txtAdres.Text,
                    Receiver = txtTeslimAlan.Text,
                    Received = false

                });
                LoadOrders2();
                MessageBox.Show("Sipariş sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtKullanıcıAdı.Text = gridView1.GetFocusedRowCellValue("KullanıcıAdı").ToString();
                lkuÜrün.Text = gridView1.GetFocusedRowCellValue("Ürün").ToString();
                txtAdet.Text = gridView1.GetFocusedRowCellValue("Adet").ToString();
                txtFiyat.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
                TxtToplamFiyat.Text = gridView1.GetFocusedRowCellValue("ToplamFiyat").ToString();
                txtTarih.Text = gridView1.GetFocusedRowCellValue("SİparişTarihi").ToString();
                lkupİl.Text = gridView1.GetFocusedRowCellValue("Şehir").ToString();
                lkupİlçe.Text = gridView1.GetFocusedRowCellValue("İlçe").ToString();
                txtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
                txtTeslimAlan.Text = gridView1.GetFocusedRowCellValue("TeslimAlan").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _orderDal.Delete(new Order
                {
                    OrderId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SiparişId"))
                });
                LoadOrders2();
                MessageBox.Show("Sipariş bilgileri silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private StockDal _stockDal = new StockDal();

        private void lkuÜrün_EditValueChanged(object sender, EventArgs e)
        {
            if (lkuÜrün.EditValue != null)
            {
                txtFiyat.Text = _stockDal.GetAll3(Convert.ToInt32(lkuÜrün.EditValue)).ToString();
            }
            else
            {

            }
        }

        private void btnTeslimAlındı_Click(object sender, EventArgs e)
        {
            try
            {
                _orderDal.Update(new Order
                {
                    OrderId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SiparişId")),
                    UserName = txtKullanıcıAdı.Text,
                    StockId = Convert.ToInt32(lkuÜrün.EditValue),
                    Piece = Convert.ToInt32(txtAdet.Text),
                    UnitPrice = Convert.ToDecimal(txtFiyat.Text),
                    TotalPrice = Convert.ToDecimal(TxtToplamFiyat.Text),
                    OrderDate = txtTarih.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    DeliveryAddress = txtAdres.Text,
                    Receiver = txtTeslimAlan.Text,
                    Received = true,

                });
                LoadOrders2();
                MessageBox.Show("Ürün Teslim edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Hatalı Seçim", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        //look up edite listelemek için
        void LoadStock2()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Stocks.Select(x => new
                {
                    Id = x.StockId,
                    ÜrünAdı = x.StockName
                });
                lkuÜrün.Properties.DataSource = entity.ToList();
                lkuÜrün.Properties.DisplayMember = "ÜrünAdı";
                lkuÜrün.Properties.ValueMember = "Id";
            }
        }



        private CityDal _cityDal = new CityDal();
        void LoadCity()
        {
            lkupİl.Properties.DataSource = _cityDal.GetAll();
            lkupİl.Properties.DisplayMember = "CityName";
            lkupİl.Properties.ValueMember = "Id";
        }
        private CountryDal _countryDal = new CountryDal();
        void LoadCountry()
        {
            lkupİlçe.Properties.DataSource = _countryDal.GetAllCountry(Convert.ToInt32(lkupİl.EditValue)).ToList();
            lkupİlçe.Properties.DisplayMember = "CountryName";
            lkupİlçe.Properties.ValueMember = "Id";
        }

        private void lkupİl_EditValueChanged(object sender, EventArgs e)
        {
            LoadCountry();
        }

        private void txtAdet_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Total();
            }
            catch (Exception)
            {
            }
        }
    }
}
