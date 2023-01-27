using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
	public partial class wzory : Form
	{
		public wzory()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string a, b;
			a = (textBox1.Text);
			b = (textBox2.Text);

			string result = "(" + a + " ^2" + "+" + +2 + " * " + a + " * " + b + "+" + "" + b + " ^2" + ")";

			MessageBox.Show("wynik wynosi" + " " + result.ToString());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string c, d;
			c = (textBox3.Text);
			d = (textBox4.Text);
			string result = "(" + c + "^2" + "-" + +2 + " " + c + " * " + d + "+" + "" + d + " ^2 " + ")";
			MessageBox.Show("wynik wynosi" + " " + result.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string r, f;
			r = (textBox5.Text);
			f = (textBox6.Text);
			string result = "(" + r + "^3" + "+" + "3" + "*" + r + "^2" + "*" + f + "+" + 3 + "*"+ r + "*"+ f + "^2" + "+" + f + "^3"+ ")";
			MessageBox.Show("wynik wynosi" + " " + result.ToString());
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string y, u;
			y = (textBox7.Text);
			u = (textBox8.Text);
			string result = "(" + y + "^3" + "-" + "3" + "*" + y + "^2" + "*" + u + "+" + 3 + "*" + y + "*" + u + "^2" + "-" + u + "^3" + ")"; 
			MessageBox.Show("wynik wynosi" + " " + result.ToString());
		}
	}
}
