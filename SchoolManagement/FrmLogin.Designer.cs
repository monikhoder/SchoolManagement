namespace SchoolManagement
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Panel();
            this.InvalidUserLbl = new System.Windows.Forms.Label();
            this.BtnClose = new KimTools.WinForms.KtButton();
            this.BtnLogin = new KimTools.WinForms.KtButton();
            this.PasswordTxb = new KimTools.WinForms.KtTextBox();
            this.UsernameTxb = new KimTools.WinForms.KtTextBox();
            this.ktTheme = new KimTools.WinForms.KtTheme(this.components);
            this.cmbRole = new KimTools.WinForms.KtComboBox();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.Controls.Add(this.pictureBox1);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(426, 191);
            this.top.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagement.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(134, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.cmbRole);
            this.Main.Controls.Add(this.InvalidUserLbl);
            this.Main.Controls.Add(this.BtnClose);
            this.Main.Controls.Add(this.BtnLogin);
            this.Main.Controls.Add(this.PasswordTxb);
            this.Main.Controls.Add(this.UsernameTxb);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 191);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(426, 383);
            this.Main.TabIndex = 1;
            // 
            // InvalidUserLbl
            // 
            this.InvalidUserLbl.AutoSize = true;
            this.InvalidUserLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidUserLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidUserLbl.Location = new System.Drawing.Point(36, 176);
            this.InvalidUserLbl.Name = "InvalidUserLbl";
            this.InvalidUserLbl.Size = new System.Drawing.Size(229, 21);
            this.InvalidUserLbl.TabIndex = 4;
            this.InvalidUserLbl.Text = "Incorect Username or Password";
            this.InvalidUserLbl.Visible = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Empty;
            this.BtnClose.Bg = KimTools.WinForms.KtColor.Tailwind_Red;
            this.BtnClose.BorderShape = KimTools.WinForms.KtSize.Default;
            this.BtnClose.BorderSize = KimTools.WinForms.KtSize.Default;
            this.BtnClose.CustomColors = new System.Drawing.Color[0];
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.IconName = "";
            this.BtnClose.IconSize = 16;
            this.BtnClose.IconStroke = 2.5D;
            this.BtnClose.LabelColor = KimTools.WinForms.KtColor.Tailwind_White;
            this.BtnClose.Location = new System.Drawing.Point(37, 279);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(167, 46);
            this.BtnClose.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "CLOSE";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Empty;
            this.BtnLogin.Bg = KimTools.WinForms.KtColor.Tailwind_Purple;
            this.BtnLogin.BorderShape = KimTools.WinForms.KtSize.Default;
            this.BtnLogin.BorderSize = KimTools.WinForms.KtSize.Default;
            this.BtnLogin.CustomColors = new System.Drawing.Color[0];
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogin.IconName = "";
            this.BtnLogin.IconSize = 16;
            this.BtnLogin.IconStroke = 2.5D;
            this.BtnLogin.LabelColor = KimTools.WinForms.KtColor.Tailwind_White;
            this.BtnLogin.Location = new System.Drawing.Point(223, 279);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(167, 46);
            this.BtnLogin.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PasswordTxb
            // 
            this.PasswordTxb.AcceptsReturn = false;
            this.PasswordTxb.AcceptsTab = false;
            this.PasswordTxb.AnimationSpeed = 200;
            this.PasswordTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTxb.AutoSizeHeight = true;
            this.PasswordTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.PasswordTxb.Bg = KimTools.WinForms.KtColor.BackColor;
            this.PasswordTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.PasswordTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.PasswordTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.PasswordTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.PasswordTxb.CustomIconLeft = null;
            this.PasswordTxb.CustomIconRight = null;
            this.PasswordTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.PasswordTxb.DefaultFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxb.ForeColor = System.Drawing.Color.Empty;
            this.PasswordTxb.HideSelection = true;
            this.PasswordTxb.IconRight = "Tabler.outline.key";
            this.PasswordTxb.Lines = new string[0];
            this.PasswordTxb.Location = new System.Drawing.Point(37, 113);
            this.PasswordTxb.MaxLength = 32767;
            this.PasswordTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordTxb.Modified = false;
            this.PasswordTxb.Name = "PasswordTxb";
            this.PasswordTxb.Password = true;
            this.PasswordTxb.PasswordChar = '\0';
            this.PasswordTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTxb.SelectedText = "";
            this.PasswordTxb.SelectionLength = 0;
            this.PasswordTxb.SelectionStart = 0;
            this.PasswordTxb.ShortcutsEnabled = true;
            this.PasswordTxb.Size = new System.Drawing.Size(353, 50);
            this.PasswordTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.PasswordTxb.TabIndex = 1;
            this.PasswordTxb.TextMarginBottom = 0;
            this.PasswordTxb.TextPlaceholder = "Password";
            this.PasswordTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTxb_KeyPress);
            this.PasswordTxb.TextChange += new System.EventHandler(this.PasswordTxb_TextChange);
            // 
            // UsernameTxb
            // 
            this.UsernameTxb.AcceptsReturn = false;
            this.UsernameTxb.AcceptsTab = false;
            this.UsernameTxb.AnimationSpeed = 200;
            this.UsernameTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UsernameTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UsernameTxb.AutoSizeHeight = true;
            this.UsernameTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.UsernameTxb.Bg = KimTools.WinForms.KtColor.BackColor;
            this.UsernameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.UsernameTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.UsernameTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.UsernameTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.UsernameTxb.CustomIconLeft = null;
            this.UsernameTxb.CustomIconRight = null;
            this.UsernameTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.UsernameTxb.DefaultFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxb.ForeColor = System.Drawing.Color.Empty;
            this.UsernameTxb.HideSelection = true;
            this.UsernameTxb.IconRight = "Tabler.outline.user";
            this.UsernameTxb.Lines = new string[0];
            this.UsernameTxb.Location = new System.Drawing.Point(37, 17);
            this.UsernameTxb.MaxLength = 32767;
            this.UsernameTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.UsernameTxb.Modified = false;
            this.UsernameTxb.Name = "UsernameTxb";
            this.UsernameTxb.Password = false;
            this.UsernameTxb.PasswordChar = '\0';
            this.UsernameTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTxb.SelectedText = "";
            this.UsernameTxb.SelectionLength = 0;
            this.UsernameTxb.SelectionStart = 0;
            this.UsernameTxb.ShortcutsEnabled = true;
            this.UsernameTxb.Size = new System.Drawing.Size(353, 50);
            this.UsernameTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.UsernameTxb.TabIndex = 0;
            this.UsernameTxb.TextMarginBottom = 0;
            this.UsernameTxb.TextPlaceholder = "Username";
            this.UsernameTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTxb_KeyPress);
            this.UsernameTxb.TextChange += new System.EventHandler(this.UsernameTxb_TextChange);
            // 
            // ktTheme
            // 
            this.ktTheme.Accent = System.Drawing.Color.Empty;
            this.ktTheme.Contrast = 10D;
            this.ktTheme.Dark = false;
            this.ktTheme.Primary = System.Drawing.Color.Empty;
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.Transparent;
            this.cmbRole.BackgroundColor = System.Drawing.Color.White;
            this.cmbRole.BorderColor = System.Drawing.Color.Silver;
            this.cmbRole.BorderRadius = 1;
            this.cmbRole.Color = System.Drawing.Color.Silver;
            this.cmbRole.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.cmbRole.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbRole.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbRole.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbRole.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbRole.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.cmbRole.FillDropDown = true;
            this.cmbRole.FillIndicator = false;
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbRole.ForeColor = System.Drawing.Color.Black;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Icon = null;
            this.cmbRole.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.cmbRole.IndicatorColor = System.Drawing.Color.Gray;
            this.cmbRole.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.cmbRole.ItemBackColor = System.Drawing.Color.White;
            this.cmbRole.ItemBorderColor = System.Drawing.Color.White;
            this.cmbRole.ItemForeColor = System.Drawing.Color.Black;
            this.cmbRole.ItemHeight = 26;
            this.cmbRole.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbRole.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbRole.ItemTopMargin = 3;
            this.cmbRole.Location = new System.Drawing.Point(37, 216);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(167, 32);
            this.cmbRole.TabIndex = 5;
            this.cmbRole.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.cmbRole.TextLeftMargin = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 574);
            this.ControlBox = false;
            this.Controls.Add(this.Main);
            this.Controls.Add(this.top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Opacity = 1D;
            this.Role = KimTools.WinForms.KtColor.Tailwind_White;
            this.Text = "Login";
            this.Theme = this.ktTheme;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Main;
        private KimTools.WinForms.KtTextBox UsernameTxb;
        public KimTools.WinForms.KtTheme ktTheme;
        private KimTools.WinForms.KtTextBox PasswordTxb;
        private KimTools.WinForms.KtButton BtnLogin;
        private KimTools.WinForms.KtButton BtnClose;
        private System.Windows.Forms.Label InvalidUserLbl;
        private KimTools.WinForms.KtComboBox cmbRole;
    }
}

