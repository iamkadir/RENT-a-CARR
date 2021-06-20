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
    public partial class KayıtEkranı : Form
    {
        public KayıtEkranı()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\rentacar.mdb");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kayitEmail_textbox.Text;
            string ad = kayitAd_textbox.Text;
            string soyad = kayitSoyad_textbox.Text;
            string telefon = kayitGsm_textbox.Text;
            string email = kayitEmail_textbox.Text;
            string sifre = kayitSifre_textbox.Text;
            string sifreOnay = kayitSifreOnay_textbox.Text;
            int guvenlikSoru = kayitGuvenlikSorusu_cmbx.SelectedIndex;
            string guvenlikCevap = kayitGuvenlikSorusuCevap_textbox.Text;

            string cinsiyet = "";
            if(kayitRadio_erkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadın";
            }

            if(kayitAd_textbox.Text != "" && kayitSoyad_textbox.Text != "" && kayitGsm_textbox.Text !="" && kayitEmail_textbox.Text != "" && kayitSifre_textbox.Text != "" && kayitSifreOnay_textbox.Text != "" && kayitGuvenlikSorusuCevap_textbox.Text != "")
            {
                if(kayitSifre_textbox.Text != kayitSifreOnay_textbox.Text)
                {
                    MessageBox.Show("Şifreler birbiriyle uyumlu değil, lütfen tekrar deneyin");
                }
                else
                {
                    try
                    {
                        con.Open();
                        OleDbCommand userAdd = new OleDbCommand("INSERT INTO kullanici(usrnme,psword,email,telefon,ad,soyad,guvenlikSoru,guvenlikCevap) values (@usrnme,@psword,@email,@telefon,@ad,@soyad,@guvenlikSoru,@guvenlikCevap)", con);
                        userAdd.Parameters.Add("usrnme", kullaniciAdi);
                        userAdd.Parameters.Add("psword", sifre);
                        userAdd.Parameters.Add("email", email);
                        userAdd.Parameters.Add("telefon", telefon);
                        userAdd.Parameters.Add("ad", ad);
                        userAdd.Parameters.Add("soyad", soyad);
                        userAdd.Parameters.Add("guvenlikSoru", guvenlikSoru);
                        userAdd.Parameters.Add("guvenlikCevap", guvenlikCevap);
                        userAdd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Kayıt Başarılı, hoş geldin " + ad.ToUpper() + " " + soyad.ToUpper() + "!");
                        Form1 girisEkrani = new Form1();
                        girisEkrani.Show();
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Hata Mesajı");
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tüm alanların doldurulması zorunludur");
            }

        }

        private void KayıtEkranı_Load(object sender, EventArgs e)
        {
            kayitGuvenlikSorusu_cmbx.Items.Add("İlk kullandığım telefon markası");
            kayitGuvenlikSorusu_cmbx.Items.Add("En sevdiğim renk");
            kayitGuvenlikSorusu_cmbx.Items.Add("En sevdiğim yemek");
            kayitGuvenlikSorusu_cmbx.Items.Add("En son okuduğum okulun ismi");
            kayitGuvenlikSorusu_cmbx.Items.Add("En sevdiğim sayı");
            kayitGuvenlikSorusu_cmbx.Items.Add("En sevdiğim ders");
            kayitGuvenlikSorusu_cmbx.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void KayıtEkranı_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
