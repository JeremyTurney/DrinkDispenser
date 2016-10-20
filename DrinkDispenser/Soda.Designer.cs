namespace DrinkDispenser
{
	partial class Soda
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
			this.SodaBox = new System.Windows.Forms.GroupBox();
			this.Mug = new System.Windows.Forms.RadioButton();
			this.Sprite = new System.Windows.Forms.RadioButton();
			this.Coke = new System.Windows.Forms.RadioButton();
			this.Dr = new System.Windows.Forms.RadioButton();
			this.Mtn = new System.Windows.Forms.RadioButton();
			this.Pepsi = new System.Windows.Forms.RadioButton();
			this.Finish = new System.Windows.Forms.Button();
			this.Reset = new System.Windows.Forms.Button();
			this.Back = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SodaBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(411, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 304);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please pick from the following soda drink choices. When you are finished click fi" +
    "nish to process order. To reset your order click reset. To go back to start scre" +
    "en click back.";
			// 
			// SodaBox
			// 
			this.SodaBox.Controls.Add(this.Mug);
			this.SodaBox.Controls.Add(this.Sprite);
			this.SodaBox.Controls.Add(this.Coke);
			this.SodaBox.Controls.Add(this.Dr);
			this.SodaBox.Controls.Add(this.Mtn);
			this.SodaBox.Controls.Add(this.Pepsi);
			this.SodaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SodaBox.Location = new System.Drawing.Point(35, 461);
			this.SodaBox.Name = "SodaBox";
			this.SodaBox.Size = new System.Drawing.Size(564, 165);
			this.SodaBox.TabIndex = 2;
			this.SodaBox.TabStop = false;
			this.SodaBox.Text = "Soda";
			// 
			// Mug
			// 
			this.Mug.AutoSize = true;
			this.Mug.Location = new System.Drawing.Point(369, 116);
			this.Mug.Name = "Mug";
			this.Mug.Size = new System.Drawing.Size(155, 24);
			this.Mug.TabIndex = 5;
			this.Mug.TabStop = true;
			this.Mug.Text = "Mug Root Beer";
			this.Mug.UseVisualStyleBackColor = true;
			// 
			// Sprite
			// 
			this.Sprite.AutoSize = true;
			this.Sprite.Location = new System.Drawing.Point(200, 116);
			this.Sprite.Name = "Sprite";
			this.Sprite.Size = new System.Drawing.Size(82, 24);
			this.Sprite.TabIndex = 4;
			this.Sprite.TabStop = true;
			this.Sprite.Text = "Sprite";
			this.Sprite.UseVisualStyleBackColor = true;
			// 
			// Coke
			// 
			this.Coke.AutoSize = true;
			this.Coke.Location = new System.Drawing.Point(45, 115);
			this.Coke.Name = "Coke";
			this.Coke.Size = new System.Drawing.Size(75, 24);
			this.Coke.TabIndex = 3;
			this.Coke.TabStop = true;
			this.Coke.Text = "Coke";
			this.Coke.UseVisualStyleBackColor = true;
			// 
			// Dr
			// 
			this.Dr.AutoSize = true;
			this.Dr.Location = new System.Drawing.Point(369, 55);
			this.Dr.Name = "Dr";
			this.Dr.Size = new System.Drawing.Size(120, 24);
			this.Dr.TabIndex = 2;
			this.Dr.TabStop = true;
			this.Dr.Text = "Dr. Pepper";
			this.Dr.UseVisualStyleBackColor = true;
			// 
			// Mtn
			// 
			this.Mtn.AutoSize = true;
			this.Mtn.Location = new System.Drawing.Point(200, 55);
			this.Mtn.Name = "Mtn";
			this.Mtn.Size = new System.Drawing.Size(104, 24);
			this.Mtn.TabIndex = 1;
			this.Mtn.TabStop = true;
			this.Mtn.Text = "Mtn Dew";
			this.Mtn.UseVisualStyleBackColor = true;
			// 
			// Pepsi
			// 
			this.Pepsi.AutoSize = true;
			this.Pepsi.Location = new System.Drawing.Point(45, 55);
			this.Pepsi.Name = "Pepsi";
			this.Pepsi.Size = new System.Drawing.Size(78, 24);
			this.Pepsi.TabIndex = 0;
			this.Pepsi.TabStop = true;
			this.Pepsi.Text = "Pepsi";
			this.Pepsi.UseVisualStyleBackColor = true;
			// 
			// Finish
			// 
			this.Finish.Location = new System.Drawing.Point(63, 694);
			this.Finish.Name = "Finish";
			this.Finish.Size = new System.Drawing.Size(103, 36);
			this.Finish.TabIndex = 3;
			this.Finish.Text = "Finish";
			this.Finish.UseVisualStyleBackColor = true;
			this.Finish.Click += new System.EventHandler(this.Finish_Click);
			// 
			// Reset
			// 
			this.Reset.Location = new System.Drawing.Point(270, 694);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(103, 36);
			this.Reset.TabIndex = 4;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// Back
			// 
			this.Back.Location = new System.Drawing.Point(496, 694);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(103, 36);
			this.Back.TabIndex = 5;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Exit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DrinkDispenser.Properties.Resources.soda1;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(361, 393);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// Soda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 786);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.Reset);
			this.Controls.Add(this.Finish);
			this.Controls.Add(this.SodaBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "Soda";
			this.Text = "Soda";
			this.SodaBox.ResumeLayout(false);
			this.SodaBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox SodaBox;
		private System.Windows.Forms.RadioButton Mug;
		private System.Windows.Forms.RadioButton Sprite;
		private System.Windows.Forms.RadioButton Coke;
		private System.Windows.Forms.RadioButton Dr;
		private System.Windows.Forms.RadioButton Mtn;
		private System.Windows.Forms.RadioButton Pepsi;
		private System.Windows.Forms.Button Finish;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button Back;
	}
}