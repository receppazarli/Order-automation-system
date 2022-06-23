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
    public partial class FrmCustomerUserSignUp : Form
    {
        public FrmCustomerUserSignUp()
        {
            InitializeComponent();
        }

        private CustomerDal _customerDal = new CustomerDal();
        private UserDal _userDal = new UserDal();
        
        private void btnKayıtOl_Click(object sender, EventArgs e)
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
                Address = txtAdres.Text
            });

            _userDal.add(new User
            {
                UserName = txtKullanıcıAdı.Text,
                Password = txtŞifre.Text,
                UserType = Convert.ToInt32(2)
            });

            MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("MüşteriId Numaranız En kısa süre de Mail olara size ulaşacaktır." +
                            "(Spam ve Gereksiz Kutusunu Kontrol etmeyi Unutmayın Sağlıklı Günler)", "Bilgilendirme",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCustomerUserSignUp_Load(object sender, EventArgs e)
        {
           
            LoadCity();
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

        
    }
}
