using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace RENT_a_CARR
{
    public partial class MailGonder : Form
    {
        public MailGonder()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("istrentacarr@outlook.com", "rent0234");              
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(label4.Text);
            mesajım.From = new MailAddress("istrentacarr@outlook.com");
            mesajım.Subject = textBoxkonu.Text;
            mesajım.Body = textBoxicerik.Text + "\n" + "\n" + txtkullanicimail.Text;
            istemci.Send(mesajım);
            MessageBox.Show("Mailiniz Gönderildi" + "\n" + "Teşekkürler");
             


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            İletişim frm = new İletişim();
            frm.Show();
            this.Hide();
        }

        private void textBoxeposta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
