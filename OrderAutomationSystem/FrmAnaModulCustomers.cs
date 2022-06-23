using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OrderAutomationSystem.Entities;

namespace OrderAutomationSystem
{
    public partial class FrmAnaModulCustomers : Form
    {
        public FrmAnaModulCustomers()
        {
            InitializeComponent();
        }

        private FrmLogin frmLogin = new FrmLogin();
        private void FrmAnaModulCustomers_Load(object sender, EventArgs e)
        {
            Clean();
            LoadOrders();
            LoadStock2();
            LoadCity();
            LoadStock3();
        }

        // bu ilk girişte kullanıcı adını alıp gride listeliyor
        private void LoadOrdersCustomer()
        {
            grcMüşteri.DataSource = _orderDal.GetAll().Where(p => p.UserName == name).ToList();
        }

        // buda yeni sipariş eklendiğinde text teki kullanıcı adını alıp ona göre gride listeleme yapıyor.
        private void LoadOrdersCustomer2()
        {
            grcMüşteri.DataSource = _orderDal.GetAll().Where(p => p.UserName == txtKullanıcıAdı.Text).ToList();
        }

        void LoadOrders()
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
                grcMüşteri.DataSource = entity.Where(p => p.KullanıcıAdı == name).ToList();
            }
        }
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
                grcMüşteri.DataSource = entity.Where(p=>p.KullanıcıAdı == txtKullanıcıAdı.Text).ToList();
            }
        }

        void Total()
        {
            decimal adet, fiyat, toplamfiyat;
            adet = Convert.ToDecimal(txtAdet.Text);
            fiyat = Convert.ToDecimal(txtFiyat.Text);
            toplamfiyat = adet * fiyat;
            txtToplamFiyat.Text = toplamfiyat.ToString();
        }

        void Clean()
        {
            lkupİlçe.EditValue = null;
            lkupİl.EditValue = null;
            lkuÜrün.EditValue = null;
            txtFiyat.Text = "";
            txtAdet.Text = "";
            txtKullanıcıAdı.Text = "";
            txtTarih.Text = "";
            txtAdres.Text = "";
            txtTeslimAlan.Text = "";
            txtToplamFiyat.Text = "";
        }

        public string name;
        private OrderDal _orderDal = new OrderDal();


        //grid controle girmek için bunu kullanmadım burda tedarikçi olarak ıd getiriyor bana isimleri lazımdı stock 3 te yaptım onu 
        void LoadStock()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Stocks.Select(x => new
                {
                    ÜrünAdı = x.StockName,
                    Tedarikçi = x.SupplierId,
                    Fiyat = x.SalePrice
                });
                gridControl1.DataSource = entity.ToList();
            }
        }

        // grid contrele Ürünleri listeleme için 
        void LoadStock3()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = from s in context.Stocks
                             join p in context.Suppliers on s.SupplierId equals p.SupplierId
                             select new
                             {
                                 ÜrünAdı = s.StockName,
                                 Tedarikçi = p.SupplierName,
                                 Fiyat = s.SalePrice
                             };
                gridControl1.DataSource = entity.ToList();
            }
        }


        private void btnSiparişVer_Click(object sender, EventArgs e)
        {
            try
            {
                _orderDal.Add(new Order
                {
                    UserName = txtKullanıcıAdı.Text,
                    StockId = Convert.ToInt32(lkuÜrün.EditValue),
                    Piece = Convert.ToInt32(txtAdet.Text),
                    UnitPrice = Convert.ToDecimal(txtFiyat.Text),
                    TotalPrice = Convert.ToDecimal(txtToplamFiyat.Text),
                    OrderDate = txtTarih.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    DeliveryAddress = txtAdres.Text,
                    Receiver = txtTeslimAlan.Text,
                    Received = false
                });
                LoadOrders2();

                MessageBox.Show("Siparişin Verilmiştir. Bizi Tercih Ettiğiniz İçin Teşekkürler :)", "Sipariş Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnSiparişİptal_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOrderCancellation orderCancellation = new FrmOrderCancellation();
                orderCancellation.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCustomerUserUpdate customerUserUpdate = new FrmCustomerUserUpdate();
                customerUserUpdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Onay = MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz?", "Bilgi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Onay == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

        private void txtFiyat_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Total();
            }
            catch (Exception)
            {

            }
        }

        private void FrmAnaModulCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
