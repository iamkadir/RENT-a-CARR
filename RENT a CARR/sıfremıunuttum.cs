using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RENT_a_CARR
{
    public partial class sıfremıunuttum : Form
    {
        public sıfremıunuttum()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"provider=microsoft.jet.oledb.4.0;data source=rentacar.mdb");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifreniz Değiştirilmiştir.");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sıfremıunuttum_Load(object sender, EventArgs e)
        {
            guvenlikSorusu_cmbx.Items.Add("İlk kullandığım telefon markası");
            guvenlikSorusu_cmbx.Items.Add("En sevdiğim renk");
            guvenlikSorusu_cmbx.Items.Add("En sevdiğim yemek");
            guvenlikSorusu_cmbx.Items.Add("En son okuduğum okulun ismi");
            guvenlikSorusu_cmbx.Items.Add("En sevdiğim sayı");
            guvenlikSorusu_cmbx.Items.Add("En sevdiğim ders");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sifremiUnuttum_devamButton_Click(object sender, EventArgs e)
        {
            int indexNo;
            if(sifremiUnuttum_email.Text != "")
            {
                try
                {
                    con.Open();
                    OleDbCommand getUserSecurityQuestion = new OleDbCommand("SELECT guvenlikSoru FROM kullanici WHERE (email=@email)",con);
                    getUserSecurityQuestion.Parameters.Add("email", sifremiUnuttum_email.Text);
                    OleDbDataReader dr = getUserSecurityQuestion.ExecuteReader();
                    while (dr.Read())
                    {
                        //guvenlikSorusu_cmbx.SelectedIndex = Convert.ToInt32(dr["guvenlikSoru"]);
                        guvenlikSorusu_cmbx.SelectedIndex = Convert.ToInt32(dr["guvenlikSoru"]);
                    }
                    con.Close();
                    this.Size = new Size(483, 440);
                    sifremiUnuttum_devamButton.Enabled = false;
                    sifremiUnuttum_email.Enabled = false;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Hata Mesajı");
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(guvenlikSorusu_cevap.Text != "")
            {
                try
                {
                    con.Open();
                    OleDbCommand questionControl = new OleDbCommand("SELECT guvenlikCevap FROM kullanici WHERE (email=@email)", con);
                    questionControl.Parameters.Add("email", sifremiUnuttum_email.Text);
                    OleDbDataReader dr = questionControl.ExecuteReader();
                    while (dr.Read())
                    {
                        if(guvenlikSorusu_cevap.Text == dr["guvenlikCevap"].ToString())
                        {
                            MessageBox.Show("Yanıt doğru! şifre değiştirme ekranına gidebilirsiniz");
                        }
                        else
                        {
                            MessageBox.Show("Yanıt doğru değil!");
                            this.Close();
                        }
                    }

                    con.Close();
                    this.Size = new Size(483, 761);
                    guvenlikSorusu_cevap.Enabled = false;
                    sifremiUnuttum_devamButton2.Enabled = false;

                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Hata Mesajı");
                    con.Close();
                }
            }
        }

        private void sifremiUnuttum_gonderButton_Click(object sender, EventArgs e)
        {
            if(guvenlikSorusu_yeniSifre.Text != "" && guvenlikSorusu_yeniSifreTekrar.Text != "")
            {
                if (guvenlikSorusu_yeniSifre.Text == guvenlikSorusu_yeniSifreTekrar.Text)
                {
                    try
                    {
                        con.Open();
                        OleDbCommand passChange = new OleDbCommand("UPDATE kullanici SET psword=@psword WHERE email=@email",con);
                        passChange.Parameters.Add("psword", guvenlikSorusu_yeniSifre.Text);
                        passChange.Parameters.Add("email", sifremiUnuttum_email.Text);
                        passChange.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Şifre başarıyla değiştirildi, giriş ekranına dönüp hesabınıza giriş yapabilirsiniz");
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Hata Mesajı");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifrelerin aynı olduğundan emin olun");
                }
            }
            else
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz");
            }
        }
    }
}
