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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        OleDbConnection con = new OleDbConnection(@"provider=microsoft.jet.oledb.4.0;data source=rentacar.mdb");

        internal static string kullaniciAdi = "";


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sıfremıunuttum frm = new sıfremıunuttum();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KayıtEkranı frm = new KayıtEkranı();
            frm.Show();
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            
            if(kullaniciTextBox.Text != "" && sifreTextBox.Text != "")
            {
                    kullaniciAdi = kullaniciTextBox.Text;
                    con.Open();
                    OleDbCommand userControl = new OleDbCommand("select * from kullanici where usrnme=@usrnme and psword=@psword", con);
                    userControl.Parameters.Add("usrnme", kullaniciTextBox.Text);
                    userControl.Parameters.Add("psword", sifreTextBox.Text);

                    OleDbDataReader dr = userControl.ExecuteReader();
                    if (dr.Read())
                    {
                        anaekran anaEkran = new anaekran();
                        anaEkran.Show();
                        con.Close();
                        this.Hide();    
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya Şifre yanlış");
                        con.Close();
                    }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre kısımları boş bırakılamaz");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void sifreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
