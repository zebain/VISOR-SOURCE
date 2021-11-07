namespace injector
{
	// Token: 0x02000008 RID: 8
	public partial class Help : global::System.Windows.Forms.Form
	{
		// Token: 0x06000062 RID: 98 RVA: 0x000084B8 File Offset: 0x000066B8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000084F0 File Offset: 0x000066F0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::injector.Help));
			this.bunifuElipse3 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticonePictureBox5 = new global::Siticone.UI.WinForms.SiticonePictureBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.siticonePictureBox4 = new global::Siticone.UI.WinForms.SiticonePictureBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.siticonePictureBox3 = new global::Siticone.UI.WinForms.SiticonePictureBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.siticonePictureBox2 = new global::Siticone.UI.WinForms.SiticonePictureBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.siticonePictureBox1 = new global::Siticone.UI.WinForms.SiticonePictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.button3 = new global::System.Windows.Forms.Button();
			this.bunifuElipse2 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel1.SuspendLayout();
			this.siticonePictureBox5.BeginInit();
			this.siticonePictureBox4.BeginInit();
			this.siticonePictureBox3.BeginInit();
			this.siticonePictureBox2.BeginInit();
			this.siticonePictureBox1.BeginInit();
			base.SuspendLayout();
			this.bunifuElipse3.ElipseRadius = 10;
			this.bunifuElipse3.TargetControl = this;
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			this.panel1.AutoScroll = true;
			this.panel1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.panel1.Controls.Add(this.siticonePictureBox5);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.siticonePictureBox4);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.siticonePictureBox3);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.siticonePictureBox2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.siticonePictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(0, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(571, 347);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.siticonePictureBox5.Image = global::injector.Properties.Resources.Capefefesfsefesesfsesefsefsefsefsefsefsefsefseture;
			this.siticonePictureBox5.Location = new global::System.Drawing.Point(6, 1108);
			this.siticonePictureBox5.Name = "siticonePictureBox5";
			this.siticonePictureBox5.ShadowDecoration.Parent = this.siticonePictureBox5;
			this.siticonePictureBox5.Size = new global::System.Drawing.Size(302, 185);
			this.siticonePictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.siticonePictureBox5.TabIndex = 15;
			this.siticonePictureBox5.TabStop = false;
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(-3, 1079);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(529, 26);
			this.label11.TabIndex = 14;
			this.label11.Text = "10. IMPORTANT - ensure you are verifying integrity of game files and clearing logs on every\r\n launch and closing of game.(Top right of BSG Loader or use the Clear Logs button)";
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.White;
			this.label10.Location = new global::System.Drawing.Point(3, 1040);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(340, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "9. Chams will be loaded and you are free to play the game!";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(3, 1301);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(517, 169);
			this.label9.TabIndex = 12;
			this.label9.Text = componentResourceManager.GetString("label9.Text");
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(3, 815);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(322, 26);
			this.label8.TabIndex = 11;
			this.label8.Text = "8. Wait until your game is fully loaded (you are in menu)\r\n then press ok on the pop-up VERY IMPORTANT";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(3, 764);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(395, 26);
			this.label7.TabIndex = 10;
			this.label7.Text = "7. If successful, you may hear a ding noise and get a pop-up saying \r\n\"Press ok once in game\"";
			this.siticonePictureBox4.Image = global::injector.Properties.Resources.Captccscscsccsure;
			this.siticonePictureBox4.Location = new global::System.Drawing.Point(0, 844);
			this.siticonePictureBox4.Name = "siticonePictureBox4";
			this.siticonePictureBox4.ShadowDecoration.Parent = this.siticonePictureBox4;
			this.siticonePictureBox4.Size = new global::System.Drawing.Size(308, 193);
			this.siticonePictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.siticonePictureBox4.TabIndex = 9;
			this.siticonePictureBox4.TabStop = false;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(3, 537);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(517, 32);
			this.label6.TabIndex = 8;
			this.label6.Text = "6. Click the \"Play Game\" button, and wait for the eft launcher to disappear, \r\nthen press inject on the chams loader.";
			this.siticonePictureBox3.Image = global::injector.Properties.Resources.Cawdwdwdwdwdwdwdwdwdwdwdwdwpture;
			this.siticonePictureBox3.Location = new global::System.Drawing.Point(6, 341);
			this.siticonePictureBox3.Name = "siticonePictureBox3";
			this.siticonePictureBox3.ShadowDecoration.Parent = this.siticonePictureBox3;
			this.siticonePictureBox3.Size = new global::System.Drawing.Size(308, 193);
			this.siticonePictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.siticonePictureBox3.TabIndex = 7;
			this.siticonePictureBox3.TabStop = false;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(3, 322);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(282, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "5. Open the Battlestate games launcher.";
			this.siticonePictureBox2.Image = global::injector.Properties.Resources.Capwwdwdwdwddture;
			this.siticonePictureBox2.Location = new global::System.Drawing.Point(6, 568);
			this.siticonePictureBox2.Name = "siticonePictureBox2";
			this.siticonePictureBox2.ShadowDecoration.Parent = this.siticonePictureBox2;
			this.siticonePictureBox2.Size = new global::System.Drawing.Size(308, 193);
			this.siticonePictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.siticonePictureBox2.TabIndex = 5;
			this.siticonePictureBox2.TabStop = false;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(3, 279);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(441, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "4. Set your game directory to where you downloaded the game.\r\n Example: C:\\Battlestate Games\\EFT";
			this.siticonePictureBox1.Image = global::injector.Properties.Resources.dedsfsdfdsfdsfdsfsdfdsfsffd;
			this.siticonePictureBox1.Location = new global::System.Drawing.Point(6, 83);
			this.siticonePictureBox1.Name = "siticonePictureBox1";
			this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
			this.siticonePictureBox1.Size = new global::System.Drawing.Size(308, 193);
			this.siticonePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.siticonePictureBox1.TabIndex = 3;
			this.siticonePictureBox1.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(3, 64);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(361, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "3. Reopen loader and login with user and password";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(180, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "2. Register with your key ";
			this.label1.AutoSize = true;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(185, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "1. Download the launcher ";
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this.panel1;
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(541, 4);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(25, 25);
			this.button3.TabIndex = 45;
			this.button3.Text = "X";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.bunifuElipse2.ElipseRadius = 10;
			this.bunifuElipse2.TargetControl = this.button3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(55, 55, 55);
			base.ClientSize = new global::System.Drawing.Size(571, 379);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Help";
			this.Text = "Help";
			base.Load += new global::System.EventHandler(this.Help_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.siticonePictureBox5.EndInit();
			this.siticonePictureBox4.EndInit();
			this.siticonePictureBox3.EndInit();
			this.siticonePictureBox2.EndInit();
			this.siticonePictureBox1.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000064 RID: 100
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000065 RID: 101
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse3;

		// Token: 0x04000066 RID: 102
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000069 RID: 105
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x0400006A RID: 106
		private global::Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400006E RID: 110
		private global::Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox2;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000070 RID: 112
		private global::Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox3;

		// Token: 0x04000071 RID: 113
		private global::Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox4;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000077 RID: 119
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse2;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400007A RID: 122
		private global::Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox5;
	}
}
