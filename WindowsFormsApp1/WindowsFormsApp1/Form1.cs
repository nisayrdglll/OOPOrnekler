using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla(object sender, EventArgs e)
        {
            int iTutar = 0;
            if(chbxCay.Checked)
            {
                iTutar = iTutar + 2;
            }
            if(chbxKahve.Checked)
            {
                iTutar = iTutar + 3;
            }
            if(chbxKraker.Checked)
            {
                iTutar = iTutar+1;
            }
            if(chbxCikolata.Checked)
            {
                iTutar = iTutar + 4;
            }
            txtHesapla.Text = iTutar.ToString();
        }
    }
}
