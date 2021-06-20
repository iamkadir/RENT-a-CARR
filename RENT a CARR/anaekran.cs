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
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        OleDbConnection con = new OleDbConnection(@"provider=microsoft.jet.oledb.4.0;data source=rentacar.mdb");
        

        private void button4_Click(object sender, EventArgs e)
        {
            İletişim frm = new İletişim();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezervasyon frm = new Rezervasyon();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YolYardım frm = new YolYardım();
            frm.Show();
            this.Hide();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İst rent a car şirketi 2018 yılında kurulmuştur." + "\n" + "Araç Kiralama ve Yol Yardım hizmetleri vermektedir." + "\n" + "Tecrübelerimizi ve deneyimlerimizi ön plana çıkararak" + "\n" + "sadık müşterilerimize bu fırsatı sunmaktan mutluluk ve gurur duyuyoruz." , "Bilgi",MessageBoxButtons.OK , MessageBoxIcon.Information );
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void anaekran_Load(object sender, EventArgs e)
        {
            string kullanici_ismi = Form1.kullaniciAdi;

            try
            {
                con.Open();
                OleDbCommand getUserName = new OleDbCommand("SELECT ad,soyad FROM kullanici WHERE (usrnme='" + kullanici_ismi + "')", con);
                OleDbDataReader dr = getUserName.ExecuteReader();
                while(dr.Read())
                {
                    hosgeldinText_label.Text = "Hoş geldin " + dr["ad"].ToString() + " " + dr["soyad"].ToString() + "!";
                }
                con.Close();
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Hata Mesajı");
                con.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            islemlerim islemSayfasi = new islemlerim();
            islemSayfasi.Show();
            this.Hide();
        }
    }
}
