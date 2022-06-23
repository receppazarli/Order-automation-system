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
    public partial class FrmSafe : Form
    {
        public FrmSafe()
        {
            InitializeComponent();
        }

        private OrderDal _orderDal = new OrderDal();
        decimal kasa = 450000;

        void LoadToplamPara()
        {
            lblToplamParaa.Text = Convert.ToDecimal(_orderDal.ToplamFiyat() + kasa).ToString() + " ₺";
        }

        private InvoiceDal _invoiceDal = new InvoiceDal();
        void LoadÖdemeler()
        {
            lblÖdemeler.Text = Convert.ToDecimal(_invoiceDal.Ödemeler()).ToString() + " ₺";
        }

        private StockDal _stockDal = new StockDal();
        void LoadToplamMaliyet()
        {
            lblÜrünMaliyeti.Text = Convert.ToDecimal(_stockDal.ToplamMaliyet()).ToString() + " ₺";
        }

        void Loadkazanc()
        {
            decimal para, ödemeler, maliyet, kar;
            //para = Convert.ToDecimal(lblToplamPara);
            para = Convert.ToDecimal(_orderDal.ToplamFiyat() + kasa);
            ödemeler = Convert.ToDecimal(_invoiceDal.Ödemeler());
            maliyet = Convert.ToDecimal(_stockDal.ToplamMaliyet());
            kar = para - (ödemeler + maliyet);
            lblKazanç.Text = Convert.ToDecimal(kar).ToString() + " ₺";
        }

        void LoadBekleyenSiparişler()
        {
            lblBekleyenSiparişler.Text = Convert.ToInt32(_orderDal.BekleyenSipariş()).ToString() + " Adet";
        }


        void LoadTeslimEdilenSiparişler()
        {
            lblTeslimEdilenSiparişler.Text = Convert.ToInt32(_orderDal.TeslimEdilenSiparişler()).ToString() + " Adet";
        }


        //private void LoadInvoice()
        //{
        //    grcÇıkışlar.DataSource = _invoiceDal.GetAll();
        //}

        //void LoadInvoice2()
        //{
        //    using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
        //    {
        //        var entity = from ı in context.Invoices
        //                     select new
        //                     {
        //                         FaturaId = ı.InvoiceId,
        //                         FaturaMasrafları = ı.TotalInvoice,
        //                         Maaşlar = ı.TotalSalary,
        //                         EkstraHarcamalar = ı.Extra,
        //                         ToplamMasraflar = ı.Total,
        //                         Ay = ı.Months,
        //                         Yıl = ı.Year
        //                     };
        //        grcÇıkışlar.DataSource = entity.ToList();
        //    }
        //}

        private void LoadLoadBekleyenŞiparişListeleme()
        {
            grcBekleyenSipariş.DataSource = _orderDal.GetAll2();
        }

        //Bekleen sipariş listeleme buda

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
                grcBekleyenSipariş.DataSource = entity.Where(p => p.TeslimKontrol == false).ToList();
            }
        }



        private void FrmSafe_Load(object sender, EventArgs e)
        {
            LoadToplamPara();
            LoadÖdemeler();
            LoadToplamMaliyet();
            Loadkazanc();
            LoadBekleyenSiparişler();
            LoadTeslimEdilenSiparişler();
            //LoadInvoice2();
            LoadOrders2();
        }


    }
}
