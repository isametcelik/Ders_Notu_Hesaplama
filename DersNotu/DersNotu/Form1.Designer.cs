namespace DersNotu
{
	partial class Form1
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonx = new System.Windows.Forms.Button();
			this.labelvize = new System.Windows.Forms.Label();
			this.labelödev = new System.Windows.Forms.Label();
			this.labelfinal = new System.Windows.Forms.Label();
			this.textBoxvize = new System.Windows.Forms.TextBox();
			this.textBoxödev = new System.Windows.Forms.TextBox();
			this.textBoxfinal = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.labelfinal);
			this.panel1.Controls.Add(this.labelödev);
			this.panel1.Controls.Add(this.labelvize);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 482);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DersNotu.Properties.Resources.toros_universitesi3007;
			this.pictureBox1.Location = new System.Drawing.Point(3, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(194, 143);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// buttonx
			// 
			this.buttonx.BackColor = System.Drawing.Color.Red;
			this.buttonx.ForeColor = System.Drawing.Color.White;
			this.buttonx.Location = new System.Drawing.Point(512, 1);
			this.buttonx.Name = "buttonx";
			this.buttonx.Size = new System.Drawing.Size(37, 23);
			this.buttonx.TabIndex = 1;
			this.buttonx.Text = "X";
			this.buttonx.UseVisualStyleBackColor = false;
			this.buttonx.Click += new System.EventHandler(this.buttonx_Click);
			// 
			// labelvize
			// 
			this.labelvize.AutoSize = true;
			this.labelvize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelvize.Location = new System.Drawing.Point(52, 194);
			this.labelvize.Name = "labelvize";
			this.labelvize.Size = new System.Drawing.Size(83, 32);
			this.labelvize.TabIndex = 1;
			this.labelvize.Text = "Vize:";
			// 
			// labelödev
			// 
			this.labelödev.AutoSize = true;
			this.labelödev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelödev.Location = new System.Drawing.Point(52, 254);
			this.labelödev.Name = "labelödev";
			this.labelödev.Size = new System.Drawing.Size(95, 32);
			this.labelödev.TabIndex = 2;
			this.labelödev.Text = "Ödev:";
			// 
			// labelfinal
			// 
			this.labelfinal.AutoSize = true;
			this.labelfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelfinal.Location = new System.Drawing.Point(52, 315);
			this.labelfinal.Name = "labelfinal";
			this.labelfinal.Size = new System.Drawing.Size(91, 32);
			this.labelfinal.TabIndex = 3;
			this.labelfinal.Text = "Final:";
			// 
			// textBoxvize
			// 
			this.textBoxvize.Location = new System.Drawing.Point(317, 195);
			this.textBoxvize.Name = "textBoxvize";
			this.textBoxvize.Size = new System.Drawing.Size(115, 22);
			this.textBoxvize.TabIndex = 2;
			// 
			// textBoxödev
			// 
			this.textBoxödev.Location = new System.Drawing.Point(317, 255);
			this.textBoxödev.Name = "textBoxödev";
			this.textBoxödev.Size = new System.Drawing.Size(115, 22);
			this.textBoxödev.TabIndex = 3;
			// 
			// textBoxfinal
			// 
			this.textBoxfinal.Location = new System.Drawing.Point(317, 316);
			this.textBoxfinal.Name = "textBoxfinal";
			this.textBoxfinal.Size = new System.Drawing.Size(115, 22);
			this.textBoxfinal.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(307, 364);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 37);
			this.button1.TabIndex = 5;
			this.button1.Text = "HESAPLA";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(243, 423);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 29);
			this.label4.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.Snow;
			this.label1.Location = new System.Drawing.Point(240, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 46);
			this.label1.TabIndex = 7;
			this.label1.Text = "DERS NOTU";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.Snow;
			this.label2.Location = new System.Drawing.Point(240, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(275, 46);
			this.label2.TabIndex = 8;
			this.label2.Text = "HESAPLAMA";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(552, 481);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxfinal);
			this.Controls.Add(this.textBoxödev);
			this.Controls.Add(this.textBoxvize);
			this.Controls.Add(this.buttonx);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonx;
		private System.Windows.Forms.Label labelfinal;
		private System.Windows.Forms.Label labelödev;
		private System.Windows.Forms.Label labelvize;
		private System.Windows.Forms.TextBox textBoxvize;
		private System.Windows.Forms.TextBox textBoxödev;
		private System.Windows.Forms.TextBox textBoxfinal;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

