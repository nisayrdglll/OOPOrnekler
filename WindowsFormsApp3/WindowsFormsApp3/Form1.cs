using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double dVize, dFinal, dOdev, dDevamsizlik, dOrtalama;
            dVize = Convert.ToDouble(txtVize.Text);
            dFinal = Convert.ToDouble(txtFinal.Text);
            dOdev = Convert.ToDouble(txtOdev.Text);
            dDevamsizlik = Convert.ToDouble(txtDevam.Text);

            dOrtalama = (dVize * 0.3) + (dFinal * 0.4) + (dOdev * 0.2) + (dDevamsizlik * 0.1);
            lblOrtalama.Text = dOrtalama.ToString();
            if(dOrtalama>=50)
            {
                lblDurum.Text = "Geçtiniz";
                lblDurum.ForeColor = Color.Green;
            }
            else
            {
                lblDurum.Text = "Kaldınız";
                lblDurum.ForeColor = Color.Red;
            }
        }
    }
}
