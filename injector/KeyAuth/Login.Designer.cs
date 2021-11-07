namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002A RID: 42 RVA: 0x0000372C File Offset: 0x0000192C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003768 File Offset: 0x00001968
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Login));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LoginBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.key = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.username = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.password = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.RgstrBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.UpgradeBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.LicBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneLabel1 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel2 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneLabel3 = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.FORBADPEOPLE = new global::System.Windows.Forms.Timer(this.components);
			this.FORLOWKEYCHAMS = new global::System.Windows.Forms.Timer(this.components);
			this.LOWKEYPRITTYASSNGL = new global::System.Windows.Forms.Timer(this.components);
			this.LowkeyKindaDog = new global::System.Windows.Forms.Timer(this.components);
			this.QWQW = new global::System.Windows.Forms.Timer(this.components);
			this.bum = new global::System.Windows.Forms.Timer(this.components);
			this.lowkey = new global::System.Windows.Forms.Timer(this.components);
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.BorderColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, 0);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(668, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.PressedColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.BorderColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = 0;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, 0);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.siticoneControlBox2.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(637, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.PressedColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = 1;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, 0);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.LoginBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.BorderThickness = 1;
			this.LoginBtn.CheckedState.Parent = this.LoginBtn;
			this.LoginBtn.CustomImages.Parent = this.LoginBtn;
			this.siticoneTransition1.SetDecoration(this.LoginBtn, 0);
			this.LoginBtn.FillColor = global::System.Drawing.Color.FromArgb(65, 253, 7);
			this.LoginBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.Black;
			this.LoginBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.LoginBtn.HoveredState.Parent = this.LoginBtn;
			this.LoginBtn.Location = new global::System.Drawing.Point(369, 305);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.PressedColor = global::System.Drawing.Color.Gray;
			this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
			this.LoginBtn.Size = new global::System.Drawing.Size(151, 27);
			this.LoginBtn.TabIndex = 26;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.Click += new global::System.EventHandler(this.LoginBtn_Click);
			this.key.AllowDrop = true;
			this.key.BorderColor = global::System.Drawing.Color.Transparent;
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.key, 0);
			this.key.DefaultText = "";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.Parent = this.key;
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FillColor = global::System.Drawing.Color.FromArgb(65, 253, 7);
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.Gray;
			this.key.FocusedState.Parent = this.key;
			this.key.ForeColor = global::System.Drawing.Color.Black;
			this.key.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.key.HoveredState.Parent = this.key;
			this.key.Location = new global::System.Drawing.Point(408, 237);
			this.key.Margin = new global::System.Windows.Forms.Padding(4);
			this.key.Name = "key";
			this.key.PasswordChar = '\0';
			this.key.PlaceholderForeColor = global::System.Drawing.Color.White;
			this.key.PlaceholderText = "";
			this.key.SelectedText = "";
			this.key.ShadowDecoration.Parent = this.key;
			this.key.Size = new global::System.Drawing.Size(236, 30);
			this.key.TabIndex = 32;
			this.key.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.key.TextChanged += new global::System.EventHandler(this.key_TextChanged);
			this.username.AllowDrop = true;
			this.username.BorderColor = global::System.Drawing.Color.Transparent;
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.username, 0);
			this.username.DefaultText = "";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.Parent = this.username;
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.FromArgb(65, 253, 7);
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.Gray;
			this.username.FocusedState.Parent = this.username;
			this.username.ForeColor = global::System.Drawing.Color.Black;
			this.username.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.username.HoveredState.Parent = this.username;
			this.username.Location = new global::System.Drawing.Point(408, 89);
			this.username.Margin = new global::System.Windows.Forms.Padding(4);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderForeColor = global::System.Drawing.Color.White;
			this.username.PlaceholderText = "";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(236, 30);
			this.username.TabIndex = 33;
			this.username.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.username.TextChanged += new global::System.EventHandler(this.username_TextChanged);
			this.password.AllowDrop = true;
			this.password.BorderColor = global::System.Drawing.Color.Transparent;
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.password, 0);
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.FromArgb(65, 253, 7);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.Gray;
			this.password.FocusedState.Parent = this.password;
			this.password.ForeColor = global::System.Drawing.Color.Black;
			this.password.HoveredState.BorderColor = global::System.Drawing.Color.Gray;
			this.password.HoveredState.Parent = this.password;
			this.password.Location = new global::System.Drawing.Point(408, 163);
			this.password.Margin = new global::System.Windows.Forms.Padding(4);
			this.password.Name = "password";
			this.password.PasswordChar = '\0';
			this.password.PlaceholderForeColor = global::System.Drawing.Color.White;
			this.password.PlaceholderText = "";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(236, 30);
			this.password.TabIndex = 34;
			this.password.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.RgstrBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.RgstrBtn.BorderThickness = 1;
			this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
			this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
			this.siticoneTransition1.SetDecoration(this.RgstrBtn, 0);
			this.RgstrBtn.FillColor = global::System.Drawing.Color.FromArgb(65, 253, 7);
			this.RgstrBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RgstrBtn.ForeColor = global::System.Drawing.Color.Black;
			this.RgstrBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
			this.RgstrBtn.Location = new global::System.Drawing.Point(526, 305);
			this.RgstrBtn.Name = "RgstrBtn";
			this.RgstrBtn.PressedColor = global::System.Drawing.Color.Gray;
			this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
			this.RgstrBtn.Size = new global::System.Drawing.Size(153, 27);
			this.RgstrBtn.TabIndex = 35;
			this.RgstrBtn.Text = "Register";
			this.RgstrBtn.Click += new global::System.EventHandler(this.RgstrBtn_Click);
			this.UpgradeBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.UpgradeBtn.BorderThickness = 1;
			this.UpgradeBtn.CheckedState.Parent = this.UpgradeBtn;
			this.UpgradeBtn.CustomImages.Parent = this.UpgradeBtn;
			this.siticoneTransition1.SetDecoration(this.UpgradeBtn, 0);
			this.UpgradeBtn.FillColor = global::System.Drawing.Color.FromArgb(65, 253, 7);
			this.UpgradeBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.UpgradeBtn.ForeColor = global::System.Drawing.Color.Black;
			this.UpgradeBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.UpgradeBtn.HoveredState.Parent = this.UpgradeBtn;
			this.UpgradeBtn.Location = new global::System.Drawing.Point(449, 274);
			this.UpgradeBtn.Name = "UpgradeBtn";
			this.UpgradeBtn.PressedColor = global::System.Drawing.Color.Gray;
			this.UpgradeBtn.ShadowDecoration.Parent = this.UpgradeBtn;
			this.UpgradeBtn.Size = new global::System.Drawing.Size(151, 27);
			this.UpgradeBtn.TabIndex = 36;
			this.UpgradeBtn.Text = "Upgrade";
			this.UpgradeBtn.Click += new global::System.EventHandler(this.UpgradeBtn_Click);
			this.LicBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.LicBtn.BorderThickness = 1;
			this.LicBtn.CheckedState.Parent = this.LicBtn;
			this.LicBtn.CustomImages.Parent = this.LicBtn;
			this.siticoneTransition1.SetDecoration(this.LicBtn, 0);
			this.LicBtn.FillColor = global::System.Drawing.Color.FromArgb(65, 253, 7);
			this.LicBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LicBtn.ForeColor = global::System.Drawing.Color.Black;
			this.LicBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.LicBtn.HoveredState.Parent = this.LicBtn;
			this.LicBtn.Location = new global::System.Drawing.Point(-1, 337);
			this.LicBtn.Name = "LicBtn";
			this.LicBtn.PressedColor = global::System.Drawing.Color.Gray;
			this.LicBtn.ShadowDecoration.Parent = this.LicBtn;
			this.LicBtn.Size = new global::System.Drawing.Size(153, 27);
			this.LicBtn.TabIndex = 37;
			this.LicBtn.Text = "License";
			this.LicBtn.Visible = false;
			this.LicBtn.Click += new global::System.EventHandler(this.LicBtn_Click);
			this.siticoneLabel1.AutoSize = false;
			this.siticoneLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.siticoneLabel1, 0);
			this.siticoneLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneLabel1.Location = new global::System.Drawing.Point(483, 143);
			this.siticoneLabel1.Name = "siticoneLabel1";
			this.siticoneLabel1.Size = new global::System.Drawing.Size(81, 18);
			this.siticoneLabel1.TabIndex = 38;
			this.siticoneLabel1.Text = "|Password|";
			this.siticoneLabel2.AutoSize = false;
			this.siticoneLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.siticoneLabel2, 0);
			this.siticoneLabel2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneLabel2.Location = new global::System.Drawing.Point(505, 212);
			this.siticoneLabel2.Name = "siticoneLabel2";
			this.siticoneLabel2.Size = new global::System.Drawing.Size(44, 18);
			this.siticoneLabel2.TabIndex = 39;
			this.siticoneLabel2.Text = "|Key|";
			this.siticoneLabel3.AutoSize = false;
			this.siticoneLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.siticoneLabel3, 0);
			this.siticoneLabel3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneLabel3.ForeColor = global::System.Drawing.Color.White;
			this.siticoneLabel3.Location = new global::System.Drawing.Point(483, 64);
			this.siticoneLabel3.Name = "siticoneLabel3";
			this.siticoneLabel3.Size = new global::System.Drawing.Size(81, 18);
			this.siticoneLabel3.TabIndex = 40;
			this.siticoneLabel3.Text = "|Username|";
			this.siticoneTransition1.SetDecoration(this.pictureBox1, 0);
			this.pictureBox1.Image = global::injector.Properties.Resources.image0;
			this.pictureBox1.Location = new global::System.Drawing.Point(-1, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(355, 355);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 41;
			this.pictureBox1.TabStop = false;
			this.FORBADPEOPLE.Enabled = true;
			this.FORBADPEOPLE.Tick += new global::System.EventHandler(this.FORBADPEOPLE_Tick);
			this.FORLOWKEYCHAMS.Enabled = true;
			this.FORLOWKEYCHAMS.Tick += new global::System.EventHandler(this.FORLOWKEYCHAMS_Tick);
			this.LOWKEYPRITTYASSNGL.Enabled = true;
			this.LOWKEYPRITTYASSNGL.Tick += new global::System.EventHandler(this.LOWKEYPRITTYASSNGL_Tick);
			this.LowkeyKindaDog.Enabled = true;
			this.LowkeyKindaDog.Tick += new global::System.EventHandler(this.LowkeyKindaDog_Tick);
			this.QWQW.Enabled = true;
			this.QWQW.Tick += new global::System.EventHandler(this.QWQW_Tick);
			this.bum.Enabled = true;
			this.bum.Tick += new global::System.EventHandler(this.bum_Tick);
			this.lowkey.Enabled = true;
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.pictureBox1;
			this.bunifuDragControl1.Vertical = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(7, 4, 3);
			this.BackgroundImage = global::injector.Properties.Resources.stars_3750824_1280;
			base.ClientSize = new global::System.Drawing.Size(696, 355);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.siticoneLabel3);
			base.Controls.Add(this.siticoneLabel2);
			base.Controls.Add(this.siticoneLabel1);
			base.Controls.Add(this.LicBtn);
			base.Controls.Add(this.UpgradeBtn);
			base.Controls.Add(this.RgstrBtn);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.key);
			base.Controls.Add(this.LoginBtn);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, 1);
			this.ForeColor = global::System.Drawing.Color.Transparent;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000012 RID: 18
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000013 RID: 19
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000014 RID: 20
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000015 RID: 21
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000016 RID: 22
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000018 RID: 24
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;

		// Token: 0x04000019 RID: 25
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x0400001A RID: 26
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox key;

		// Token: 0x0400001B RID: 27
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox password;

		// Token: 0x0400001C RID: 28
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox username;

		// Token: 0x0400001D RID: 29
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LicBtn;

		// Token: 0x0400001E RID: 30
		private global::Siticone.UI.WinForms.SiticoneRoundedButton UpgradeBtn;

		// Token: 0x0400001F RID: 31
		private global::Siticone.UI.WinForms.SiticoneRoundedButton RgstrBtn;

		// Token: 0x04000020 RID: 32
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;

		// Token: 0x04000021 RID: 33
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;

		// Token: 0x04000022 RID: 34
		private global::Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Timer FORBADPEOPLE;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Timer FORLOWKEYCHAMS;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Timer LOWKEYPRITTYASSNGL;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Timer LowkeyKindaDog;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Timer QWQW;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Timer bum;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Timer lowkey;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400002B RID: 43
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
	}
}
