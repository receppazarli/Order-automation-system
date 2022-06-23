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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
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

        private bool Control2(string Name, string Pass, int type)
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

       
        private void btnGiriş_Click(object sender, EventArgs e)
        {

            if (Control(txtKullanıcıAdı.Text, txtŞifre.Text, 1))
            {

                FrmAnaModulEmployees anaModulEmployees = new FrmAnaModulEmployees();
                anaModulEmployees.Show();
                this.Hide();
            }
            else if (Control2(txtKullanıcıAdı.Text, txtŞifre.Text, 2))
            {
                FrmAnaModulCustomers anaModulCustomers = new FrmAnaModulCustomers();
                anaModulCustomers.name = txtKullanıcıAdı.Text;
                anaModulCustomers.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı Yada Şifre ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            DialogResult Onay = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Bilgilendirme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Onay == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            FrmSignUp signUp = new FrmSignUp();
            signUp.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
