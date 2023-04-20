using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            double dSayi1, dSayi2, dSonuc;

            dSayi1 = Convert.ToDouble(txtSayi1.Text);
            dSayi2 = Convert.ToDouble(txtSayi2.Text);

            char cSembol;

            cSembol = Convert.ToChar(txtİslem.Text);

            switch (cSembol)
            {
                case '+':
                    dSonuc = dSayi1 + dSayi2;
                    lblSonuc.Text = dSonuc.ToString("0.00");
                    break;

                case '-':
                    dSonuc = dSayi1 - dSayi2;
                    lblSonuc.Text = dSonuc.ToString("0.00");
                    break;

                case '*':
                    dSonuc = dSayi1 * dSayi2;
                    lblSonuc.Text = dSonuc.ToString("0.00");
                    break;

                case '/':
                    dSonuc = dSayi1 / dSayi2;
                    lblSonuc.Text = dSonuc.ToString("0.00");
                    break;

                default:
                    MessageBox.Show("Lütfen + , - , * veya / gibi bir sembol giriniz!");
                    break;
            }
        }
    }
}
