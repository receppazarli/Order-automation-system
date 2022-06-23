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
    public partial class FrmEmployeeUserUpdate : Form
    {
        public FrmEmployeeUserUpdate()
        {
            InitializeComponent();
        }

        private UserDal _userDal = new UserDal();

        private bool Control(string Name, string Pass, int type)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                //var sorgu= from p in context.Users where  p.UserName==Name && p.Password==Pass &&p.UserType==1 Select p;
                var sorgu = _userDal.GetAll().Where(p => p.UserName == Name && p.Password == Pass && p.UserType == 1);

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



        private void btnGüncelle2_Click(object sender, EventArgs e)
        {
            if (Control(txtKullanıcıAdı.Text, txtEskiŞifre.Text, 1))
            {
                _userDal.Update(new User
                {
                    UserName = txtKullanıcıAdı.Text,
                    Password = txtYeniŞifre.Text,
                    UserType = 1
                });
                MessageBox.Show("Bilgileriniz güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre", "Bilgilendimre", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void FrmEmployeeUserUpdate_Load(object sender, EventArgs e)
        {

        }
    }

}


