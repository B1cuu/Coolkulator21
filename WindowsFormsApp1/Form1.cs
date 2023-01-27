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

		private void bBMI_Click(object sender, EventArgs e)
		{
			BMI form = new BMI();
			form.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void bKal_Click(object sender, EventArgs e)
		{
            Kalku form = new Kalku();
            form.Show();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			Temp form = new Temp();
			form.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			wzory form = new wzory();
			form.Show();
		}
	}
}
