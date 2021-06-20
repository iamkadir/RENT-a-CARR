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
using System.Runtime.InteropServices;

namespace RENT_a_CARR
{
    public partial class Rezervasyon : Form
    {


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Rezervasyon()
        {
            InitializeComponent();
        }

        

        OleDbConnection con = new OleDbConnection(@"provider=microsoft.jet.oledb.4.0;data source=rentacar.mdb");
        internal static double toplam = 0;
        internal static int kacGun;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            islemDurumu.Text = "işlem bekleniyor...";
            lbltoplam.Text = 0 + " ₺";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            anaekran frm = new anaekran();
            frm.Show();
            this.Hide();
        }

        // Butonlara tıklandığında sayı değeri textbox'a aktarılıyor
        /* --------------------- BAŞLANGIÇ  --------------------- */
        private void button1_Click_1(object sender, EventArgs e)
        {
            txtArac.Text = 1.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtArac.Text = 2.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtArac.Text = 3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtArac.Text = 4.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtArac.Text = 5.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtArac.Text = 6.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtArac.Text = 7.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtArac.Text = 8.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtArac.Text = 9.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtArac.Text = 10.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtArac.Text = 11.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtArac.Text = 12.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtArac.Text = 13.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtArac.Text = 14.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtArac.Text = 15.ToString();
        }

        /* --------------------- BİTİŞ  --------------------- */


        private void rezervasyonButton_Click(object sender, EventArgs e)
        {
            if(islemDurumu.Text != "işlem bekleniyor...")
            {
                string aracMarka = txtArac.Text;
                string ehliyetTuru = ehliyet_cmbx.Text;
                string surucuYasi = yas_cmbx.Text;
                string nereden = alisYeri_cmbx.Text;
                string nereye = birak_cmbx.Text;
                kacGun = Convert.ToInt32(txtKira.Text);
                string sahip = Form1.kullaniciAdi;
                string odemeDurumu = "Ödenmedi";

                // Bugün
                DateTime tarihGuncel = DateTime.Now;
                string tarihGuncelString = tarihGuncel.ToString("dd-MM-yyyy");

                // Eklenecek gün
                DateTime tarihPlusKacGun = DateTime.Now;
                string tarihPlusKacGunString = tarihPlusKacGun.AddDays(kacGun).ToString("dd-MM-yyyy");


                if (txtArac.Text != "" && ehliyet_cmbx.Text != "" && yas_cmbx.Text != "" && alisYeri_cmbx.Text != "" && birak_cmbx.Text != "" && txtKira.Text != "")
                {
                    try
                    {
                        con.Open();
                        OleDbCommand aracKiraIslemYap = new OleDbCommand("INSERT INTO islem (arac_marka,arac_nereden,arac_nereye,arac_surucuYasi,arac_ehliyetTuru,arac_kacGun,arac_toplamFiyat,arac_kiraTarihi,arac_teslimTarihi,arac_sahip,arac_odemeDurumu) values (@marka,@nereden,@nereye,@surucuYasi,@ehliyetTuru,@kacGun,@toplamFiyat,@kiraTarihi,@teslimTarihi,@sahip,@odemeDurumu)", con);
                        aracKiraIslemYap.Parameters.Add("marka", aracMarka);
                        aracKiraIslemYap.Parameters.Add("nereden", nereden);
                        aracKiraIslemYap.Parameters.Add("nereye", nereye);
                        aracKiraIslemYap.Parameters.Add("surucuYasi", surucuYasi);
                        aracKiraIslemYap.Parameters.Add("ehliyetTuru", ehliyetTuru);
                        aracKiraIslemYap.Parameters.Add("kacGun", kacGun);
                        aracKiraIslemYap.Parameters.Add("toplamFiyat", toplam);
                        aracKiraIslemYap.Parameters.Add("kiraTarihi", tarihGuncelString);
                        aracKiraIslemYap.Parameters.Add("teslimTarihi", tarihPlusKacGunString);
                        aracKiraIslemYap.Parameters.Add("sahip", sahip);
                        aracKiraIslemYap.Parameters.Add("odemeDurumu", odemeDurumu);
                        aracKiraIslemYap.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("İşlem Başarılı, ödeme ekranına gidebilirsiniz");

                        islemlerim islemSayfasi = new islemlerim();
                        islemSayfasi.Show();
                        this.Hide();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Hata Mesajı");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun");
                }
            }
            else
            {
                MessageBox.Show("İşlemi tamamlamak için gerekli alanları doldurun");
            }










            
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {

            if (alisYeri_cmbx.Text != "" && birak_cmbx.Text != "" && yas_cmbx.Text != "" && ehliyet_cmbx.Text != "" && txtArac.Text != "" && txtKira.Text != "")
            {
                int gunsayisi;
                gunsayisi = Convert.ToInt32(txtKira.Text);

                if (txtArac.Text == "1")
                    toplam = gunsayisi * 250;

                else if (txtArac.Text == "2")
                    toplam = gunsayisi * 150;

                else if (txtArac.Text == "4")
                    toplam = gunsayisi * 125;

                else if (txtArac.Text == "5")
                    toplam = gunsayisi * 100;

                else if (txtArac.Text == "7")
                    toplam = gunsayisi * 225;

                else if (txtArac.Text == "8")
                    toplam = gunsayisi * 175;

                else if (txtArac.Text == "3")
                    toplam = gunsayisi * 175;

                else if (txtArac.Text == "6")
                    toplam = gunsayisi * 200;

                else if (txtArac.Text == "9")
                    toplam = gunsayisi * 150;

                else if (txtArac.Text == "10")
                    toplam = gunsayisi * 150;

                else if (txtArac.Text == "11")
                    toplam = gunsayisi * 100;

                else if (txtArac.Text == "12")
                    toplam = gunsayisi * 175;

                else if (txtArac.Text == "13")
                    toplam = gunsayisi * 300;

                else if (txtArac.Text == "14")
                    toplam = gunsayisi * 225;

                else if (txtArac.Text == "15")
                    toplam = gunsayisi * 200;


                if (radioZiraat.Checked)
                {
                    toplam = toplam - toplam * 0.05;
                }
                else if (radioHalk.Checked)
                {
                    toplam = toplam - toplam * 0.08;
                }
                else if (radioIsbank.Checked)
                {
                    toplam = toplam - toplam * 0.10;
                }

                lbltoplam.Text = toplam.ToString() + " ₺";
                islemDurumu.Text = "Rezervasyon yapmaya hazırsınız";
                islemDurumu.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
        }

        private void txtKira_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            lbltoplam.Text = 0 + " ₺";
            alisYeri_cmbx.SelectedItem = null;
            birak_cmbx.SelectedItem = null;
            yas_cmbx.SelectedItem = null;
            ehliyet_cmbx.SelectedItem = null;
            txtArac.Text = "";
            txtKira.Text = "";
            islemDurumu.Text = "işlem bekleniyor...";
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
