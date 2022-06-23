using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Charts.Native;
using DevExpress.XtraCharts;
using OrderAutomationSystem.Entities;

namespace OrderAutomationSystem
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private CustomerDal _customerDal = new CustomerDal();
        void LoadKişiSayısı()
        {
            txtMüşteriSayısı.Text = Convert.ToInt32(_customerDal.ToplamSayıListeleme()).ToString() + " Kişi";
        }

        private OrderDal _orderDal = new OrderDal();
        void LoadBekleyenSipariş()
        {
            txtSipariş.Text = Convert.ToInt32(_orderDal.BekleyenSipariş()).ToString() + " Adet";
        }
        decimal kasa = 450000;

        void LoadToplamPara()
        {
            txtToplamPara.Text = Convert.ToDecimal(_orderDal.ToplamFiyat() + kasa).ToString() + " ₺";
        }


        void LoadCustomer()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Customers.Select(x => new
                {
                    //Id = x.CustomerId,
                    Adı = x.FirstName,
                    Soyadı = x.LastName,
                    Telefon = x.Phone,
                    Mail = x.Mail
                });
                grcCustomer.DataSource = entity.ToList();
            }
        }

        //void LoadGraphic()
        //{
        //    Series series = new Series("Stok", ViewType.Line);
        //    series.DataSource.GetHashCode()=IIndicatorDataPoint.GetDataPoints();
        //    series.ArgumentDataMember = "StockName";
        //    series.ValueDataMembers.AddRange("Stock");
        //    chartControl1.Series.Add(series);
        //}

        void LoadGrap()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = from s in context.Stocks
                             select new
                             {
                                 ÜrünAdı = s.StockName,
                                 StokSayısı = s.UnitInStock
                             };

            }
        }


        void LoadGraphic()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = from s in context.Stocks
                             select new
                             {
                                 ÜrünAdı = s.StockName,
                             };
                var entity2 = from s in context.Stocks
                              select new
                              {
                                  StokSayısı = s.UnitInStock
                              };
                chartControl1.Series["Series 1"].Points.Add( new SeriesPoint(entity,entity2));
            }
        }
        void LoadGraphic2()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = from s in context.Stocks
                    select new
                    {
                        ÜrünAdı = s.StockName,
                    };
                var entity2 = from s in context.Stocks
                    select new
                    {
                        StokSayısı = s.UnitInStock
                    };
                //chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(entity), Convert.ToInt32(entity2));
            }
        }



        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderAutomationSystemDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.orderAutomationSystemDataSet.Stocks);

            webBrowser2.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            LoadKişiSayısı();
            LoadCustomer();
            LoadBekleyenSipariş();
            LoadToplamPara();
           // LoadGraphic2();
        }


    }
}
