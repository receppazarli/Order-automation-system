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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private CustomerDal _customerDal = new CustomerDal();
        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers2();
            Clear();
            LoadCity();
        }


        private void LoadCustomers()
        {
            grcMüşteriler.DataSource = _customerDal.GetAll();
        }

        private void LoadCustomers2()
        {
            // grcMüşteriler.DataSource = _customerDal.GetAll();

            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = from c in context.Customers
                             select new
                             {
                                 MüşteriId=c.CustomerId,
                                 Ad = c.FirstName,
                                 Soyadı = c.LastName,
                                 TC = c.IdentityNumber,
                                 Banka = c.BankName,
                                 Iban = c.Iban,
                                 Telefon = c.Phone,
                                 Mail = c.Mail,
                                 İl = c.City,
                                 İlçe = c.Country,
                                 Adres = c.Address
                             };
                grcMüşteriler.DataSource = entity.ToList();

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

        void Clear()
        {
            txtAd.Text = "";
            txtAdres.Text = "";
            txtBanka.Text = "";
            txtIban.Text = "";
            txtMail.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTelefon.Text = "";
            lkupİl.EditValue = null;
            lkupİlçe.EditValue = null;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                _customerDal.Add(new Customer
                {
                    FirstName = txtAd.Text,
                    LastName = txtSoyad.Text,
                    IdentityNumber = txtTC.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    Mail = txtMail.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    Address = txtAdres.Text,
                });
                LoadCustomers2();
                MessageBox.Show("Müşteri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _customerDal.Update(new Customer
                {
                    CustomerId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MüşteriId")),
                    FirstName = txtAd.Text,
                    LastName = txtSoyad.Text,
                    IdentityNumber = txtTC.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    Mail = txtMail.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    Address = txtAdres.Text,
                });

                LoadCustomers2();
                MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyadı").ToString();
            txtTC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            txtBanka.Text = gridView1.GetFocusedRowCellValue("Banka").ToString();
            txtIban.Text = gridView1.GetFocusedRowCellValue("Iban").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            lkupİl.Text = gridView1.GetFocusedRowCellValue("İl").ToString();
            lkupİlçe.Text = gridView1.GetFocusedRowCellValue("İlçe").ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _customerDal.Delete(new Customer
                {
                    CustomerId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MüşteriId"))
                });
                LoadCustomers2();
                MessageBox.Show("Müşteri sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmMail = new FrmMail();
            frmMail.Mail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mail").ToString();
            frmMail.Show();
        }

        private void lkupİl_EditValueChanged(object sender, EventArgs e)
        {
            LoadCountry();
        }
    }
}
