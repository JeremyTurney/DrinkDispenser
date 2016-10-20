namespace DrinkDispenser
{
	partial class Energy
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
			this.label1 = new System.Windows.Forms.Label();
			this.EnergyBox = new System.Windows.Forms.GroupBox();
			this.Full = new System.Windows.Forms.RadioButton();
			this.Nos = new System.Windows.Forms.RadioButton();
			this.Monster = new System.Windows.Forms.RadioButton();
			this.Rock = new System.Windows.Forms.RadioButton();
			this.Amp = new System.Windows.Forms.RadioButton();
			this.Red = new System.Windows.Forms.RadioButton();
			this.Finish = new System.Windows.Forms.Button();
			this.Reset = new System.Windows.Forms.Button();
			this.Back = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.EnergyBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(630, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(303, 283);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please pick from the following energy drink choices. When you are finished click " +
    "finish to process order. To reset your order click reset. To go back to start sc" +
    "reen click back.";
			// 
			// EnergyBox
			// 
			this.EnergyBox.Controls.Add(this.Full);
			this.EnergyBox.Controls.Add(this.Nos);
			this.EnergyBox.Controls.Add(this.Monster);
			this.EnergyBox.Controls.Add(this.Rock);
			this.EnergyBox.Controls.Add(this.Amp);
			this.EnergyBox.Controls.Add(this.Red);
			this.EnergyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EnergyBox.Location = new System.Drawing.Point(61, 485);
			this.EnergyBox.Name = "EnergyBox";
			this.EnergyBox.Size = new System.Drawing.Size(523, 232);
			this.EnergyBox.TabIndex = 2;
			this.EnergyBox.TabStop = false;
			this.EnergyBox.Text = "Energy Drinks";
			// 
			// Full
			// 
			this.Full.AutoSize = true;
			this.Full.Location = new System.Drawing.Point(322, 181);
			this.Full.Name = "Full";
			this.Full.Size = new System.Drawing.Size(130, 24);
			this.Full.TabIndex = 5;
			this.Full.TabStop = true;
			this.Full.Text = "Full Throttle";
			this.Full.UseVisualStyleBackColor = true;
			// 
			// Nos
			// 
			this.Nos.AutoSize = true;
			this.Nos.Location = new System.Drawing.Point(41, 181);
			this.Nos.Name = "Nos";
			this.Nos.Size = new System.Drawing.Size(71, 24);
			this.Nos.TabIndex = 4;
			this.Nos.TabStop = true;
			this.Nos.Text = "NOS";
			this.Nos.UseVisualStyleBackColor = true;
			// 
			// Monster
			// 
			this.Monster.AutoSize = true;
			this.Monster.Location = new System.Drawing.Point(322, 125);
			this.Monster.Name = "Monster";
			this.Monster.Size = new System.Drawing.Size(99, 24);
			this.Monster.TabIndex = 3;
			this.Monster.TabStop = true;
			this.Monster.Text = "Monster";
			this.Monster.UseVisualStyleBackColor = true;
			// 
			// Rock
			// 
			this.Rock.AutoSize = true;
			this.Rock.Location = new System.Drawing.Point(41, 125);
			this.Rock.Name = "Rock";
			this.Rock.Size = new System.Drawing.Size(109, 24);
			this.Rock.TabIndex = 2;
			this.Rock.TabStop = true;
			this.Rock.Text = "RockStar";
			this.Rock.UseVisualStyleBackColor = true;
			// 
			// Amp
			// 
			this.Amp.AutoSize = true;
			this.Amp.Location = new System.Drawing.Point(322, 59);
			this.Amp.Name = "Amp";
			this.Amp.Size = new System.Drawing.Size(70, 24);
			this.Amp.TabIndex = 1;
			this.Amp.TabStop = true;
			this.Amp.Text = "Amp";
			this.Amp.UseVisualStyleBackColor = true;
			// 
			// Red
			// 
			this.Red.AutoSize = true;
			this.Red.Location = new System.Drawing.Point(41, 59);
			this.Red.Name = "Red";
			this.Red.Size = new System.Drawing.Size(102, 24);
			this.Red.TabIndex = 0;
			this.Red.TabStop = true;
			this.Red.Text = "Red Bull";
			this.Red.UseVisualStyleBackColor = true;
			// 
			// Finish
			// 
			this.Finish.Location = new System.Drawing.Point(61, 803);
			this.Finish.Name = "Finish";
			this.Finish.Size = new System.Drawing.Size(114, 36);
			this.Finish.TabIndex = 3;
			this.Finish.Text = "Finish";
			this.Finish.UseVisualStyleBackColor = true;
			this.Finish.Click += new System.EventHandler(this.Finish_Click);
			// 
			// Reset
			// 
			this.Reset.Location = new System.Drawing.Point(368, 803);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(114, 36);
			this.Reset.TabIndex = 4;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// Back
			// 
			this.Back.Location = new System.Drawing.Point(668, 803);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(114, 36);
			this.Back.TabIndex = 5;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DrinkDispenser.Properties.Resources.energy_drinks;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(572, 429);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Energy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(942, 923);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.Reset);
			this.Controls.Add(this.Finish);
			this.Controls.Add(this.EnergyBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Energy";
			this.Text = "Energy";
			this.EnergyBox.ResumeLayout(false);
			this.EnergyBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox EnergyBox;
		private System.Windows.Forms.RadioButton Full;
		private System.Windows.Forms.RadioButton Nos;
		private System.Windows.Forms.RadioButton Monster;
		private System.Windows.Forms.RadioButton Rock;
		private System.Windows.Forms.RadioButton Amp;
		private System.Windows.Forms.RadioButton Red;
		private System.Windows.Forms.Button Finish;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button Back;
	}
}