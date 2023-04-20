using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double dUrunFiyati, dUrunAdedi, dKdv = 0, dTutar, dTopTutar;
            dUrunFiyati = Convert.ToDouble(txtUrunFiyat.Text);
            dUrunAdedi= Convert.ToDouble(txtUrunAdet.Text);
            dTutar = dUrunAdedi * dUrunFiyati;
            if(rdbtn1.Checked)
            {
                dKdv = dTutar * 0.01;
            }
            else if (rdbtn8.Checked)
            {
                dKdv = dTutar * 0.08;
            }
            else if (rdbtn18.Checked)
            {
                dKdv = dTutar * 0.18;
            }

            dTopTutar = dTutar + dKdv;
            txtKdvTutar.Text = dKdv.ToString();
            txtTopTutar.Text = dTopTutar.ToString();
        }
    }
}
