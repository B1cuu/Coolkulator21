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
	public partial class Temp : Form
	{
		public Temp()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			float a;
			a = float.Parse(textBox1.Text);
			float result = (a - 32) * 5 / 9;

			MessageBox.Show("Wynik wynosi" + " " + result.ToString("N2") + " " + "Celcjusza");
		}

		private void button2_Click(object sender, EventArgs e)
		{
            float b;
            b = float.Parse(textBox2.Text);
            float result = (b * 9 / 5 ) + 32;

            MessageBox.Show("Wynik wynosi" + " " + result.ToString("N2") + " " + "Farenhaita");
        }

		private void button3_Click(object sender, EventArgs e)
		{
			float c;
			c = float.Parse(textBox3.Text);

			float  result = (float)(c + 273.15);

            MessageBox.Show("Wynik wynosi" + " " + result.ToString("N2") + " " + "Kelwinow");
			        }

		private void button4_Click(object sender, EventArgs e)
		{
			float d;
			d = float.Parse(textBox4.Text);
			float result = (float)(d - 273.15);
            MessageBox.Show("Wynik wynosi" + " " + result.ToString("N2") + " " + "Celcjusza");
        }

		private void button5_Click(object sender, EventArgs e)
		{
			float k;
			k = float.Parse(textBox5.Text);
			float result = (float)((float)((k - 32) / 1.8000) + 273.15);

            MessageBox.Show("Wynik wynosi" + " " + result.ToString("N2") + " " + "Kelwinow");
        }

		private void button6_Click(object sender, EventArgs e)
		{
			float t;
			t = float.Parse(textBox6.Text);
			float result = (float)((t - 273.15) * 1.8000 + 32.00);
            MessageBox.Show("Wynik wynosi" + " " + result.ToString("N2") + " " + "Farenhaitow");

        }
	}
}
