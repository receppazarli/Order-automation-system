using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomationSystem
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        public string Mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMailAdresi.Text = Mail;
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage myMessage = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("asdasasdas776@gmail.com", "Asdas.123");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                // myMessage.To.Add(rchtxt_Message.Text);
                myMessage.To.Add(txtMailAdresi.Text);
                myMessage.From = new MailAddress("asdasasdas776@gmail.com");
                myMessage.Subject = txtKonu.Text;
                myMessage.Body = rctxtMesaj.Text;
                client.Send(myMessage);
                MessageBox.Show("Mail Gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Mail Adresi", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


        }
    }
}
