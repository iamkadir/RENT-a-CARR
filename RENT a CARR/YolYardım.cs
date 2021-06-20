using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RENT_a_CARR
{
    public partial class YolYardım : Form
    {
        public YolYardım()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            anaekran frm = new anaekran();
            frm.Show();
            this.Hide();
        }

        private void buttonaracbozuldu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arızanız İletilmiştir." + "\n" + "Teknik ekibimiz konumunuza yönlendiriliyor.");
        }

        private void araçMarkasıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
