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
	public partial class Soda : Form
	{
		public Soda()
		{
			InitializeComponent();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			foreach (Control c in SodaBox.Controls)
			{
				if (c is RadioButton)
				{
					((RadioButton)c).Checked = false;
				}
			}
		}

		private void Finish_Click(object sender, EventArgs e)
		{
			if (Pepsi.Checked)
			{
				MessageBox.Show("One Pepsi on its way");
				this.Close();
			}
			else if (Mtn.Checked)
			{
				MessageBox.Show("One Mountain Dew on its way");
				this.Close();
			}
			else if (Dr.Checked)
			{
				MessageBox.Show("One Dr. Pepper on its way");
				this.Close();
			}
			else if (Coke.Checked)
			{
				MessageBox.Show("One Coke on its way");
				this.Close();
			}
			else if (Sprite.Checked)
			{
				MessageBox.Show("One Sprite on its way");
				this.Close();
			}
			else if (Mug.Checked)
			{
				MessageBox.Show("One Mug Root Beer on its way");
				this.Close();
			}
		}
	}
}
