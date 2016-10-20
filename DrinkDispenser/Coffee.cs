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
	public partial class Coffee : Form
	{
		public Coffee()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void Finish_Click(object sender, EventArgs e)
		{
			if (Blonde1.Checked)
			{
				if (Sugar.Checked)
				{
					if (Half.Checked)
					{
						string halfs = "One regular blonde coffee with sugar and half and half on its way!";

						if (Whole.Checked)
						{
							string halfwhole = "One regular blonde coffee with sugar, half and half, and whole milk on its way!";


							if (Splenda.Checked)
							{
								string halfwholesplenda = "One regular blonde coffee with sugar, half and half, whole milk, and splenda on its way!";
								MessageBox.Show(halfwholesplenda);
								this.Close();
							}
							else
							{
								MessageBox.Show(halfwhole);
								this.Close();
							}
						}

						else if (Splenda.Checked)
						{
							string sugarhalfsplenda = "One regular blonde coffee with sugar, half and half, and splenda on its way!";
							MessageBox.Show(sugarhalfsplenda);
							this.Close();
						}
						else
						{
							MessageBox.Show(halfs);
							this.Close();
						}
					}

					else if (Whole.Checked)
					{
						string a = "One regular blonde coffee with sugar and whole milk on its way!";

						if (Splenda.Checked)
						{
							string b = "One regular blonde coffee with sugar, whole milk, and splenda on its way!";
							MessageBox.Show(b);
							this.Close();
						}
						else
						{
							MessageBox.Show(a);
							this.Close();
						}
					}

					else if (Splenda.Checked)
					{
						string c = "One regular blonde coffee with sugar and splenda on its way!";
						MessageBox.Show(c);
						this.Close();
					}

					else
					{
						MessageBox.Show("One regular blonde coffee with sugar on its way");
						this.Close();
					}
				}

				else if (Half.Checked)
				{
					if (Whole.Checked)
					{
						string halfwhole1 = "One regular blonde coffee with half and half and whole milk on its way!";

						if (Splenda.Checked)
						{
							string halfwholesplenda1 = "One regular blonde coffee with half and half, whole milk, and splenda on its way!";
							MessageBox.Show(halfwholesplenda1);
							this.Close();
						}
						else
						{
							MessageBox.Show(halfwhole1);
							this.Close();
						}
					}
					else if (Splenda.Checked)
					{
						string halfwholesplenda = "One regular blonde coffee with half and half and splenda on its way!";
						MessageBox.Show(halfwholesplenda);
						this.Close();
					}
					else
					{
						string h = "One regular blonde coffee with half and half on its way!";
						MessageBox.Show(h);
					}

				}

				else if (Whole.Checked)
				{
					string w = "One regular blonde coffee with whole milk on its way!";

					if (Splenda.Checked)
					{
						string halfwholesplenda1 = "One regular blonde coffee with whole and splenda on its way!";
						MessageBox.Show(halfwholesplenda1);
						this.Close();
					}
					else
					{
						MessageBox.Show(w);
						this.Close();
					}
				}

				else if (Splenda.Checked)
				{
					string s = "One regular blonde coffee with splenda on its way!";
					MessageBox.Show(s);
					this.Close();
				}

				else
				{
					string blonde = "One regular blonde coffee on its way";
					MessageBox.Show(blonde);
					this.Close();
				}

			}

			else if (Blonde2.Checked)
				{
					if (Sugar.Checked)
					{
						if (Half.Checked)
						{
							string halfs = "One decaf blonde coffee with sugar and half and half on its way!";

							if (Whole.Checked)
							{
								string halfwhole = "One decaf blonde coffee with sugar, half and half, and whole milk on its way!";


								if (Splenda.Checked)
								{
									string halfwholesplenda = "One decaf blonde coffee with sugar, half and half, whole milk, and splenda on its way!";
									MessageBox.Show(halfwholesplenda);
									this.Close();
								}
								else
								{
									MessageBox.Show(halfwhole);
									this.Close();
								}
							}

							else if (Splenda.Checked)
							{
								string sugarhalfsplenda = "One decaf blonde coffee with sugar, half and half, and splenda on its way!";
								MessageBox.Show(sugarhalfsplenda);
								this.Close();
							}
							else
							{
								MessageBox.Show(halfs);
								this.Close();
							}
						}

						else if (Whole.Checked)
						{
							string a = "One decaf blonde coffee with sugar and whole milk on its way!";

							if (Splenda.Checked)
							{
								string b = "One decaf blonde coffee with sugar, whole milk, and splenda on its way!";
								MessageBox.Show(b);
								this.Close();
							}
							else
							{
								MessageBox.Show(a);
								this.Close();
							}
						}

						else if (Splenda.Checked)
						{
							string c = "One decaf blonde coffee with sugar and splenda on its way!";
							MessageBox.Show(c);
							this.Close();
						}

						else
						{
							MessageBox.Show("One decaf blonde coffee with sugar on its way");
							this.Close();
						}
					}

					else if (Half.Checked)
					{
						if (Whole.Checked)
						{
							string halfwhole1 = "One decaf blonde coffee with half and half and whole milk on its way!";

							if (Splenda.Checked)
							{
								string halfwholesplenda1 = "One decaf blonde coffee with half and half, whole milk, and splenda on its way!";
								MessageBox.Show(halfwholesplenda1);
								this.Close();
							}
							else
							{
								MessageBox.Show(halfwhole1);
								this.Close();
							}
						}
						else if (Splenda.Checked)
						{
							string halfwholesplenda = "One decaf blonde coffee with half and half and splenda on its way!";
							MessageBox.Show(halfwholesplenda);
							this.Close();
						}
						else
						{
							string h = "One decaf blonde coffee with half and half on its way!";
							MessageBox.Show(h);
						}

					}

					else if (Whole.Checked)
					{
						string w = "One decaf blonde coffee with whole milk on its way!";

						if (Splenda.Checked)
						{
							string halfwholesplenda1 = "One decaf blonde coffee with whole and splenda on its way!";
							MessageBox.Show(halfwholesplenda1);
							this.Close();
						}
						else
						{
							MessageBox.Show(w);
							this.Close();
						}
					}

					else if (Splenda.Checked)
					{
						string s = "One decaf blonde coffee with splenda on its way!";
						MessageBox.Show(s);
						this.Close();
					}

					else
					{
						string blonde = "One decaf blonde coffee on its way";
						MessageBox.Show(blonde);
						this.Close();
					}

				}

			else if (Medium1.Checked)
			{
					if (Sugar.Checked)
					{
						if (Half.Checked)
						{
							string halfs = "One regular medium coffee with sugar and half and half on its way!";

							if (Whole.Checked)
							{
								string halfwhole = "One regular medium coffee with sugar, half and half, and whole milk on its way!";


								if (Splenda.Checked)
								{
									string halfwholesplenda = "One regular medium coffee with sugar, half and half, whole milk, and splenda on its way!";
									MessageBox.Show(halfwholesplenda);
									this.Close();
								}
								else
								{
									MessageBox.Show(halfwhole);
									this.Close();
								}
							}

							else if (Splenda.Checked)
							{
								string sugarhalfsplenda = "One regular medium coffee with sugar, half and half, and splenda on its way!";
								MessageBox.Show(sugarhalfsplenda);
								this.Close();
							}
							else
							{
								MessageBox.Show(halfs);
								this.Close();
							}
						}

						else if (Whole.Checked)
						{
							string a = "One regular medium coffee with sugar and whole milk on its way!";

							if (Splenda.Checked)
							{
								string b = "One regular medium coffee with sugar, whole milk, and splenda on its way!";
								MessageBox.Show(b);
								this.Close();
							}
							else
							{
								MessageBox.Show(a);
								this.Close();
							}
						}

						else if (Splenda.Checked)
						{
							string c = "One regular medium coffee with sugar and splenda on its way!";
							MessageBox.Show(c);
							this.Close();
						}

						else
						{
							MessageBox.Show("One regular medium coffee with sugar on its way");
							this.Close();
						}
					}

					else if (Half.Checked)
					{
						if (Whole.Checked)
						{
							string halfwhole1 = "One regular medium coffee with half and half and whole milk on its way!";

							if (Splenda.Checked)
							{
								string halfwholesplenda1 = "One regular medium coffee with half and half, whole milk, and splenda on its way!";
								MessageBox.Show(halfwholesplenda1);
								this.Close();
							}
							else
							{
								MessageBox.Show(halfwhole1);
								this.Close();
							}
						}
						else if (Splenda.Checked)
						{
							string halfwholesplenda = "One regular medium coffee with half and half and splenda on its way!";
							MessageBox.Show(halfwholesplenda);
							this.Close();
						}
						else
						{
							string h = "One regular medium coffee with half and half on its way!";
							MessageBox.Show(h);
							this.Close();
						}

					}

					else if (Whole.Checked)
					{
						string w = "One regular medium coffee with whole milk on its way!";

						if (Splenda.Checked)
						{
							string halfwholesplenda1 = "One regular medium coffee with whole and splenda on its way!";
							MessageBox.Show(halfwholesplenda1);
							this.Close();
						}
						else
						{
							MessageBox.Show(w);
							this.Close();
						}
					}

					else if (Splenda.Checked)
					{
						string s = "One regular medium coffee with splenda on its way!";
						MessageBox.Show(s);
						this.Close();
					}

					else
					{
						string blonde = "One regular medium coffee on its way";
						MessageBox.Show(blonde);
						this.Close();
					}
			}

			else if (Medium2.Checked)
			{
				if (Sugar.Checked)
				{
					if (Half.Checked)
					{
						string halfs = "One decaf medium coffee with sugar and half and half on its way!";

						if (Whole.Checked)
						{
							string halfwhole = "One decaf medium coffee with sugar, half and half, and whole milk on its way!";


							if (Splenda.Checked)
							{
								string halfwholesplenda = "One decaf medium coffee with sugar, half and half, whole milk, and splenda on its way!";
								MessageBox.Show(halfwholesplenda);
								this.Close();
							}
							else
							{
								MessageBox.Show(halfwhole);
								this.Close();
							}
						}

						else if (Splenda.Checked)
						{
							string sugarhalfsplenda = "One decaf medium coffee with sugar, half and half, and splenda on its way!";
							MessageBox.Show(sugarhalfsplenda);
							this.Close();
						}
						else
						{
							MessageBox.Show(halfs);
							this.Close();
						}
					}

					else if (Whole.Checked)
					{
						string a = "One decaf medium coffee with sugar and whole milk on its way!";

						if (Splenda.Checked)
						{
							string b = "One decaf medium coffee with sugar, whole milk, and splenda on its way!";
							MessageBox.Show(b);
							this.Close();
						}
						else
						{
							MessageBox.Show(a);
							this.Close();
						}
					}

					else if (Splenda.Checked)
					{
						string c = "One decaf medium coffee with sugar and splenda on its way!";
						MessageBox.Show(c);
						this.Close();
					}

					else
					{
						MessageBox.Show("One decaf medium coffee with sugar on its way");
						this.Close();
					}
				}

				else if (Half.Checked)
				{
					if (Whole.Checked)
					{
						string halfwhole1 = "One decaf medium coffee with half and half and whole milk on its way!";

						if (Splenda.Checked)
						{
							string halfwholesplenda1 = "One decaf medium coffee with half and half, whole milk, and splenda on its way!";
							MessageBox.Show(halfwholesplenda1);
							this.Close();
						}
						else
						{
							MessageBox.Show(halfwhole1);
							this.Close();
						}
					}
					else if (Splenda.Checked)
					{
						string halfwholesplenda = "One decaf medium coffee with half and half and splenda on its way!";
						MessageBox.Show(halfwholesplenda);
						this.Close();
					}
					else
					{
						string h = "One decaf medium coffee with half and half on its way!";
						MessageBox.Show(h);
					}

				}

				else if (Whole.Checked)
				{
					string w = "One decaf medium coffee with whole milk on its way!";

					if (Splenda.Checked)
					{
						string halfwholesplenda1 = "One decaf medium coffee with whole and splenda on its way!";
						MessageBox.Show(halfwholesplenda1);
						this.Close();
					}
					else
					{
						MessageBox.Show(w);
						this.Close();
					}
				}

				else if (Splenda.Checked)
				{
					string s = "One decaf mediume coffee with splenda on its way!";
					MessageBox.Show(s);
					this.Close();
				}

				else
				{
					string blonde = "One decaf medium coffee on its way";
					MessageBox.Show(blonde);
					this.Close();
				}

			}

			else if (Dark1.Checked)
			{
				if (Sugar.Checked)
				{
					if (Half.Checked)
					{
						string halfs = "One regular dark coffee with sugar and half and half on its way!";

						if (Whole.Checked)
						{
							string halfwhole = "One regular dark coffee with sugar, half and half, and whole milk on its way!";


							if (Splenda.Checked)
							{
								string halfwholesplenda = "One regular dark coffee with sugar, half and half, whole milk, and splenda on its way!";
								MessageBox.Show(halfwholesplenda);
								this.Close();
							}
							else
							{
								MessageBox.Show(halfwhole);
								this.Close();
							}
						}

						else if (Splenda.Checked)
						{
							string sugarhalfsplenda = "One regular dark coffee with sugar, half and half, and splenda on its way!";
							MessageBox.Show(sugarhalfsplenda);
							this.Close();
						}
						else
						{
							MessageBox.Show(halfs);
							this.Close();
						}
					}

					else if (Whole.Checked)
					{
						string a = "One regular dark coffee with sugar and whole milk on its way!";

						if (Splenda.Checked)
						{
							string b = "One regular dark coffee with sugar, whole milk, and splenda on its way!";
							MessageBox.Show(b);
							this.Close();
						}
						else
						{
							MessageBox.Show(a);
							this.Close();
						}
					}

					else if (Splenda.Checked)
					{
						string c = "One regular dark coffee with sugar and splenda on its way!";
						MessageBox.Show(c);
						this.Close();
					}

					else
					{
						MessageBox.Show("One regular dark coffee with sugar on its way");
						this.Close();
					}
				}

				else if (Half.Checked)
				{
					if (Whole.Checked)
					{
						string halfwhole1 = "One regular dark coffee with half and half and whole milk on its way!";

						if (Splenda.Checked)
						{
							string halfwholesplenda1 = "One regular dark coffee with half and half, whole milk, and splenda on its way!";
							MessageBox.Show(halfwholesplenda1);
							this.Close();
						}
						else
						{
							MessageBox.Show(halfwhole1);
							this.Close();
						}
					}
					else if (Splenda.Checked)
					{
						string halfwholesplenda = "One regular dark coffee with half and half and splenda on its way!";
						MessageBox.Show(halfwholesplenda);
						this.Close();
					}
					else
					{
						string h = "One regular dark coffee with half and half on its way!";
						MessageBox.Show(h);
					}

				}

				else if (Whole.Checked)
				{
					string w = "One regular dark coffee with whole milk on its way!";

					if (Splenda.Checked)
					{
						string halfwholesplenda1 = "One regular dark coffee with whole and splenda on its way!";
						MessageBox.Show(halfwholesplenda1);
						this.Close();
					}
					else
					{
						MessageBox.Show(w);
						this.Close();
					}
				}

				else if (Splenda.Checked)
				{
					string s = "One regular dark coffee with splenda on its way!";
					MessageBox.Show(s);
					this.Close();
				}

				else
				{
					string blonde = "One regular dark coffee on its way";
					MessageBox.Show(blonde);
					this.Close();
				}

			}

			else if (Dark2.Checked)
			{
				if (Sugar.Checked)
				{
					if (Half.Checked)
					{
						string halfs = "One decaf dark coffee with sugar and half and half on its way!";

						if (Whole.Checked)
						{
							string halfwhole = "One decaf dark coffee with sugar, half and half, and whole milk on its way!";


							if (Splenda.Checked)
							{
								string halfwholesplenda = "One decaf dark coffee with sugar, half and half, whole milk, and splenda on its way!";
								MessageBox.Show(halfwholesplenda);
								this.Close();
							}
							else
							{
								MessageBox.Show(halfwhole);
								this.Close();
							}
						}

						else if (Splenda.Checked)
						{
							string sugarhalfsplenda = "One decaf dark coffee with sugar, half and half, and splenda on its way!";
							MessageBox.Show(sugarhalfsplenda);
							this.Close();
						}
						else
						{
							MessageBox.Show(halfs);
							this.Close();
						}
					}

					else if (Whole.Checked)
					{
						string a = "One decaf dark coffee with sugar and whole milk on its way!";

						if (Splenda.Checked)
						{
							string b = "One decaf dark coffee with sugar, whole milk, and splenda on its way!";
							MessageBox.Show(b);
							this.Close();
						}
						else
						{
							MessageBox.Show(a);
							this.Close();
						}
					}

					else if (Splenda.Checked)
					{
						string c = "One decaf dark coffee with sugar and splenda on its way!";
						MessageBox.Show(c);
						this.Close();
					}

					else
					{
						MessageBox.Show("One decaf dark coffee with sugar on its way");
						this.Close();
					}
				}

				else if (Half.Checked)
				{
					if (Whole.Checked)
					{
						string halfwhole1 = "One decaf dark coffee with half and half and whole milk on its way!";

						if (Splenda.Checked)
						{
							string halfwholesplenda1 = "One decaf dark coffee with half and half, whole milk, and splenda on its way!";
							MessageBox.Show(halfwholesplenda1);
							this.Close();
						}
						else
						{
							MessageBox.Show(halfwhole1);
							this.Close();
						}
					}
					else if (Splenda.Checked)
					{
						string halfwholesplenda = "One decaf dark coffee with half and half and splenda on its way!";
						MessageBox.Show(halfwholesplenda);
						this.Close();
					}
					else
					{
						string h = "One decaf dark coffee with half and half on its way!";
						MessageBox.Show(h);
					}

				}

				else if (Whole.Checked)
				{
					string w = "One decaf dark coffee with whole milk on its way!";

					if (Splenda.Checked)
					{
						string halfwholesplenda1 = "One decaf dark coffee with whole and splenda on its way!";
						MessageBox.Show(halfwholesplenda1);
						this.Close();
					}
					else
					{
						MessageBox.Show(w);
						this.Close();
					}
				}

				else if (Splenda.Checked)
				{
					string s = "One decaf dark coffee with splenda on its way!";
					MessageBox.Show(s);
					this.Close();
				}

				else
				{
					string blonde = "One decaf dark coffee on its way";
					MessageBox.Show(blonde);
					this.Close();
				}

			}

			else
			{
				MessageBox.Show("Error: No coffee type selected");
			}
		}


		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			foreach (Control c in groupBox1.Controls)
			{
				if (c is RadioButton)
				{
					((RadioButton)c).Checked = false;
				}
			}

			foreach (Control c in groupBox3.Controls)
			{
				if (c is CheckBox)
				{
					((CheckBox)c).Checked = false;
				}
			}
		}
	}
}
