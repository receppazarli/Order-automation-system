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
    public partial class FrmCustomerUserUpdate : Form
    {
        public FrmCustomerUserUpdate()
        {
            InitializeComponent();
        }

        private UserDal _userDal = new UserDal();
        private bool Control(string Name, string Pass, int type)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                //var sorgu= from p in context.Users where  p.UserName==Name && p.Password==Pass &&p.UserType==1 Select p;
                var sorgu = _userDal.GetAll().Where(p => p.UserName == Name && p.Password == Pass && p.UserType == 2);

                if (sorgu.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Control(txtKullanıcıAdı.Text, txtEskiŞifre.Text, 2))
                {
                    _userDal.Update(new User
                    {
                        UserName = txtKullanıcıAdı.Text,
                        Password = txtYeniŞifre.Text,
                        UserType = 2
                    });
                    MessageBox.Show("Bilgileriniz güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı Ya da Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Sistem Hatası", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmCustomerUserUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
