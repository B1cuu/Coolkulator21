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
	public partial class Kalku : Form
	{
		public Kalku()
		{
			InitializeComponent();
		}

        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzialania = ' ';
        private void bczysc_Click(object sender, EventArgs e)
		{
            if (RodzajDzialania == ' ' && LiczbaPierwsza.Length > 0)
            {
                LiczbaPierwsza = LiczbaPierwsza.Remove(LiczbaPierwsza.Length - 1);
                tbWynik.Text = LiczbaPierwsza;
            }
            else if (RodzajDzialania != ' ' && LiczbaDruga.Length > 0)
            {
                LiczbaDruga = LiczbaDruga.Remove(LiczbaDruga.Length - 1);
                tbWynik.Text = LiczbaDruga;
            }


            RodzajDzialania = ' ';
            LiczbaPierwsza = String.Empty;
            LiczbaDruga = String.Empty;
            tbWynik.Text = String.Empty;
        }

		private void b0_Click(object sender, EventArgs e)
		{
            Dzialanie(0);
        }

		private void b1_Click(object sender, EventArgs e)
		{
            Dzialanie(1);
        }

		private void b2_Click(object sender, EventArgs e)
		{
            Dzialanie(2);
        }

		private void b3_Click(object sender, EventArgs e)
		{
            Dzialanie(3);
        }

		private void b4_Click(object sender, EventArgs e)
		{
            Dzialanie(4);
        }

		private void b5_Click(object sender, EventArgs e)
		{
            Dzialanie(5);
        }

		private void b6_Click(object sender, EventArgs e)
		{
            Dzialanie(6);
        }

		private void b7_Click(object sender, EventArgs e)
		{
            Dzialanie(7);
        }

		private void b8_Click(object sender, EventArgs e)
		{
            Dzialanie(8);
        }

		private void b9_Click(object sender, EventArgs e)
		{
            Dzialanie(9);
        }

		private void bDodawanie_Click(object sender, EventArgs e)
		{
            RodzajDzialania = '+';
            tbWynik.Text = "";
        }

		private void bOdejmowanie_Click(object sender, EventArgs e)
		{
            RodzajDzialania = '-';
            tbWynik.Text = "";
        }

		private void bMnozenie_Click(object sender, EventArgs e)
		{
            RodzajDzialania = '*';
            tbWynik.Text = "";
        }

		private void bDzielenie_Click(object sender, EventArgs e)
		{
            RodzajDzialania = '/';
            tbWynik.Text = "";
        }

		private void bWynik_Click(object sender, EventArgs e)
		{
            switch (RodzajDzialania)
            {
                case ('+'):
                    tbWynik.Text = (float.Parse(LiczbaPierwsza) + float.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    tbWynik.Text = (float.Parse(LiczbaPierwsza) - float.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    tbWynik.Text = (float.Parse(LiczbaPierwsza) * float.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    tbWynik.Text = (float.Parse(LiczbaPierwsza) / float.Parse(LiczbaDruga)).ToString("N5");
                    break;

            }
            LiczbaPierwsza = "";
            LiczbaDruga = "";
            RodzajDzialania = ' ';
        }

		private void Kalku_Load(object sender, EventArgs e)
		{

		}

		private void txtWynik_TextChanged(object sender, EventArgs e)
		{

		}
        private void Dzialanie(float Liczba)
        {
            if (RodzajDzialania == ' ')
            {
                LiczbaPierwsza += Liczba;
                tbWynik.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += Liczba;
                tbWynik.Text = LiczbaDruga;
            }
        }
    }
}
