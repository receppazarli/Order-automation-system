using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderAutomationSystem.Entities;

namespace OrderAutomationSystem
{
    public partial class FrmStocks : Form
    {
        public FrmStocks()
        {
            InitializeComponent();
        }

        private StockDal _stockDal = new StockDal();
        void LoadStocks()
        {
            grcStoklar.DataSource = _stockDal.GetAll();
        }

        //void LoadStocks3()
        //{
        //    using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
        //    {
        //        var entity = from s in context.Stocks select new
        //        {

        //        };
        //    }
        //}

        //void LoadOrders2()
        //{
        //    using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
        //    {
        //        var entity = from o in context.Orders
        //            join s in context.Stocks on o.StockId equals s.StockId
        //            select new
        //            {
        //                SiparişId = o.OrderId,
        //                KullanıcıAdı = o.UserName,
        //                Ürün = s.StockName,
        //                Adet = o.Piece,
        //                Fiyat = o.UnitPrice,
        //                ToplamFiyat = o.TotalPrice,
        //                SİparişTarihi = o.OrderDate,
        //                Şehir = o.City,
        //                İlçe = o.Country,
        //                Adres = o.DeliveryAddress,
        //                TeslimAlan = o.Receiver,
        //                TeslimKontrol = o.Received
        //            };
        //        grcMüşteri.DataSource = entity.Where(p => p.KullanıcıAdı == txtKullanıcıAdı.Text).ToList();
        //    }
        //}

        void LoadStock2()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = from s in context.Stocks
                             join t in context.Suppliers on s.SupplierId equals t.SupplierId
                             join d in context.WareHouses on s.WarehousesId equals d.WarehouseId
                             select new
                             {
                                 ÜrünId=s.StockId,
                                 ÜrünAdı = s.StockName,
                                 Tedarikçi = t.SupplierName,
                                 Depo = d.WarehouseName,
                                 GelenStok = s.StockEntry,
                                 GidenStok = s.StockOut,
                                 KalanStok = s.UnitInStock,
                                 AlışFiyat = s.UnitPrice,
                                 SatışFiyat = s.SalePrice,
                                 ToplamMaliyet = s.TotalCost
                             };
                grcStoklar.DataSource = entity.ToList();
            }
        }

        void Clear()
        {
            txtAd.Text = "";
            txtAlışFiyatı.Text = "";
            txtSatışFiyatı.Text = "";
            txtStok.Text = "";
            txtToplamMaliyet.Text = "";
            lkupDepo.EditValue = null;
            lkupTedarikçi.EditValue = null;
            txtGelenStok.Text = "";
            txtGidenStok.Text = "";
        }
        private void FrmStocks_Load(object sender, EventArgs e)
        {
            LoadStock2();
            Clear();
            LoadSupplier();
            LoadWareHouse();
        }


        void Total()
        {
            decimal adet, fiyat, toplamfiyat;
            adet = Convert.ToDecimal(txtGelenStok.Text);
            fiyat = Convert.ToDecimal(txtAlışFiyatı.Text);
            toplamfiyat = adet * fiyat;
            txtToplamMaliyet.Text = toplamfiyat.ToString();
        }

        void ToplamStok()
        {
            int gelenstok, gidenstok, stok;
            gelenstok = Convert.ToInt32(txtGelenStok.Text);
            gidenstok = Convert.ToInt32(txtGidenStok.Text);
            stok = gelenstok - gidenstok;
            txtStok.Text = stok.ToString();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Total();
                ToplamStok();
                _stockDal.Add(new Stock
                {
                    StockName = txtAd.Text,
                    SupplierId = Convert.ToInt32(lkupTedarikçi.EditValue),
                    WarehousesId = Convert.ToInt32(lkupDepo.EditValue),
                    StockEntry = Convert.ToInt32(txtGelenStok.Text),
                    StockOut = Convert.ToInt32(txtGidenStok.Text),
                    UnitInStock = Convert.ToInt32(txtStok.Text),
                    UnitPrice = Convert.ToDecimal(txtAlışFiyatı.Text),
                    SalePrice = Convert.ToDecimal(txtSatışFiyatı.Text),
                    TotalCost = Convert.ToDecimal(txtToplamMaliyet.Text)
                });
                LoadStock2();
                MessageBox.Show("Ürün sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            try
            {
                Total();
                ToplamStok();

                _stockDal.Update(new Stock
                {
                    StockId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ÜrünId")),
                    StockName = txtAd.Text,
                    SupplierId = Convert.ToInt32(lkupTedarikçi.EditValue),
                    WarehousesId = Convert.ToInt32(lkupDepo.EditValue),
                    StockEntry = Convert.ToInt32(txtGelenStok.Text),
                    StockOut = Convert.ToInt32(txtGidenStok.Text),
                    UnitInStock = Convert.ToInt32(txtStok.Text),
                    UnitPrice = Convert.ToDecimal(txtAlışFiyatı.Text),
                    SalePrice = Convert.ToDecimal(txtSatışFiyatı.Text),
                    TotalCost = Convert.ToDecimal(txtToplamMaliyet.Text)
                });
                LoadStock2();
                MessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş");
            }

        }
        void LoadSupplier()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Suppliers.Select(x => new
                {
                    Id = x.SupplierId,
                    Tedarikçi = x.SupplierName
                });
                lkupTedarikçi.Properties.DataSource = entity.ToList();
                lkupTedarikçi.Properties.DisplayMember = "Tedarikçi";
                lkupTedarikçi.Properties.ValueMember = "Id";
            }
        }

        void LoadWareHouse()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.WareHouses.Select(x => new
                {
                    Id = x.WarehouseId,
                    Depo = x.WarehouseName
                });
                lkupDepo.Properties.DataSource = entity.ToList();
                lkupDepo.Properties.DisplayMember = "Depo";
                lkupDepo.Properties.ValueMember = "Id";
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                txtAd.Text = gridView1.GetFocusedRowCellValue("ÜrünAdı").ToString();
                lkupTedarikçi.Text = gridView1.GetFocusedRowCellValue("Tedarikçi").ToString();
                lkupDepo.Text = gridView1.GetFocusedRowCellValue("Depo").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("KalanStok").ToString();
                txtAlışFiyatı.Text = gridView1.GetFocusedRowCellValue("AlışFiyat").ToString();
                txtSatışFiyatı.Text = gridView1.GetFocusedRowCellValue("SatışFiyat").ToString();
                txtToplamMaliyet.Text = gridView1.GetFocusedRowCellValue("ToplamMaliyet").ToString();
                txtGelenStok.Text = gridView1.GetFocusedRowCellValue("GelenStok").ToString();
                txtGidenStok.Text = gridView1.GetFocusedRowCellValue("GidenStok").ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _stockDal.Delete(new Stock
                {
                    StockId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ÜrünId"))
                });
                LoadStock2();
                MessageBox.Show("Ürün sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clear();
        }


    }
}
