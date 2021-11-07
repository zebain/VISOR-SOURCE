namespace injector
{
	// Token: 0x02000007 RID: 7
	public partial class Visor : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000666C File Offset: 0x0000486C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000066A4 File Offset: 0x000048A4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::injector.Visor));
			this.button1 = new global::System.Windows.Forms.Button();
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.bunifuElipse3 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.bunifuElipse4 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.label2 = new global::System.Windows.Forms.Label();
			this.subscription = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.expiry = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.key = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.bunifuElipse5 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.bunifuElipse6 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.button4 = new global::System.Windows.Forms.Button();
			this.bunifuElipse7 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.button5 = new global::System.Windows.Forms.Button();
			this.bunifuElipse8 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Norecoil = new global::System.Windows.Forms.TextBox();
			this.Status = new global::System.Windows.Forms.Label();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.button7 = new global::System.Windows.Forms.Button();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.radioButton6 = new global::System.Windows.Forms.RadioButton();
			this.radioButton5 = new global::System.Windows.Forms.RadioButton();
			this.radioButton4 = new global::System.Windows.Forms.RadioButton();
			this.radioButton2 = new global::System.Windows.Forms.RadioButton();
			this.radioButton1 = new global::System.Windows.Forms.RadioButton();
			this.radioButton3 = new global::System.Windows.Forms.RadioButton();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.folderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.bunifuElipse9 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox6.SuspendLayout();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.White;
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.Black;
			this.button1.Location = new global::System.Drawing.Point(11, 19);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(68, 29);
			this.button1.TabIndex = 0;
			this.button1.Text = "Inject";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.bunifuElipse1.ElipseRadius = 2;
			this.bunifuElipse1.TargetControl = this.button1;
			this.bunifuElipse2.ElipseRadius = 2;
			this.bunifuElipse2.TargetControl = this;
			this.textBox1.BackColor = global::System.Drawing.Color.DimGray;
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(5, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(366, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.button2.BackColor = global::System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.Black;
			this.button2.Location = new global::System.Drawing.Point(377, 12);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(127, 26);
			this.button2.TabIndex = 2;
			this.button2.Text = "Set Game Directory";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.bunifuElipse3.ElipseRadius = 2;
			this.bunifuElipse3.TargetControl = this.button2;
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 1000;
			numericUpDown.Increment = new decimal(array);
			this.numericUpDown1.Location = new global::System.Drawing.Point(3, 16);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 60000;
			numericUpDown2.Maximum = new decimal(array2);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 1000;
			numericUpDown3.Minimum = new decimal(array3);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(63, 21);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.ThousandsSeparator = true;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDown1;
			int[] array4 = new int[4];
			array4[0] = 15000;
			numericUpDown4.Value = new decimal(array4);
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.bunifuElipse4.ElipseRadius = 2;
			this.bunifuElipse4.TargetControl = this.textBox1;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(6, 25);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(177, 45);
			this.label2.TabIndex = 6;
			this.label2.Text = "Warning! Press Play Game and\r\nwait till launcher has closed \r\nthen Inject";
			this.label2.Visible = false;
			this.subscription.BackColor = global::System.Drawing.Color.Transparent;
			this.subscription.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.subscription.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.subscription.Location = new global::System.Drawing.Point(5, 71);
			this.subscription.Margin = new global::System.Windows.Forms.Padding(2);
			this.subscription.Name = "subscription";
			this.subscription.Size = new global::System.Drawing.Size(100, 17);
			this.subscription.TabIndex = 42;
			this.subscription.Text = "subscriptionLabel";
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.expiry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.expiry.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.expiry.Location = new global::System.Drawing.Point(5, 19);
			this.expiry.Margin = new global::System.Windows.Forms.Padding(2);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(66, 17);
			this.expiry.TabIndex = 41;
			this.expiry.Text = "expiryLabel";
			this.expiry.Click += new global::System.EventHandler(this.expiry_Click);
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.key.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.key.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.key.Location = new global::System.Drawing.Point(5, 46);
			this.key.Margin = new global::System.Windows.Forms.Padding(2);
			this.key.Name = "key";
			this.key.Size = new global::System.Drawing.Size(90, 17);
			this.key.TabIndex = 40;
			this.key.Text = "usernameLabel";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(161, 81);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(80, 13);
			this.label3.TabIndex = 43;
			this.label3.Text = "Visor Version: ?";
			this.bunifuElipse5.ElipseRadius = 2;
			this.bunifuElipse5.TargetControl = this.textBox2;
			this.textBox2.BackColor = global::System.Drawing.Color.Silver;
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox2.ForeColor = global::System.Drawing.Color.FromArgb(55, 55, 55);
			this.textBox2.Location = new global::System.Drawing.Point(145, 19);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new global::System.Drawing.Size(140, 17);
			this.textBox2.TabIndex = 49;
			this.textBox2.Visible = false;
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged_1);
			this.button3.BackColor = global::System.Drawing.Color.White;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.Black;
			this.button3.Location = new global::System.Drawing.Point(493, 1);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(25, 25);
			this.button3.TabIndex = 44;
			this.button3.Text = "X";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.bunifuElipse6.ElipseRadius = 2;
			this.bunifuElipse6.TargetControl = this.button3;
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			this.button4.BackColor = global::System.Drawing.Color.White;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.Color.Black;
			this.button4.Location = new global::System.Drawing.Point(72, 24);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(51, 25);
			this.button4.TabIndex = 45;
			this.button4.Text = "Help";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.bunifuElipse7.ElipseRadius = 2;
			this.bunifuElipse7.TargetControl = this.button4;
			this.button5.BackColor = global::System.Drawing.Color.White;
			this.button5.Enabled = false;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button5.ForeColor = global::System.Drawing.Color.Black;
			this.button5.Location = new global::System.Drawing.Point(54, 58);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(86, 25);
			this.button5.TabIndex = 48;
			this.button5.Text = "Clear Log's";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.bunifuElipse8.ElipseRadius = 2;
			this.bunifuElipse8.TargetControl = this.button5;
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox1.ForeColor = global::System.Drawing.Color.White;
			this.groupBox1.Location = new global::System.Drawing.Point(8, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(510, 49);
			this.groupBox1.TabIndex = 50;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Game Directory";
			this.groupBox1.Enter += new global::System.EventHandler(this.groupBox1_Enter);
			this.groupBox2.Controls.Add(this.Norecoil);
			this.groupBox2.Controls.Add(this.Status);
			this.groupBox2.Controls.Add(this.subscription);
			this.groupBox2.Controls.Add(this.key);
			this.groupBox2.Controls.Add(this.expiry);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox2.ForeColor = global::System.Drawing.Color.White;
			this.groupBox2.Location = new global::System.Drawing.Point(8, 170);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(300, 97);
			this.groupBox2.TabIndex = 51;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lisence Infomation";
			this.Norecoil.BackColor = global::System.Drawing.Color.Silver;
			this.Norecoil.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Norecoil.ForeColor = global::System.Drawing.Color.FromArgb(55, 55, 55);
			this.Norecoil.Location = new global::System.Drawing.Point(145, 42);
			this.Norecoil.Multiline = true;
			this.Norecoil.Name = "Norecoil";
			this.Norecoil.ReadOnly = true;
			this.Norecoil.Size = new global::System.Drawing.Size(140, 11);
			this.Norecoil.TabIndex = 51;
			this.Norecoil.Visible = false;
			this.Status.AutoSize = true;
			this.Status.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Status.ForeColor = global::System.Drawing.Color.White;
			this.Status.Location = new global::System.Drawing.Point(161, 60);
			this.Status.Name = "Status";
			this.Status.Size = new global::System.Drawing.Size(101, 13);
			this.Status.TabIndex = 50;
			this.Status.Text = "Status: Not Injected";
			this.groupBox4.Controls.Add(this.button4);
			this.groupBox4.Controls.Add(this.button5);
			this.groupBox4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox4.ForeColor = global::System.Drawing.Color.White;
			this.groupBox4.Location = new global::System.Drawing.Point(317, 170);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(201, 97);
			this.groupBox4.TabIndex = 53;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Options";
			this.groupBox5.Controls.Add(this.button7);
			this.groupBox5.Controls.Add(this.groupBox7);
			this.groupBox5.Controls.Add(this.groupBox3);
			this.groupBox5.Controls.Add(this.button1);
			this.groupBox5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox5.ForeColor = global::System.Drawing.Color.White;
			this.groupBox5.Location = new global::System.Drawing.Point(214, 75);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(304, 98);
			this.groupBox5.TabIndex = 54;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Inject";
			this.groupBox5.Enter += new global::System.EventHandler(this.groupBox5_Enter);
			this.button7.BackColor = global::System.Drawing.Color.FromArgb(0, 255, 36);
			this.button7.Enabled = false;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button7.ForeColor = global::System.Drawing.Color.Black;
			this.button7.Location = new global::System.Drawing.Point(83, 41);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(84, 29);
			this.button7.TabIndex = 58;
			this.button7.Text = "NoRecoil";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.groupBox7.Controls.Add(this.panel1);
			this.groupBox7.ForeColor = global::System.Drawing.Color.White;
			this.groupBox7.Location = new global::System.Drawing.Point(169, 7);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(129, 84);
			this.groupBox7.TabIndex = 57;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Type";
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.radioButton6);
			this.panel1.Controls.Add(this.radioButton5);
			this.panel1.Controls.Add(this.radioButton4);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.radioButton3);
			this.panel1.Location = new global::System.Drawing.Point(6, 17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(121, 58);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.radioButton6.AutoSize = true;
			this.radioButton6.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButton6.Enabled = false;
			this.radioButton6.Location = new global::System.Drawing.Point(3, 113);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new global::System.Drawing.Size(98, 19);
			this.radioButton6.TabIndex = 56;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Green/Purple";
			this.radioButton6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton6.UseVisualStyleBackColor = false;
			this.radioButton6.CheckedChanged += new global::System.EventHandler(this.radioButton6_CheckedChanged);
			this.radioButton5.AutoSize = true;
			this.radioButton5.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButton5.Enabled = false;
			this.radioButton5.Location = new global::System.Drawing.Point(3, 93);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new global::System.Drawing.Size(86, 19);
			this.radioButton5.TabIndex = 54;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Red/X-RAY";
			this.radioButton5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton5.UseVisualStyleBackColor = false;
			this.radioButton5.CheckedChanged += new global::System.EventHandler(this.radioButton5_CheckedChanged_1);
			this.radioButton4.AutoSize = true;
			this.radioButton4.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButton4.Enabled = false;
			this.radioButton4.Location = new global::System.Drawing.Point(3, 72);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new global::System.Drawing.Size(85, 19);
			this.radioButton4.TabIndex = 53;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Green/Red";
			this.radioButton4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton4.UseVisualStyleBackColor = false;
			this.radioButton4.CheckedChanged += new global::System.EventHandler(this.radioButton4_CheckedChanged);
			this.radioButton2.AutoSize = true;
			this.radioButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButton2.Enabled = false;
			this.radioButton2.Location = new global::System.Drawing.Point(3, 5);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new global::System.Drawing.Size(77, 19);
			this.radioButton2.TabIndex = 51;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Blue/Pink";
			this.radioButton2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton2.UseVisualStyleBackColor = false;
			this.radioButton2.CheckedChanged += new global::System.EventHandler(this.radioButton2_CheckedChanged);
			this.radioButton1.AutoSize = true;
			this.radioButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButton1.Enabled = false;
			this.radioButton1.Location = new global::System.Drawing.Point(3, 49);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new global::System.Drawing.Size(60, 19);
			this.radioButton1.TabIndex = 50;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "X-RAY";
			this.radioButton1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton1.UseVisualStyleBackColor = false;
			this.radioButton1.CheckedChanged += new global::System.EventHandler(this.radioButton1_CheckedChanged);
			this.radioButton3.AutoSize = true;
			this.radioButton3.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButton3.Enabled = false;
			this.radioButton3.Location = new global::System.Drawing.Point(3, 28);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new global::System.Drawing.Size(65, 19);
			this.radioButton3.TabIndex = 52;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Testing";
			this.radioButton3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton3.UseVisualStyleBackColor = false;
			this.radioButton3.CheckedChanged += new global::System.EventHandler(this.radioButton3_CheckedChanged);
			this.groupBox3.Controls.Add(this.numericUpDown1);
			this.groupBox3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox3.ForeColor = global::System.Drawing.Color.White;
			this.groupBox3.Location = new global::System.Drawing.Point(10, 49);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(69, 43);
			this.groupBox3.TabIndex = 56;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Delay ";
			this.groupBox6.Controls.Add(this.label2);
			this.groupBox6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox6.ForeColor = global::System.Drawing.Color.White;
			this.groupBox6.Location = new global::System.Drawing.Point(8, 75);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(200, 98);
			this.groupBox6.TabIndex = 55;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Infomation";
			this.timer1.Enabled = true;
			this.timer1.Interval = 200;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick_1);
			this.bunifuElipse9.ElipseRadius = 2;
			this.bunifuElipse9.TargetControl = this.button7;
			this.openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(519, 271);
			base.Controls.Add(this.groupBox6);
			base.Controls.Add(this.groupBox5);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.button3);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Visor";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Visor";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000038 RID: 56
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400003A RID: 58
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x0400003B RID: 59
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse2;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400003E RID: 62
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse3;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x04000040 RID: 64
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse4;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000042 RID: 66
		private global::Siticone.UI.WinForms.SiticoneLabel subscription;

		// Token: 0x04000043 RID: 67
		private global::Siticone.UI.WinForms.SiticoneLabel expiry;

		// Token: 0x04000044 RID: 68
		private global::Siticone.UI.WinForms.SiticoneLabel key;

		// Token: 0x04000045 RID: 69
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse5;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000047 RID: 71
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse6;

		// Token: 0x04000048 RID: 72
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400004B RID: 75
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse7;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400004E RID: 78
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse8;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Label Status;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.RadioButton radioButton3;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.RadioButton radioButton4;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.RadioButton radioButton5;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000060 RID: 96
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse9;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.TextBox Norecoil;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.RadioButton radioButton6;
	}
}
