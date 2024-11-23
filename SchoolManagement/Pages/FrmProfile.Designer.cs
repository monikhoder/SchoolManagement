namespace SchoolManagement.Pages
{
    partial class FrmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfile));
            this.ProfilePanel = new KimTools.WinForms.KtPanel();
            this.RemoveBtn = new KimTools.WinForms.KtButton();
            this.ChooseFileBtn = new KimTools.WinForms.KtButton();
            this.ProfilePicture = new KimTools.WinForms.KtPictureBox();
            this.ProfileLbl = new KimTools.WinForms.KtLabel();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.ktMainPanel = new KimTools.WinForms.KtPanel();
            this.AddressTxb = new KimTools.WinForms.KtTextBox();
            this.LastNameTxb = new KimTools.WinForms.KtTextBox();
            this.FirstNameTxb = new KimTools.WinForms.KtTextBox();
            this.PhoneNumberTxb = new KimTools.WinForms.KtTextBox();
            this.UsernameTxb = new KimTools.WinForms.KtTextBox();
            this.NewPasswordTxb = new KimTools.WinForms.KtTextBox();
            this.ChangePassBtn = new KimTools.WinForms.KtButton();
            this.SaveBtn = new KimTools.WinForms.KtButton();
            this.NewPasswordLbl = new KimTools.WinForms.KtLabel();
            this.OldPasswordTxb = new KimTools.WinForms.KtTextBox();
            this.OldPasswordLbl = new KimTools.WinForms.KtLabel();
            this.AddressLbl = new KimTools.WinForms.KtLabel();
            this.PhoneNumberLbl = new KimTools.WinForms.KtLabel();
            this.UsernameLbl = new KimTools.WinForms.KtLabel();
            this.LastNameLbl = new KimTools.WinForms.KtLabel();
            this.FirstNameLbl = new KimTools.WinForms.KtLabel();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.Mainpanel.SuspendLayout();
            this.ktMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ProfilePanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ProfilePanel.BgOpacity = 255;
            this.ProfilePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(192)))), ((int)(((byte)(202)))));
            this.ProfilePanel.BorderOpacity = 255;
            this.ProfilePanel.BorderRadiusSize = 15;
            this.ProfilePanel.BorderShape = KimTools.WinForms.KtSize.Default;
            this.ProfilePanel.BorderSize = KimTools.WinForms.KtSize.Default;
            this.ProfilePanel.BorderThickness = 1;
            this.ProfilePanel.Controls.Add(this.RemoveBtn);
            this.ProfilePanel.Controls.Add(this.ChooseFileBtn);
            this.ProfilePanel.Controls.Add(this.ProfilePicture);
            this.ProfilePanel.Controls.Add(this.ProfileLbl);
            this.ProfilePanel.CustomColors = new System.Drawing.Color[0];
            this.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProfilePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.ShowBorders = true;
            this.ProfilePanel.Size = new System.Drawing.Size(247, 535);
            this.ProfilePanel.TabIndex = 1;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.BackColor = System.Drawing.Color.Empty;
            this.RemoveBtn.BorderShape = KimTools.WinForms.KtSize.Lg;
            this.RemoveBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.RemoveBtn.CustomColors = new System.Drawing.Color[0];
            this.RemoveBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveBtn.IconName = "";
            this.RemoveBtn.IconSize = 12;
            this.RemoveBtn.IconStroke = 2.5D;
            this.RemoveBtn.Location = new System.Drawing.Point(46, 288);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(143, 42);
            this.RemoveBtn.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseFileBtn.BackColor = System.Drawing.Color.Empty;
            this.ChooseFileBtn.BorderShape = KimTools.WinForms.KtSize.Lg;
            this.ChooseFileBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.ChooseFileBtn.CustomColors = new System.Drawing.Color[0];
            this.ChooseFileBtn.FlatAppearance.BorderSize = 0;
            this.ChooseFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChooseFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChooseFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFileBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChooseFileBtn.IconName = "";
            this.ChooseFileBtn.IconSize = 12;
            this.ChooseFileBtn.IconStroke = 2.5D;
            this.ChooseFileBtn.Location = new System.Drawing.Point(46, 240);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(143, 42);
            this.ChooseFileBtn.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.ChooseFileBtn.TabIndex = 3;
            this.ChooseFileBtn.Text = "Choose File";
            this.ChooseFileBtn.UseVisualStyleBackColor = false;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.AllowFocused = false;
            this.ProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePicture.AutoSizeHeight = true;
            this.ProfilePicture.BorderRadius = 48;
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.IsCircle = true;
            this.ProfilePicture.Location = new System.Drawing.Point(73, 138);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(96, 96);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 2;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Type = KimTools.WinForms.KtPictureBox.Types.Circle;
            // 
            // ProfileLbl
            // 
            this.ProfileLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileLbl.AutoSize = true;
            this.ProfileLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ProfileLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(78)))), ((int)(((byte)(218)))));
            this.ProfileLbl.KtFontSize = KimTools.WinForms.KtFont.H3;
            this.ProfileLbl.LabelColor = KimTools.WinForms.KtColor.Primary;
            this.ProfileLbl.Location = new System.Drawing.Point(85, 103);
            this.ProfileLbl.Name = "ProfileLbl";
            this.ProfileLbl.Shade = KimTools.WinForms.KtShade.Light_10;
            this.ProfileLbl.Size = new System.Drawing.Size(84, 32);
            this.ProfileLbl.TabIndex = 1;
            this.ProfileLbl.Text = "Profile";
            // 
            // Mainpanel
            // 
            this.Mainpanel.Controls.Add(this.ktMainPanel);
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(247, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(730, 535);
            this.Mainpanel.TabIndex = 2;
            // 
            // ktMainPanel
            // 
            this.ktMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ktMainPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ktMainPanel.BgOpacity = 255;
            this.ktMainPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(192)))), ((int)(((byte)(202)))));
            this.ktMainPanel.BorderOpacity = 255;
            this.ktMainPanel.BorderRadiusSize = 15;
            this.ktMainPanel.BorderShape = KimTools.WinForms.KtSize.Default;
            this.ktMainPanel.BorderSize = KimTools.WinForms.KtSize.Default;
            this.ktMainPanel.BorderThickness = 1;
            this.ktMainPanel.Controls.Add(this.AddressTxb);
            this.ktMainPanel.Controls.Add(this.LastNameTxb);
            this.ktMainPanel.Controls.Add(this.FirstNameTxb);
            this.ktMainPanel.Controls.Add(this.PhoneNumberTxb);
            this.ktMainPanel.Controls.Add(this.UsernameTxb);
            this.ktMainPanel.Controls.Add(this.NewPasswordTxb);
            this.ktMainPanel.Controls.Add(this.ChangePassBtn);
            this.ktMainPanel.Controls.Add(this.SaveBtn);
            this.ktMainPanel.Controls.Add(this.NewPasswordLbl);
            this.ktMainPanel.Controls.Add(this.OldPasswordTxb);
            this.ktMainPanel.Controls.Add(this.OldPasswordLbl);
            this.ktMainPanel.Controls.Add(this.AddressLbl);
            this.ktMainPanel.Controls.Add(this.PhoneNumberLbl);
            this.ktMainPanel.Controls.Add(this.UsernameLbl);
            this.ktMainPanel.Controls.Add(this.LastNameLbl);
            this.ktMainPanel.Controls.Add(this.FirstNameLbl);
            this.ktMainPanel.CustomColors = new System.Drawing.Color[0];
            this.ktMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ktMainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktMainPanel.Location = new System.Drawing.Point(0, 0);
            this.ktMainPanel.Name = "ktMainPanel";
            this.ktMainPanel.ShowBorders = true;
            this.ktMainPanel.Size = new System.Drawing.Size(730, 535);
            this.ktMainPanel.TabIndex = 0;
            // 
            // AddressTxb
            // 
            this.AddressTxb.AcceptsReturn = false;
            this.AddressTxb.AcceptsTab = false;
            this.AddressTxb.AnimationSpeed = 200;
            this.AddressTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AddressTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AddressTxb.AutoSizeHeight = true;
            this.AddressTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.AddressTxb.Bg = KimTools.WinForms.KtColor.Light;
            this.AddressTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.AddressTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.AddressTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.AddressTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.AddressTxb.CustomIconLeft = null;
            this.AddressTxb.CustomIconRight = null;
            this.AddressTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.AddressTxb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.AddressTxb.Enabled = false;
            this.AddressTxb.ForeColor = System.Drawing.Color.Empty;
            this.AddressTxb.HideSelection = true;
            this.AddressTxb.Lines = new string[0];
            this.AddressTxb.Location = new System.Drawing.Point(27, 251);
            this.AddressTxb.MaxLength = 32767;
            this.AddressTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddressTxb.Modified = false;
            this.AddressTxb.Name = "AddressTxb";
            this.AddressTxb.Password = false;
            this.AddressTxb.PasswordChar = '\0';
            this.AddressTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddressTxb.SelectedText = "";
            this.AddressTxb.SelectionLength = 0;
            this.AddressTxb.SelectionStart = 0;
            this.AddressTxb.ShortcutsEnabled = true;
            this.AddressTxb.Size = new System.Drawing.Size(678, 43);
            this.AddressTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.AddressTxb.TabIndex = 21;
            this.AddressTxb.TextMarginBottom = 0;
            this.AddressTxb.TextPlaceholder = "Enter Address";
            this.AddressTxb.TextChange += new System.EventHandler(this.Textbox_TextChange);
            // 
            // LastNameTxb
            // 
            this.LastNameTxb.AcceptsReturn = false;
            this.LastNameTxb.AcceptsTab = false;
            this.LastNameTxb.AnimationSpeed = 200;
            this.LastNameTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LastNameTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LastNameTxb.AutoSizeHeight = true;
            this.LastNameTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.LastNameTxb.Bg = KimTools.WinForms.KtColor.Light;
            this.LastNameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.LastNameTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.LastNameTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.LastNameTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.LastNameTxb.CustomIconLeft = null;
            this.LastNameTxb.CustomIconRight = null;
            this.LastNameTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.LastNameTxb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LastNameTxb.Enabled = false;
            this.LastNameTxb.ForeColor = System.Drawing.Color.Empty;
            this.LastNameTxb.HideSelection = true;
            this.LastNameTxb.Lines = new string[0];
            this.LastNameTxb.Location = new System.Drawing.Point(371, 77);
            this.LastNameTxb.MaxLength = 32767;
            this.LastNameTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.LastNameTxb.Modified = false;
            this.LastNameTxb.Name = "LastNameTxb";
            this.LastNameTxb.Password = false;
            this.LastNameTxb.PasswordChar = '\0';
            this.LastNameTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastNameTxb.SelectedText = "";
            this.LastNameTxb.SelectionLength = 0;
            this.LastNameTxb.SelectionStart = 0;
            this.LastNameTxb.ShortcutsEnabled = true;
            this.LastNameTxb.Size = new System.Drawing.Size(334, 43);
            this.LastNameTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.LastNameTxb.TabIndex = 20;
            this.LastNameTxb.TextMarginBottom = 0;
            this.LastNameTxb.TextPlaceholder = "Enter Last Name";
            this.LastNameTxb.TextChange += new System.EventHandler(this.Textbox_TextChange);
            // 
            // FirstNameTxb
            // 
            this.FirstNameTxb.AcceptsReturn = false;
            this.FirstNameTxb.AcceptsTab = false;
            this.FirstNameTxb.AnimationSpeed = 200;
            this.FirstNameTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FirstNameTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FirstNameTxb.AutoSizeHeight = true;
            this.FirstNameTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.FirstNameTxb.Bg = KimTools.WinForms.KtColor.Light;
            this.FirstNameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.FirstNameTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.FirstNameTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.FirstNameTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.FirstNameTxb.CustomIconLeft = null;
            this.FirstNameTxb.CustomIconRight = null;
            this.FirstNameTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.FirstNameTxb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FirstNameTxb.Enabled = false;
            this.FirstNameTxb.ForeColor = System.Drawing.Color.Empty;
            this.FirstNameTxb.HideSelection = true;
            this.FirstNameTxb.Lines = new string[0];
            this.FirstNameTxb.Location = new System.Drawing.Point(27, 77);
            this.FirstNameTxb.MaxLength = 32767;
            this.FirstNameTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.FirstNameTxb.Modified = false;
            this.FirstNameTxb.Name = "FirstNameTxb";
            this.FirstNameTxb.Password = false;
            this.FirstNameTxb.PasswordChar = '\0';
            this.FirstNameTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FirstNameTxb.SelectedText = "";
            this.FirstNameTxb.SelectionLength = 0;
            this.FirstNameTxb.SelectionStart = 0;
            this.FirstNameTxb.ShortcutsEnabled = true;
            this.FirstNameTxb.Size = new System.Drawing.Size(334, 43);
            this.FirstNameTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.FirstNameTxb.TabIndex = 19;
            this.FirstNameTxb.TextMarginBottom = 0;
            this.FirstNameTxb.TextPlaceholder = "Enter First Name";
            this.FirstNameTxb.TextChange += new System.EventHandler(this.Textbox_TextChange);
            // 
            // PhoneNumberTxb
            // 
            this.PhoneNumberTxb.AcceptsReturn = false;
            this.PhoneNumberTxb.AcceptsTab = false;
            this.PhoneNumberTxb.AnimationSpeed = 200;
            this.PhoneNumberTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PhoneNumberTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PhoneNumberTxb.AutoSizeHeight = true;
            this.PhoneNumberTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.PhoneNumberTxb.Bg = KimTools.WinForms.KtColor.Light;
            this.PhoneNumberTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.PhoneNumberTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.PhoneNumberTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.PhoneNumberTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.PhoneNumberTxb.CustomIconLeft = null;
            this.PhoneNumberTxb.CustomIconRight = null;
            this.PhoneNumberTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.PhoneNumberTxb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.PhoneNumberTxb.Enabled = false;
            this.PhoneNumberTxb.ForeColor = System.Drawing.Color.Empty;
            this.PhoneNumberTxb.HideSelection = true;
            this.PhoneNumberTxb.Lines = new string[0];
            this.PhoneNumberTxb.Location = new System.Drawing.Point(371, 163);
            this.PhoneNumberTxb.MaxLength = 32767;
            this.PhoneNumberTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.PhoneNumberTxb.Modified = false;
            this.PhoneNumberTxb.Name = "PhoneNumberTxb";
            this.PhoneNumberTxb.Password = false;
            this.PhoneNumberTxb.PasswordChar = '\0';
            this.PhoneNumberTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneNumberTxb.SelectedText = "";
            this.PhoneNumberTxb.SelectionLength = 0;
            this.PhoneNumberTxb.SelectionStart = 0;
            this.PhoneNumberTxb.ShortcutsEnabled = true;
            this.PhoneNumberTxb.Size = new System.Drawing.Size(334, 43);
            this.PhoneNumberTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.PhoneNumberTxb.TabIndex = 18;
            this.PhoneNumberTxb.TextMarginBottom = 0;
            this.PhoneNumberTxb.TextPlaceholder = "Enter Phone Number";
            this.PhoneNumberTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTxb_KeyPress);
            this.PhoneNumberTxb.TextChange += new System.EventHandler(this.Textbox_TextChange);
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
            this.UsernameTxb.Bg = KimTools.WinForms.KtColor.Light;
            this.UsernameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.UsernameTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.UsernameTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.UsernameTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.UsernameTxb.CustomIconLeft = null;
            this.UsernameTxb.CustomIconRight = null;
            this.UsernameTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.UsernameTxb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.UsernameTxb.ForeColor = System.Drawing.Color.Empty;
            this.UsernameTxb.HideSelection = true;
            this.UsernameTxb.Lines = new string[0];
            this.UsernameTxb.Location = new System.Drawing.Point(27, 163);
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
            this.UsernameTxb.Size = new System.Drawing.Size(334, 43);
            this.UsernameTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.UsernameTxb.TabIndex = 17;
            this.UsernameTxb.TextMarginBottom = 0;
            this.UsernameTxb.TextPlaceholder = "Enter Username";
            this.UsernameTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nospace_KeyPress);
            this.UsernameTxb.TextChange += new System.EventHandler(this.Textbox_TextChange);
            // 
            // NewPasswordTxb
            // 
            this.NewPasswordTxb.AcceptsReturn = false;
            this.NewPasswordTxb.AcceptsTab = false;
            this.NewPasswordTxb.AnimationSpeed = 200;
            this.NewPasswordTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NewPasswordTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NewPasswordTxb.AutoSizeHeight = true;
            this.NewPasswordTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.NewPasswordTxb.Bg = KimTools.WinForms.KtColor.Light;
            this.NewPasswordTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPasswordTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.NewPasswordTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.NewPasswordTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.NewPasswordTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.NewPasswordTxb.CustomIconLeft = null;
            this.NewPasswordTxb.CustomIconRight = null;
            this.NewPasswordTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.NewPasswordTxb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.NewPasswordTxb.ForeColor = System.Drawing.Color.Empty;
            this.NewPasswordTxb.HideSelection = true;
            this.NewPasswordTxb.Lines = new string[0];
            this.NewPasswordTxb.Location = new System.Drawing.Point(371, 424);
            this.NewPasswordTxb.MaxLength = 32767;
            this.NewPasswordTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.NewPasswordTxb.Modified = false;
            this.NewPasswordTxb.Name = "NewPasswordTxb";
            this.NewPasswordTxb.Password = true;
            this.NewPasswordTxb.PasswordChar = '\0';
            this.NewPasswordTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewPasswordTxb.SelectedText = "";
            this.NewPasswordTxb.SelectionLength = 0;
            this.NewPasswordTxb.SelectionStart = 0;
            this.NewPasswordTxb.ShortcutsEnabled = true;
            this.NewPasswordTxb.Size = new System.Drawing.Size(334, 43);
            this.NewPasswordTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.NewPasswordTxb.TabIndex = 16;
            this.NewPasswordTxb.TextMarginBottom = 0;
            this.NewPasswordTxb.TextPlaceholder = "Enter New Password";
            this.NewPasswordTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nospace_KeyPress);
            this.NewPasswordTxb.TextChange += new System.EventHandler(this.Textbox_TextChange);
            // 
            // ChangePassBtn
            // 
            this.ChangePassBtn.BackColor = System.Drawing.Color.Empty;
            this.ChangePassBtn.BorderShape = KimTools.WinForms.KtSize.Lg;
            this.ChangePassBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.ChangePassBtn.CustomColors = new System.Drawing.Color[0];
            this.ChangePassBtn.Enabled = false;
            this.ChangePassBtn.FlatAppearance.BorderSize = 0;
            this.ChangePassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChangePassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChangePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChangePassBtn.IconName = "";
            this.ChangePassBtn.IconSize = 8;
            this.ChangePassBtn.IconStroke = 2.5D;
            this.ChangePassBtn.Location = new System.Drawing.Point(562, 481);
            this.ChangePassBtn.Name = "ChangePassBtn";
            this.ChangePassBtn.Size = new System.Drawing.Size(143, 42);
            this.ChangePassBtn.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.ChangePassBtn.TabIndex = 15;
            this.ChangePassBtn.Text = "Change Password";
            this.ChangePassBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Empty;
            this.SaveBtn.BorderShape = KimTools.WinForms.KtSize.Lg;
            this.SaveBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.SaveBtn.CustomColors = new System.Drawing.Color[0];
            this.SaveBtn.Enabled = false;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SaveBtn.IconName = "";
            this.SaveBtn.IconSize = 12;
            this.SaveBtn.IconStroke = 2.5D;
            this.SaveBtn.Location = new System.Drawing.Point(562, 305);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(143, 42);
            this.SaveBtn.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // NewPasswordLbl
            // 
            this.NewPasswordLbl.AutoSize = true;
            this.NewPasswordLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.NewPasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.NewPasswordLbl.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.NewPasswordLbl.LabelColor = KimTools.WinForms.KtColor.Primary;
            this.NewPasswordLbl.Location = new System.Drawing.Point(371, 395);
            this.NewPasswordLbl.Name = "NewPasswordLbl";
            this.NewPasswordLbl.Size = new System.Drawing.Size(133, 25);
            this.NewPasswordLbl.TabIndex = 12;
            this.NewPasswordLbl.Text = "New Password";
            // 
            // OldPasswordTxb
            // 
            this.OldPasswordTxb.AcceptsReturn = false;
            this.OldPasswordTxb.AcceptsTab = false;
            this.OldPasswordTxb.AnimationSpeed = 200;
            this.OldPasswordTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.OldPasswordTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.OldPasswordTxb.AutoSizeHeight = true;
            this.OldPasswordTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.OldPasswordTxb.Bg = KimTools.WinForms.KtColor.Light;
            this.OldPasswordTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OldPasswordTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.OldPasswordTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.OldPasswordTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.OldPasswordTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.OldPasswordTxb.CustomIconLeft = null;
            this.OldPasswordTxb.CustomIconRight = null;
            this.OldPasswordTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.OldPasswordTxb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.OldPasswordTxb.ForeColor = System.Drawing.Color.Empty;
            this.OldPasswordTxb.HideSelection = true;
            this.OldPasswordTxb.Lines = new string[0];
            this.OldPasswordTxb.Location = new System.Drawing.Point(27, 424);
            this.OldPasswordTxb.MaxLength = 32767;
            this.OldPasswordTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.OldPasswordTxb.Modified = false;
            this.OldPasswordTxb.Name = "OldPasswordTxb";
            this.OldPasswordTxb.Password = true;
            this.OldPasswordTxb.PasswordChar = '\0';
            this.OldPasswordTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OldPasswordTxb.SelectedText = "";
            this.OldPasswordTxb.SelectionLength = 0;
            this.OldPasswordTxb.SelectionStart = 0;
            this.OldPasswordTxb.ShortcutsEnabled = true;
            this.OldPasswordTxb.Size = new System.Drawing.Size(334, 43);
            this.OldPasswordTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.OldPasswordTxb.TabIndex = 11;
            this.OldPasswordTxb.TextMarginBottom = 0;
            this.OldPasswordTxb.TextPlaceholder = "Enter Old Password";
            this.OldPasswordTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nospace_KeyPress);
            this.OldPasswordTxb.TextChange += new System.EventHandler(this.Textbox_TextChange);
            // 
            // OldPasswordLbl
            // 
            this.OldPasswordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPasswordLbl.AutoSize = true;
            this.OldPasswordLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.OldPasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.OldPasswordLbl.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.OldPasswordLbl.LabelColor = KimTools.WinForms.KtColor.Primary;
            this.OldPasswordLbl.Location = new System.Drawing.Point(27, 395);
            this.OldPasswordLbl.Name = "OldPasswordLbl";
            this.OldPasswordLbl.Size = new System.Drawing.Size(125, 25);
            this.OldPasswordLbl.TabIndex = 10;
            this.OldPasswordLbl.Text = "Old Password";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.AddressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.AddressLbl.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.AddressLbl.LabelColor = KimTools.WinForms.KtColor.Primary;
            this.AddressLbl.Location = new System.Drawing.Point(27, 223);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(79, 25);
            this.AddressLbl.TabIndex = 8;
            this.AddressLbl.Text = "Address";
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.AutoSize = true;
            this.PhoneNumberLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.PhoneNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.PhoneNumberLbl.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.PhoneNumberLbl.LabelColor = KimTools.WinForms.KtColor.Primary;
            this.PhoneNumberLbl.Location = new System.Drawing.Point(371, 134);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(139, 25);
            this.PhoneNumberLbl.TabIndex = 6;
            this.PhoneNumberLbl.Text = "Phone Number";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.UsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.UsernameLbl.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.UsernameLbl.LabelColor = KimTools.WinForms.KtColor.Primary;
            this.UsernameLbl.Location = new System.Drawing.Point(27, 134);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(96, 25);
            this.UsernameLbl.TabIndex = 4;
            this.UsernameLbl.Text = "Username";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LastNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.LastNameLbl.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.LastNameLbl.LabelColor = KimTools.WinForms.KtColor.Primary;
            this.LastNameLbl.Location = new System.Drawing.Point(371, 52);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(99, 25);
            this.LastNameLbl.TabIndex = 2;
            this.LastNameLbl.Text = "Last Name";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FirstNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.FirstNameLbl.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.FirstNameLbl.LabelColor = KimTools.WinForms.KtColor.Primary;
            this.FirstNameLbl.Location = new System.Drawing.Point(27, 52);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(102, 25);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "First Name";
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 535);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.ProfilePanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProfile";
            this.Opacity = 1D;
            this.Role = KimTools.WinForms.KtColor.Tailwind_White;
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.Mainpanel.ResumeLayout(false);
            this.ktMainPanel.ResumeLayout(false);
            this.ktMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private KimTools.WinForms.KtPanel ProfilePanel;
        private KimTools.WinForms.KtButton ChooseFileBtn;
        private KimTools.WinForms.KtPictureBox ProfilePicture;
        private KimTools.WinForms.KtLabel ProfileLbl;
        private KimTools.WinForms.KtButton RemoveBtn;
        private System.Windows.Forms.Panel Mainpanel;
        private KimTools.WinForms.KtPanel ktMainPanel;
        private KimTools.WinForms.KtLabel FirstNameLbl;
        private KimTools.WinForms.KtLabel LastNameLbl;
        private KimTools.WinForms.KtLabel AddressLbl;
        private KimTools.WinForms.KtLabel PhoneNumberLbl;
        private KimTools.WinForms.KtLabel UsernameLbl;
        private KimTools.WinForms.KtButton ChangePassBtn;
        private KimTools.WinForms.KtButton SaveBtn;
        private KimTools.WinForms.KtLabel NewPasswordLbl;
        private KimTools.WinForms.KtTextBox OldPasswordTxb;
        private KimTools.WinForms.KtLabel OldPasswordLbl;
        private KimTools.WinForms.KtTextBox NewPasswordTxb;
        private KimTools.WinForms.KtTextBox AddressTxb;
        private KimTools.WinForms.KtTextBox LastNameTxb;
        private KimTools.WinForms.KtTextBox FirstNameTxb;
        private KimTools.WinForms.KtTextBox PhoneNumberTxb;
        private KimTools.WinForms.KtTextBox UsernameTxb;
    }
}