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
    public partial class FrmEmployeeUsers : Form
    {
        public FrmEmployeeUsers()
        {
            InitializeComponent();
        }

        private UserDal _userDal = new UserDal();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _userDal.add(new User
                {
                    UserName = txtKullanıcıAdı.Text,
                    Password = txtŞifre.Text,
                    UserType = Convert.ToInt32(1)
                });
                MessageBox.Show("Kullanıcı bilgileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        
    }
}
