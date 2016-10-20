namespace DrinkDispenser
{
	partial class DrinkForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Coffee = new System.Windows.Forms.Button();
			this.Sports = new System.Windows.Forms.Button();
			this.Energy = new System.Windows.Forms.Button();
			this.Soda = new System.Windows.Forms.Button();
			this.WelcomeText = new System.Windows.Forms.Label();
			this.Start = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Coffee
			// 
			this.Coffee.Location = new System.Drawing.Point(23, 222);
			this.Coffee.Name = "Coffee";
			this.Coffee.Size = new System.Drawing.Size(116, 35);
			this.Coffee.TabIndex = 0;
			this.Coffee.Text = "Coffee";
			this.Coffee.UseVisualStyleBackColor = true;
			this.Coffee.Click += new System.EventHandler(this.Coffee_Click);
			// 
			// Sports
			// 
			this.Sports.Location = new System.Drawing.Point(197, 222);
			this.Sports.Name = "Sports";
			this.Sports.Size = new System.Drawing.Size(116, 35);
			this.Sports.TabIndex = 1;
			this.Sports.Text = "Sports Drink";
			this.Sports.UseVisualStyleBackColor = true;
			this.Sports.Click += new System.EventHandler(this.button2_Click);
			// 
			// Energy
			// 
			this.Energy.Location = new System.Drawing.Point(371, 222);
			this.Energy.Name = "Energy";
			this.Energy.Size = new System.Drawing.Size(116, 35);
			this.Energy.TabIndex = 2;
			this.Energy.Text = "Energy Drink";
			this.Energy.UseVisualStyleBackColor = true;
			this.Energy.Click += new System.EventHandler(this.Energy_Click);
			// 
			// Soda
			// 
			this.Soda.Location = new System.Drawing.Point(539, 222);
			this.Soda.Name = "Soda";
			this.Soda.Size = new System.Drawing.Size(116, 35);
			this.Soda.TabIndex = 3;
			this.Soda.Text = "Soda";
			this.Soda.UseVisualStyleBackColor = true;
			this.Soda.Click += new System.EventHandler(this.Soda_Click);
			// 
			// WelcomeText
			// 
			this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WelcomeText.Location = new System.Drawing.Point(49, 75);
			this.WelcomeText.Name = "WelcomeText";
			this.WelcomeText.Size = new System.Drawing.Size(596, 72);
			this.WelcomeText.TabIndex = 4;
			this.WelcomeText.Text = "Welcome, please select the drink category of your choice";
			// 
			// Start
			// 
			this.Start.Location = new System.Drawing.Point(137, 323);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(116, 43);
			this.Start.TabIndex = 5;
			this.Start.Text = "Start";
			this.Start.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(426, 323);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 43);
			this.button3.TabIndex = 6;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// DrinkForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 396);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Start);
			this.Controls.Add(this.WelcomeText);
			this.Controls.Add(this.Soda);
			this.Controls.Add(this.Energy);
			this.Controls.Add(this.Sports);
			this.Controls.Add(this.Coffee);
			this.Name = "DrinkForm";
			this.Text = "Drink Dispenser";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Coffee;
		private System.Windows.Forms.Button Sports;
		private System.Windows.Forms.Button Energy;
		private System.Windows.Forms.Button Soda;
		private System.Windows.Forms.Label WelcomeText;
		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.Button button3;
	}
}

