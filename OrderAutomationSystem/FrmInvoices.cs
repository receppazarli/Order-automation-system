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
    public partial class FrmInvoices : Form
    {
        public FrmInvoices()
        {
            InitializeComponent();
        }

        private InvoiceDal _invoiceDal = new InvoiceDal();
        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            LoadInvoices2();
            Clean();
        }

        void LoadInvoices2()
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = from ı in context.Invoices select new
                {
                    FaturaId=ı.InvoiceId,
                    FaturaMasrafları=ı.TotalInvoice,
                    Maaşlar=ı.TotalSalary,
                    EkstraHarcamalar=ı.Extra,
                    ToplamMasraflar=ı.Total,
                    Ay=ı.Months,
                    Yıl=ı.Year
                };
                grcFaturalar.DataSource = entity.ToList();
            }
        }

        private void LoadInvoices()
        {
            grcFaturalar.DataSource = _invoiceDal.GetAll();
        }

        void Topla()
        {
            decimal faturalar, maaşlar, ekstra, toplam;
            faturalar = Convert.ToDecimal(txtToplamFaturalar.Text);
            maaşlar = Convert.ToDecimal(txtMaaşlar.Text);
            ekstra = Convert.ToDecimal(txtEkstraHarcamalar.Text);
            toplam = faturalar + maaşlar + ekstra;
            txtToplamMasraflar.Text = toplam.ToString();
        }

        void Clean()
        {
            txtEkstraHarcamalar.Text = "";
            txtMaaşlar.Text = "";
            txtToplamFaturalar.Text = "";
            txtToplamMasraflar.Text = "";
            txtAy.Text = "";
            txtYıl.Text = "";

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Topla();
                _invoiceDal.Add(new Invoice
                {
                    TotalInvoice = Convert.ToDecimal(txtToplamFaturalar.Text),
                    TotalSalary = Convert.ToDecimal(txtMaaşlar.Text),
                    Extra = Convert.ToDecimal(txtEkstraHarcamalar.Text),
                    Total = Convert.ToDecimal(txtToplamMasraflar.Text),
                    Months = txtAy.Text,
                    Year = txtYıl.Text
                });
                LoadInvoices2();
                MessageBox.Show("Fatura bilgileri sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _invoiceDal.Update(new Invoice
                {
                    InvoiceId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FaturaId")),
                    TotalInvoice = Convert.ToDecimal(txtToplamFaturalar.Text),
                    TotalSalary = Convert.ToDecimal(txtMaaşlar.Text),
                    Extra = Convert.ToDecimal(txtEkstraHarcamalar.Text),
                    Total = Convert.ToDecimal(txtToplamMasraflar.Text),
                    Months = txtAy.Text,
                    Year = txtYıl.Text
                });
                LoadInvoices2();
                MessageBox.Show("Fatura bilgileri  güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _invoiceDal.Delete(new Invoice
                {
                    InvoiceId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FaturaId")),

                });
                LoadInvoices2();
                MessageBox.Show("Fatura bilgileri sistemden silindi. .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtToplamFaturalar.Text = gridView1.GetFocusedRowCellValue("FaturaMasrafları").ToString();
            txtMaaşlar.Text = gridView1.GetFocusedRowCellValue("Maaşlar").ToString();
            txtEkstraHarcamalar.Text = gridView1.GetFocusedRowCellValue("EkstraHarcamalar").ToString();
            txtToplamMasraflar.Text = gridView1.GetFocusedRowCellValue("ToplamMasraflar").ToString();
            txtAy.Text = gridView1.GetFocusedRowCellValue("Ay").ToString();
            txtYıl.Text = gridView1.GetFocusedRowCellValue("Yıl").ToString();

          
        }
    }
}
