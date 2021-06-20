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
    public partial class islemlerim : Form
    {
        public islemlerim()
        {
            InitializeComponent();
        }

        internal static string odemeDurumu = "";
        internal static int odemeID;
        internal static string odemeToplamFiyat;

        OleDbConnection con = new OleDbConnection(@"provider=microsoft.jet.oledb.4.0;data source="+ Application.StartupPath + "\\rentacar.mdb");
        OleDbDataAdapter dAdapter;
        DataSet dataSet;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void islemTablosuDoldur()
        {
            dAdapter = new OleDbDataAdapter("SELECT * FROM islem WHERE (arac_sahip='"+ Form1.kullaniciAdi +"')",con);
            dataSet = new DataSet();
            con.Open();
            dAdapter.Fill(dataSet, "islem");
            islemlerimGrid.DataSource = dataSet.Tables["islem"];

            islemlerimGrid.Columns[0].HeaderText = "ID";
            islemlerimGrid.Columns[1].HeaderText = "MARKA";
            islemlerimGrid.Columns[2].HeaderText = "NEREDEN";
            islemlerimGrid.Columns[3].HeaderText = "NEREYE";
            islemlerimGrid.Columns[4].HeaderText = "SÜRÜCÜ YAŞI";
            islemlerimGrid.Columns[5].HeaderText = "EHLİYET TÜRÜ";
            islemlerimGrid.Columns[6].HeaderText = "KAÇ GÜN";
            islemlerimGrid.Columns[7].HeaderText = "TOPLAM FİYAT";
            islemlerimGrid.Columns[8].HeaderText = "KİRALANAN TARİH";
            islemlerimGrid.Columns[9].HeaderText = "İADE TARİHİ";
            islemlerimGrid.Columns[10].HeaderText = "ARAÇ SAHİBİ";
            islemlerimGrid.Columns[11].HeaderText = "ÖDEME DURUMU";

            con.Close();
        }

        private void islemlerim_Load(object sender, EventArgs e)
        {
            islemTablosuDoldur();
        }

        private void islemlerimGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            odemeDurumuLabel.Text = islemlerimGrid.CurrentRow.Cells[11].Value.ToString();
            odemeDurumuID.Text = islemlerimGrid.CurrentRow.Cells[0].Value.ToString();
            odemeDurumuToplamFiyat.Text = islemlerimGrid.CurrentRow.Cells[7].Value.ToString();

            odemeDurumu = odemeDurumuLabel.Text;
            odemeID = Convert.ToInt16(odemeDurumuID.Text);
            odemeToplamFiyat = odemeDurumuToplamFiyat.Text;

        }

        private void odemeTamamla_button_Click(object sender, EventArgs e)
        {
            if(odemeDurumu != "Ödendi")
            {
                ÖdemeBilgileri odeme_ekrani = new ÖdemeBilgileri();
                odeme_ekrani.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seçili işlemin ödemesi zaten yapıldı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            anaekran anaEkran = new anaekran();
            anaEkran.Show();
            this.Close();

        }
    }
}
