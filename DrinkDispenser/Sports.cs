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
	public partial class Sports : Form
	{
		public Sports()
		{
			InitializeComponent();
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			foreach (Control c in groupBox1.Controls)
			{
				if (c is RadioButton)
				{
					((RadioButton)c).Checked = false;
				}
			}

		}

		private void Finish_Click(object sender, EventArgs e)
		{
			if (Grape.Checked)
			{
				MessageBox.Show("One grape Gatorade on its way");
				this.Close();
			}

			else if (Glacier.Checked)
			{
				MessageBox.Show("One glacier ice Gatorade on its way");
				this.Close();

			}

			else if (CoolBlue.Checked)
			{
				MessageBox.Show("One cool blue Gatorade on its way");
				this.Close();

			}

			else if (LemonLime.Checked)
			{
				MessageBox.Show("One lemon lime Gatorade on its way");
				this.Close();

			}

			else if (Grape1.Checked)
			{
				MessageBox.Show("One grape Powerade on its way");
				this.Close();

			}

			else if (Mountain.Checked)
			{
				MessageBox.Show("One mountain berry blast Powerade on its way");
				this.Close();

			}

			else if (LemonLime2.Checked)
			{
				MessageBox.Show("One lemon lime Powerade on its way");
				this.Close();

			}

			else if (Strawberry.Checked)
			{
				MessageBox.Show("One strawberry lemonade Powerade on its way");
				this.Close();
			}
		}
	}
}
