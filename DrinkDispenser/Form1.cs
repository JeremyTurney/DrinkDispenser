using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkDispenser
{
	public partial class DrinkForm : Form
	{
		public DrinkForm()
		{
			InitializeComponent();
		}

		private void Coffee_Click(object sender, EventArgs e)
		{
			Coffee c = new Coffee();
			c.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Sports s = new Sports();
			s.Show();
		}

		private void Soda_Click(object sender, EventArgs e)
		{
			Soda s = new Soda();
			s.Show();
		}

		private void Energy_Click(object sender, EventArgs e)
		{
			Energy n = new Energy();
			n.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
