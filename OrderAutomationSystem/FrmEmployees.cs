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
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
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
            lkuİlçe.EditValue = null;
        }

        private EmployeeDal _employeeDal = new EmployeeDal();
        private void FrmEmployees_Load(object sender, EventArgs e)
        {

            LoadEmployees2();
            Clear();
            LoadCity();
        }

        private void LoadEmployees()
        {
            grcPersoneller.DataSource = _employeeDal.GetAll();
        }

        void LoadEmployees2()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = from e in context.Employees
                             select new
                             {
                                 PersonelId=e.EmployeeId,
                                 Ad = e.FirstName,
                                 Soyadı = e.LastName,
                                 TC = e.IdentityNumber,
                                 Banka = e.BankName,
                                 Iban = e.Iban,
                                 Telefon = e.Phone,
                                 Mail = e.Mail,
                                 İl = e.City,
                                 İlçe = e.Country,
                                 Adres = e.Address
                             };
                grcPersoneller.DataSource = entity.ToList();
            }
        }
        private FrmEmployeeUsers employeeUsers = new FrmEmployeeUsers();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeDal.Add(new Employee
                {
                    FirstName = txtAd.Text,
                    LastName = txtSoyad.Text,
                    IdentityNumber = txtTC.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    Mail = txtMail.Text,
                    City = lkupİl.Text,
                    Country = lkuİlçe.Text,
                    Address = txtAdres.Text
                });
                LoadEmployees2();
                MessageBox.Show("Personel sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                employeeUsers = new FrmEmployeeUsers();
                employeeUsers.Show();
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
                _employeeDal.Update(new Employee
                {
                    EmployeeId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PersonelId")),
                    FirstName = txtAd.Text,
                    LastName = txtSoyad.Text,
                    IdentityNumber = txtTC.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    Mail = txtMail.Text,
                    City = lkupİl.Text,
                    Country = lkuİlçe.Text,
                    Address = txtAdres.Text
                });
                LoadEmployees2();
                MessageBox.Show("Personel güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
            lkuİlçe.Text = gridView1.GetFocusedRowCellValue("İlçe").ToString();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeDal.Delete(new Employee
                {
                    EmployeeId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PersonelId"))

                });
                LoadEmployees2();
                MessageBox.Show("Müşteri sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lkuİlçe.Properties.DataSource = _countryDal.GetAllCountry(Convert.ToInt32(lkupİl.EditValue)).ToList();
            lkuİlçe.Properties.DisplayMember = "CountryName";
            lkuİlçe.Properties.ValueMember = "Id";
        }
        private void lkupİl_EditValueChanged(object sender, EventArgs e)
        {
            LoadCountry();
        }
    }
}
