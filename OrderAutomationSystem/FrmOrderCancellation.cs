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
    public partial class FrmOrderCancellation : Form
    {
        public FrmOrderCancellation()
        {
            InitializeComponent();
        }

        private OrderDal _orderDal = new OrderDal();
        private void btnSiparişİptal2_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult Onay= MessageBox.Show("Siparişiniz İptal Etmek İstediğinize Emin misiniz? ", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Onay==DialogResult.Yes)
                {
                    _orderDal.Delete(new Order
                    {
                        OrderId = Convert.ToInt32(txtSiparişId.Text)

                    });
                    MessageBox.Show("Siparişiniz İptal Edildi", "Bilgilendirme", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

    }
}
