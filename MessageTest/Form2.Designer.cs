﻿namespace MessageTest
{
	partial class Form2
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
			this.LblNumara = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LblAdSoyad = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numara :";
			// 
			// LblNumara
			// 
			this.LblNumara.AutoSize = true;
			this.LblNumara.Location = new System.Drawing.Point(118, 40);
			this.LblNumara.Name = "LblNumara";
			this.LblNumara.Size = new System.Drawing.Size(56, 25);
			this.LblNumara.TabIndex = 1;
			this.LblNumara.Text = "0000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(246, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ad Soyad :";
			// 
			// LblAdSoyad
			// 
			this.LblAdSoyad.AutoSize = true;
			this.LblAdSoyad.Location = new System.Drawing.Point(362, 40);
			this.LblAdSoyad.Name = "LblAdSoyad";
			this.LblAdSoyad.Size = new System.Drawing.Size(83, 25);
			this.LblAdSoyad.TabIndex = 3;
			this.LblAdSoyad.Text = "Null Null";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(633, 294);
			this.dataGridView1.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 88);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(639, 323);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gelen Kutusu";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Location = new System.Drawing.Point(654, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(639, 323);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Giden Kutusu";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 26);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(633, 294);
			this.dataGridView2.TabIndex = 4;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.maskedTextBox1);
			this.groupBox3.Controls.Add(this.richTextBox1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(15, 431);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1279, 292);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Mesaj Paneli";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(365, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "Mesaj :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Başlık :";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(138, 174);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 37);
			this.button1.TabIndex = 5;
			this.button1.Text = "Gönder";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(138, 121);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(203, 30);
			this.textBox1.TabIndex = 4;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(138, 68);
			this.maskedTextBox1.Mask = "0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(203, 30);
			this.maskedTextBox1.TabIndex = 3;
			this.maskedTextBox1.ValidatingType = typeof(int);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(447, 65);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(697, 194);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(73, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Alıcı :";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tomato;
			this.ClientSize = new System.Drawing.Size(1306, 735);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LblAdSoyad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LblNumara);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form2";
			this.Text = "Mesaj-Test";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblNumara;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LblAdSoyad;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
	}
}