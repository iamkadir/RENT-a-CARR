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
    public partial class ÖdemeBilgileri : Form
    {
        public ÖdemeBilgileri()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"provider=microsoft.jet.oledb.4.0;data source=rentacar.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            // Rezervasyon frm = new Rezervasyon();
            string odemeDurumu = "Ödendi";

            // Bugün
            DateTime tarihGuncel = DateTime.Now;
            string tarihGuncelString = tarihGuncel.ToString("dd-MM-yyyy");

            // Eklenecek gün
            DateTime tarihPlusKacGun = DateTime.Now;
            string tarihPlusKacGunString = tarihPlusKacGun.AddDays(Rezervasyon.kacGun).ToString("dd-MM-yyyy");

            if (krediKartNumarasi_text.Text != "" && sonKullanimAyi_textbox.Text != "" && sonKullanimYili_textbox.Text != "" && cvvKodu_textbox.Text != "")
            {
                try
                {
                    con.Open();
                    OleDbCommand odemeDurumuGuncelle = new OleDbCommand("UPDATE islem SET arac_odemeDurumu=@odeme,arac_teslimTarihi=@teslimTarihi,arac_kiraTarihi=@kiraTarihi WHERE (arac_sahip='"+ Form1.kullaniciAdi +"' AND id=@id)",con);
                    odemeDurumuGuncelle.Parameters.Add("odeme", odemeDurumu);
                    odemeDurumuGuncelle.Parameters.Add("teslimTarihi", tarihPlusKacGunString);
                    odemeDurumuGuncelle.Parameters.Add("kiraTarihi", tarihGuncelString);
                    odemeDurumuGuncelle.Parameters.Add("id", islemlerim.odemeID);
                    odemeDurumuGuncelle.ExecuteNonQuery();
                    con.Close(); 
                    MessageBox.Show("Ücretiniz ödenmiştir" + " \n " + "Aracı tercih ettiğiniz şubemizden alabilirsiniz.");
                    anaekran ana_ekran = new anaekran();
                    ana_ekran.Show();
                    this.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Hata Mesajı");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Tüm alanların doldurulması zorunludur");
            }
            
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            kartResim_textbox.Text = krediKartNumarasi_text.Text;
        }

        private void sonKullanimAyi_textbox_TextChanged(object sender, EventArgs e)
        {
            sonKullanimAyResim_text.Text = sonKullanimAyi_textbox.Text;
        }

        private void sonKullanimYili_textbox_TextChanged(object sender, EventArgs e)
        {
            sonKullanimYilResim_text.Text = sonKullanimYili_textbox.Text;
        }

        private void cvvKodu_textbox_TextChanged(object sender, EventArgs e)
        {
            cvvResim_text.Text = cvvKodu_textbox.Text;
        }

        private void ÖdemeBilgileri_Load(object sender, EventArgs e)
        {
            odenecekMiktar_lbl.Text = islemlerim.odemeToplamFiyat.ToString() + " ₺";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            islemlerim islemSayfasi = new islemlerim();
            islemSayfasi.Show();
            this.Close();
        }
    }
}
