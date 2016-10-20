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
	public partial class Energy : Form
	{
		public Energy()
		{
			InitializeComponent();
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			foreach (Control c in EnergyBox.Controls)
			{
				if (c is RadioButton)
				{
					((RadioButton)c).Checked = false;
				}
			}

		}

		private void Finish_Click(object sender, EventArgs e)
		{
			if (Red.Checked)
			{
				MessageBox.Show("One Red Bull on its way");
				this.Close();
			}
			else if (Rock.Checked)
			{
				MessageBox.Show("One RockStar on its way");
				this.Close();
			}
			else if (Nos.Checked)
			{
				MessageBox.Show("One NOS on its way");
				this.Close();
			}
			else if (Amp.Checked)
			{
				MessageBox.Show("One AMP on its way");
				this.Close();
			}
			else if (Monster.Checked)
			{
				MessageBox.Show("One Monster on its way");
				this.Close();
			}
			else if (Full.Checked)
			{
				MessageBox.Show("One Full Throttle on its way");
				this.Close();
			}
		}
	}
}
