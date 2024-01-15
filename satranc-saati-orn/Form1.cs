using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satranc_saati_orn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sureBeyaz = 10, suresiyah = 10;

        private void timerBeyaz_Tick(object sender, EventArgs e)
        {
            sureBeyaz--;
            lblBeyaz.Text = sureBeyaz.ToString();

            if(sureBeyaz <=0)
            {
                timerBeyaz.Stop();
                MessageBox.Show("siyah kazandı");
            }
        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            timerBeyaz.Stop();
            timerSiyah.Start();
        }

        private void timerSiyah_Tick(object sender, EventArgs e)
        {
            suresiyah--;
            lblSiyah.Text = suresiyah.ToString();

            if (suresiyah <= 0)
            {
                timerSiyah.Stop();
                MessageBox.Show("beyaz kazandı");
            }
        }

        private void btnsiyah_Click(object sender, EventArgs e)
        {
            timerBeyaz.Start();
            timerSiyah.Stop();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timerBeyaz.Start();
        }
        
    }
}
