namespace SchoolManagement.Dialog
{
    partial class AddUser
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
            KimTools.WinForms.KtToastHelpers.KtPages.KtPgAnimatorNS.Animation animation1 = new KimTools.WinForms.KtToastHelpers.KtPages.KtPgAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.top = new System.Windows.Forms.Panel();
            this.AdSwBtn = new KimTools.WinForms.KtButton();
            this.tcSwBtn = new KimTools.WinForms.KtButton();
            this.StSwBtn = new KimTools.WinForms.KtButton();
            this.Pages = new KimTools.WinForms.KtPages();
            this.Student = new System.Windows.Forms.TabPage();
            this.ktButton3 = new KimTools.WinForms.KtButton();
            this.ktLabel3 = new KimTools.WinForms.KtLabel();
            this.ktLabel4 = new KimTools.WinForms.KtLabel();
            this.ktTextBox5 = new KimTools.WinForms.KtTextBox();
            this.ktLabel5 = new KimTools.WinForms.KtLabel();
            this.ktTextBox6 = new KimTools.WinForms.KtTextBox();
            this.ktLabel6 = new KimTools.WinForms.KtLabel();
            this.Teacher = new System.Windows.Forms.TabPage();
            this.Admin = new System.Windows.Forms.TabPage();
            this.GenderCmb = new KimTools.WinForms.KtComboBox();
            this.StudentStatusCmb = new KimTools.WinForms.KtComboBox();
            this.ktTextBox1 = new KimTools.WinForms.KtTextBox();
            this.ktLabel1 = new KimTools.WinForms.KtLabel();
            this.ktTextBox2 = new KimTools.WinForms.KtTextBox();
            this.ktLabel2 = new KimTools.WinForms.KtLabel();
            this.ktTextBox3 = new KimTools.WinForms.KtTextBox();
            this.ktLabel7 = new KimTools.WinForms.KtLabel();
            this.ktTextBox4 = new KimTools.WinForms.KtTextBox();
            this.ktLabel8 = new KimTools.WinForms.KtLabel();
            this.ktComboBox1 = new KimTools.WinForms.KtComboBox();
            this.ktComboBox2 = new KimTools.WinForms.KtComboBox();
            this.ktButton1 = new KimTools.WinForms.KtButton();
            this.ktLabel9 = new KimTools.WinForms.KtLabel();
            this.ktLabel10 = new KimTools.WinForms.KtLabel();
            this.ktTextBox7 = new KimTools.WinForms.KtTextBox();
            this.ktLabel11 = new KimTools.WinForms.KtLabel();
            this.ktTextBox8 = new KimTools.WinForms.KtTextBox();
            this.ktLabel12 = new KimTools.WinForms.KtLabel();
            this.ktButton2 = new KimTools.WinForms.KtButton();
            this.ktTextBox11 = new KimTools.WinForms.KtTextBox();
            this.ktLabel17 = new KimTools.WinForms.KtLabel();
            this.ktTextBox12 = new KimTools.WinForms.KtTextBox();
            this.ktLabel18 = new KimTools.WinForms.KtLabel();
            this.ktTextBox13 = new KimTools.WinForms.KtTextBox();
            this.ktLabel19 = new KimTools.WinForms.KtLabel();
            this.top.SuspendLayout();
            this.Pages.SuspendLayout();
            this.Student.SuspendLayout();
            this.Teacher.SuspendLayout();
            this.Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.Controls.Add(this.AdSwBtn);
            this.top.Controls.Add(this.tcSwBtn);
            this.top.Controls.Add(this.StSwBtn);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(3, 3);
            this.top.Name = "top";
            this.top.Padding = new System.Windows.Forms.Padding(5);
            this.top.Size = new System.Drawing.Size(633, 60);
            this.top.TabIndex = 0;
            // 
            // AdSwBtn
            // 
            this.AdSwBtn.BackColor = System.Drawing.Color.Empty;
            this.AdSwBtn.BorderShape = KimTools.WinForms.KtSize.Default;
            this.AdSwBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.AdSwBtn.CustomColors = new System.Drawing.Color[0];
            this.AdSwBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdSwBtn.FlatAppearance.BorderSize = 0;
            this.AdSwBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AdSwBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AdSwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdSwBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdSwBtn.ForeColor = System.Drawing.Color.Orchid;
            this.AdSwBtn.IconName = "Tabler.solid.arrow_badge_right_filled";
            this.AdSwBtn.IconSize = 16;
            this.AdSwBtn.IconStroke = 2.5D;
            this.AdSwBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdSwBtn.Location = new System.Drawing.Point(209, 5);
            this.AdSwBtn.Name = "AdSwBtn";
            this.AdSwBtn.Size = new System.Drawing.Size(102, 50);
            this.AdSwBtn.Style = KimTools.WinForms.KtStyle.Ghost;
            this.AdSwBtn.TabIndex = 2;
            this.AdSwBtn.Text = "Admin";
            this.AdSwBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdSwBtn.UseVisualStyleBackColor = false;
            this.AdSwBtn.Click += new System.EventHandler(this.AdSwBtn_Click);
            // 
            // tcSwBtn
            // 
            this.tcSwBtn.BackColor = System.Drawing.Color.Empty;
            this.tcSwBtn.BorderShape = KimTools.WinForms.KtSize.Default;
            this.tcSwBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.tcSwBtn.CustomColors = new System.Drawing.Color[0];
            this.tcSwBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.tcSwBtn.FlatAppearance.BorderSize = 0;
            this.tcSwBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tcSwBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tcSwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcSwBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcSwBtn.ForeColor = System.Drawing.Color.Orchid;
            this.tcSwBtn.IconName = "Tabler.solid.arrow_badge_right_filled";
            this.tcSwBtn.IconSize = 16;
            this.tcSwBtn.IconStroke = 2.5D;
            this.tcSwBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tcSwBtn.Location = new System.Drawing.Point(107, 5);
            this.tcSwBtn.Name = "tcSwBtn";
            this.tcSwBtn.Size = new System.Drawing.Size(102, 50);
            this.tcSwBtn.Style = KimTools.WinForms.KtStyle.Ghost;
            this.tcSwBtn.TabIndex = 1;
            this.tcSwBtn.Text = "Teacher";
            this.tcSwBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tcSwBtn.UseVisualStyleBackColor = false;
            this.tcSwBtn.Click += new System.EventHandler(this.tcSwBtn_Click);
            // 
            // StSwBtn
            // 
            this.StSwBtn.BackColor = System.Drawing.Color.Empty;
            this.StSwBtn.BorderShape = KimTools.WinForms.KtSize.Default;
            this.StSwBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.StSwBtn.CustomColors = new System.Drawing.Color[0];
            this.StSwBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.StSwBtn.FlatAppearance.BorderSize = 0;
            this.StSwBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StSwBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StSwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StSwBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StSwBtn.ForeColor = System.Drawing.Color.Orchid;
            this.StSwBtn.IconName = "Tabler.solid.arrow_badge_right_filled";
            this.StSwBtn.IconSize = 16;
            this.StSwBtn.IconStroke = 2.5D;
            this.StSwBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StSwBtn.Location = new System.Drawing.Point(5, 5);
            this.StSwBtn.Name = "StSwBtn";
            this.StSwBtn.Size = new System.Drawing.Size(102, 50);
            this.StSwBtn.Style = KimTools.WinForms.KtStyle.Ghost;
            this.StSwBtn.TabIndex = 0;
            this.StSwBtn.Text = "Student";
            this.StSwBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StSwBtn.UseVisualStyleBackColor = false;
            this.StSwBtn.Click += new System.EventHandler(this.StSwBtn_Click);
            // 
            // Pages
            // 
            this.Pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Pages.AllowTransitions = false;
            this.Pages.Controls.Add(this.Student);
            this.Pages.Controls.Add(this.Teacher);
            this.Pages.Controls.Add(this.Admin);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Location = new System.Drawing.Point(3, 63);
            this.Pages.Multiline = true;
            this.Pages.Name = "Pages";
            this.Pages.Page = this.Admin;
            this.Pages.PageIndex = 2;
            this.Pages.PageName = "Admin";
            this.Pages.PageTitle = "Admin";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(633, 395);
            this.Pages.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Pages.Transition = animation1;
            this.Pages.TransitionType = KimTools.WinForms.KtToastHelpers.KtPages.KtPgAnimatorNS.AnimationType.Custom;
            this.Pages.SelectedIndexChanged += new System.EventHandler(this.Pages_SelectedIndexChanged);
            // 
            // Student
            // 
            this.Student.Controls.Add(this.ktTextBox1);
            this.Student.Controls.Add(this.ktLabel1);
            this.Student.Controls.Add(this.ktTextBox2);
            this.Student.Controls.Add(this.ktLabel2);
            this.Student.Controls.Add(this.StudentStatusCmb);
            this.Student.Controls.Add(this.GenderCmb);
            this.Student.Controls.Add(this.ktButton3);
            this.Student.Controls.Add(this.ktLabel3);
            this.Student.Controls.Add(this.ktLabel4);
            this.Student.Controls.Add(this.ktTextBox5);
            this.Student.Controls.Add(this.ktLabel5);
            this.Student.Controls.Add(this.ktTextBox6);
            this.Student.Controls.Add(this.ktLabel6);
            this.Student.Location = new System.Drawing.Point(4, 4);
            this.Student.Name = "Student";
            this.Student.Padding = new System.Windows.Forms.Padding(3);
            this.Student.Size = new System.Drawing.Size(625, 357);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // ktButton3
            // 
            this.ktButton3.BackColor = System.Drawing.Color.Empty;
            this.ktButton3.BorderShape = KimTools.WinForms.KtSize.Default;
            this.ktButton3.BorderSize = KimTools.WinForms.KtSize.Default;
            this.ktButton3.CustomColors = new System.Drawing.Color[0];
            this.ktButton3.FlatAppearance.BorderSize = 0;
            this.ktButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ktButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ktButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ktButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ktButton3.IconName = "";
            this.ktButton3.IconSize = 16;
            this.ktButton3.IconStroke = 2.5D;
            this.ktButton3.Location = new System.Drawing.Point(493, 291);
            this.ktButton3.Name = "ktButton3";
            this.ktButton3.Size = new System.Drawing.Size(95, 37);
            this.ktButton3.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.ktButton3.TabIndex = 34;
            this.ktButton3.Text = "ADD";
            this.ktButton3.UseVisualStyleBackColor = false;
            this.ktButton3.Click += new System.EventHandler(this.ktButton3_Click);
            // 
            // ktLabel3
            // 
            this.ktLabel3.AutoSize = true;
            this.ktLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel3.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel3.Location = new System.Drawing.Point(363, 96);
            this.ktLabel3.Name = "ktLabel3";
            this.ktLabel3.Size = new System.Drawing.Size(63, 25);
            this.ktLabel3.TabIndex = 32;
            this.ktLabel3.Text = "Status";
            this.ktLabel3.Click += new System.EventHandler(this.ktLabel3_Click);
            // 
            // ktLabel4
            // 
            this.ktLabel4.AutoSize = true;
            this.ktLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel4.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel4.Location = new System.Drawing.Point(32, 96);
            this.ktLabel4.Name = "ktLabel4";
            this.ktLabel4.Size = new System.Drawing.Size(74, 25);
            this.ktLabel4.TabIndex = 30;
            this.ktLabel4.Text = "Gender";
            this.ktLabel4.Click += new System.EventHandler(this.ktLabel4_Click);
            // 
            // ktTextBox5
            // 
            this.ktTextBox5.AcceptsReturn = false;
            this.ktTextBox5.AcceptsTab = false;
            this.ktTextBox5.AnimationSpeed = 200;
            this.ktTextBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox5.AutoSizeHeight = true;
            this.ktTextBox5.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox5.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox5.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox5.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox5.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox5.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox5.CustomIconLeft = null;
            this.ktTextBox5.CustomIconRight = null;
            this.ktTextBox5.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox5.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox5.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox5.HideSelection = true;
            this.ktTextBox5.Lines = new string[0];
            this.ktTextBox5.Location = new System.Drawing.Point(358, 56);
            this.ktTextBox5.MaxLength = 32767;
            this.ktTextBox5.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox5.Modified = false;
            this.ktTextBox5.Name = "ktTextBox5";
            this.ktTextBox5.Password = false;
            this.ktTextBox5.PasswordChar = '\0';
            this.ktTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox5.SelectedText = "";
            this.ktTextBox5.SelectionLength = 0;
            this.ktTextBox5.SelectionStart = 0;
            this.ktTextBox5.ShortcutsEnabled = true;
            this.ktTextBox5.Size = new System.Drawing.Size(235, 27);
            this.ktTextBox5.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox5.TabIndex = 29;
            this.ktTextBox5.TextMarginBottom = 0;
            this.ktTextBox5.TextPlaceholder = "Enter Last Name";
            this.ktTextBox5.TextChanged += new System.EventHandler(this.ktTextBox5_TextChanged);
            // 
            // ktLabel5
            // 
            this.ktLabel5.AutoSize = true;
            this.ktLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel5.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel5.Location = new System.Drawing.Point(363, 28);
            this.ktLabel5.Name = "ktLabel5";
            this.ktLabel5.Size = new System.Drawing.Size(99, 25);
            this.ktLabel5.TabIndex = 28;
            this.ktLabel5.Text = "Last Name";
            this.ktLabel5.Click += new System.EventHandler(this.ktLabel5_Click);
            // 
            // ktTextBox6
            // 
            this.ktTextBox6.AcceptsReturn = false;
            this.ktTextBox6.AcceptsTab = false;
            this.ktTextBox6.AnimationSpeed = 200;
            this.ktTextBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox6.AutoSizeHeight = true;
            this.ktTextBox6.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox6.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox6.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox6.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox6.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox6.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox6.CustomIconLeft = null;
            this.ktTextBox6.CustomIconRight = null;
            this.ktTextBox6.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox6.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox6.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox6.HideSelection = true;
            this.ktTextBox6.Lines = new string[0];
            this.ktTextBox6.Location = new System.Drawing.Point(32, 56);
            this.ktTextBox6.MaxLength = 32767;
            this.ktTextBox6.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox6.Modified = false;
            this.ktTextBox6.Name = "ktTextBox6";
            this.ktTextBox6.Password = false;
            this.ktTextBox6.PasswordChar = '\0';
            this.ktTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox6.SelectedText = "";
            this.ktTextBox6.SelectionLength = 0;
            this.ktTextBox6.SelectionStart = 0;
            this.ktTextBox6.ShortcutsEnabled = true;
            this.ktTextBox6.Size = new System.Drawing.Size(230, 27);
            this.ktTextBox6.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox6.TabIndex = 27;
            this.ktTextBox6.TextMarginBottom = 0;
            this.ktTextBox6.TextPlaceholder = "Enter First Name";
            this.ktTextBox6.TextChanged += new System.EventHandler(this.ktTextBox6_TextChanged);
            // 
            // ktLabel6
            // 
            this.ktLabel6.AutoSize = true;
            this.ktLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel6.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel6.Location = new System.Drawing.Point(32, 28);
            this.ktLabel6.Name = "ktLabel6";
            this.ktLabel6.Size = new System.Drawing.Size(102, 25);
            this.ktLabel6.TabIndex = 26;
            this.ktLabel6.Text = "First Name";
            this.ktLabel6.Click += new System.EventHandler(this.ktLabel6_Click);
            // 
            // Teacher
            // 
            this.Teacher.Controls.Add(this.ktTextBox13);
            this.Teacher.Controls.Add(this.ktLabel19);
            this.Teacher.Controls.Add(this.ktTextBox3);
            this.Teacher.Controls.Add(this.ktLabel7);
            this.Teacher.Controls.Add(this.ktTextBox4);
            this.Teacher.Controls.Add(this.ktLabel8);
            this.Teacher.Controls.Add(this.ktComboBox1);
            this.Teacher.Controls.Add(this.ktComboBox2);
            this.Teacher.Controls.Add(this.ktButton1);
            this.Teacher.Controls.Add(this.ktLabel9);
            this.Teacher.Controls.Add(this.ktLabel10);
            this.Teacher.Controls.Add(this.ktTextBox7);
            this.Teacher.Controls.Add(this.ktLabel11);
            this.Teacher.Controls.Add(this.ktTextBox8);
            this.Teacher.Controls.Add(this.ktLabel12);
            this.Teacher.Location = new System.Drawing.Point(4, 4);
            this.Teacher.Name = "Teacher";
            this.Teacher.Padding = new System.Windows.Forms.Padding(3);
            this.Teacher.Size = new System.Drawing.Size(625, 357);
            this.Teacher.TabIndex = 2;
            this.Teacher.Text = "Teacher";
            this.Teacher.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.ktButton2);
            this.Admin.Controls.Add(this.ktTextBox11);
            this.Admin.Controls.Add(this.ktLabel17);
            this.Admin.Controls.Add(this.ktTextBox12);
            this.Admin.Controls.Add(this.ktLabel18);
            this.Admin.Location = new System.Drawing.Point(4, 4);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(3);
            this.Admin.Size = new System.Drawing.Size(625, 357);
            this.Admin.TabIndex = 3;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // GenderCmb
            // 
            this.GenderCmb.BackColor = System.Drawing.Color.Transparent;
            this.GenderCmb.BackgroundColor = System.Drawing.Color.White;
            this.GenderCmb.BorderColor = System.Drawing.Color.Silver;
            this.GenderCmb.BorderRadius = 1;
            this.GenderCmb.Color = System.Drawing.Color.Silver;
            this.GenderCmb.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.GenderCmb.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.GenderCmb.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GenderCmb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.GenderCmb.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GenderCmb.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.GenderCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderCmb.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.GenderCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCmb.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.GenderCmb.FillDropDown = true;
            this.GenderCmb.FillIndicator = false;
            this.GenderCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderCmb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenderCmb.ForeColor = System.Drawing.Color.Black;
            this.GenderCmb.FormattingEnabled = true;
            this.GenderCmb.Icon = null;
            this.GenderCmb.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.GenderCmb.IndicatorColor = System.Drawing.Color.Gray;
            this.GenderCmb.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.GenderCmb.ItemBackColor = System.Drawing.Color.White;
            this.GenderCmb.ItemBorderColor = System.Drawing.Color.White;
            this.GenderCmb.ItemForeColor = System.Drawing.Color.Black;
            this.GenderCmb.ItemHeight = 26;
            this.GenderCmb.ItemHighLightColor = System.Drawing.Color.BlueViolet;
            this.GenderCmb.ItemHighLightForeColor = System.Drawing.Color.White;
            this.GenderCmb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderCmb.ItemTopMargin = 3;
            this.GenderCmb.Location = new System.Drawing.Point(32, 124);
            this.GenderCmb.Name = "GenderCmb";
            this.GenderCmb.Size = new System.Drawing.Size(230, 32);
            this.GenderCmb.TabIndex = 39;
            this.GenderCmb.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.GenderCmb.TextLeftMargin = 5;
            this.GenderCmb.SelectedIndexChanged += new System.EventHandler(this.GenderCmb_SelectedIndexChanged);
            // 
            // StudentStatusCmb
            // 
            this.StudentStatusCmb.BackColor = System.Drawing.Color.Transparent;
            this.StudentStatusCmb.BackgroundColor = System.Drawing.Color.White;
            this.StudentStatusCmb.BorderColor = System.Drawing.Color.Silver;
            this.StudentStatusCmb.BorderRadius = 1;
            this.StudentStatusCmb.Color = System.Drawing.Color.Silver;
            this.StudentStatusCmb.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.StudentStatusCmb.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.StudentStatusCmb.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.StudentStatusCmb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.StudentStatusCmb.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StudentStatusCmb.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.StudentStatusCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StudentStatusCmb.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.StudentStatusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentStatusCmb.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.StudentStatusCmb.FillDropDown = true;
            this.StudentStatusCmb.FillIndicator = false;
            this.StudentStatusCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentStatusCmb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StudentStatusCmb.ForeColor = System.Drawing.Color.Black;
            this.StudentStatusCmb.FormattingEnabled = true;
            this.StudentStatusCmb.Icon = null;
            this.StudentStatusCmb.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.StudentStatusCmb.IndicatorColor = System.Drawing.Color.Gray;
            this.StudentStatusCmb.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.StudentStatusCmb.ItemBackColor = System.Drawing.Color.White;
            this.StudentStatusCmb.ItemBorderColor = System.Drawing.Color.White;
            this.StudentStatusCmb.ItemForeColor = System.Drawing.Color.Black;
            this.StudentStatusCmb.ItemHeight = 26;
            this.StudentStatusCmb.ItemHighLightColor = System.Drawing.Color.BlueViolet;
            this.StudentStatusCmb.ItemHighLightForeColor = System.Drawing.Color.White;
            this.StudentStatusCmb.Items.AddRange(new object[] {
            "Active",
            "NonActive"});
            this.StudentStatusCmb.ItemTopMargin = 3;
            this.StudentStatusCmb.Location = new System.Drawing.Point(358, 124);
            this.StudentStatusCmb.Name = "StudentStatusCmb";
            this.StudentStatusCmb.Size = new System.Drawing.Size(235, 32);
            this.StudentStatusCmb.TabIndex = 40;
            this.StudentStatusCmb.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.StudentStatusCmb.TextLeftMargin = 5;
            this.StudentStatusCmb.SelectedIndexChanged += new System.EventHandler(this.StudentStatusCmb_SelectedIndexChanged);
            // 
            // ktTextBox1
            // 
            this.ktTextBox1.AcceptsReturn = false;
            this.ktTextBox1.AcceptsTab = false;
            this.ktTextBox1.AnimationSpeed = 200;
            this.ktTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox1.AutoSizeHeight = true;
            this.ktTextBox1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox1.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox1.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox1.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox1.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox1.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox1.CustomIconLeft = null;
            this.ktTextBox1.CustomIconRight = null;
            this.ktTextBox1.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox1.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox1.HideSelection = true;
            this.ktTextBox1.Lines = new string[0];
            this.ktTextBox1.Location = new System.Drawing.Point(358, 196);
            this.ktTextBox1.MaxLength = 32767;
            this.ktTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox1.Modified = false;
            this.ktTextBox1.Name = "ktTextBox1";
            this.ktTextBox1.Password = false;
            this.ktTextBox1.PasswordChar = '\0';
            this.ktTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox1.SelectedText = "";
            this.ktTextBox1.SelectionLength = 0;
            this.ktTextBox1.SelectionStart = 0;
            this.ktTextBox1.ShortcutsEnabled = true;
            this.ktTextBox1.Size = new System.Drawing.Size(235, 27);
            this.ktTextBox1.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox1.TabIndex = 44;
            this.ktTextBox1.TextMarginBottom = 0;
            this.ktTextBox1.TextPlaceholder = "Enter Password";
            this.ktTextBox1.TextChanged += new System.EventHandler(this.ktTextBox1_TextChanged_1);
            // 
            // ktLabel1
            // 
            this.ktLabel1.AutoSize = true;
            this.ktLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel1.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel1.Location = new System.Drawing.Point(363, 168);
            this.ktLabel1.Name = "ktLabel1";
            this.ktLabel1.Size = new System.Drawing.Size(108, 30);
            this.ktLabel1.TabIndex = 43;
            this.ktLabel1.Text = "Password";
            this.ktLabel1.Click += new System.EventHandler(this.ktLabel1_Click);
            // 
            // ktTextBox2
            // 
            this.ktTextBox2.AcceptsReturn = false;
            this.ktTextBox2.AcceptsTab = false;
            this.ktTextBox2.AnimationSpeed = 200;
            this.ktTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox2.AutoSizeHeight = true;
            this.ktTextBox2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox2.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox2.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox2.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox2.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox2.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox2.CustomIconLeft = null;
            this.ktTextBox2.CustomIconRight = null;
            this.ktTextBox2.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox2.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox2.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox2.HideSelection = true;
            this.ktTextBox2.Lines = new string[0];
            this.ktTextBox2.Location = new System.Drawing.Point(32, 196);
            this.ktTextBox2.MaxLength = 32767;
            this.ktTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox2.Modified = false;
            this.ktTextBox2.Name = "ktTextBox2";
            this.ktTextBox2.Password = false;
            this.ktTextBox2.PasswordChar = '\0';
            this.ktTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox2.SelectedText = "";
            this.ktTextBox2.SelectionLength = 0;
            this.ktTextBox2.SelectionStart = 0;
            this.ktTextBox2.ShortcutsEnabled = true;
            this.ktTextBox2.Size = new System.Drawing.Size(230, 27);
            this.ktTextBox2.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox2.TabIndex = 42;
            this.ktTextBox2.TextMarginBottom = 0;
            this.ktTextBox2.TextPlaceholder = "Enter UserName";
            this.ktTextBox2.TextChanged += new System.EventHandler(this.ktTextBox2_TextChanged);
            // 
            // ktLabel2
            // 
            this.ktLabel2.AutoSize = true;
            this.ktLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel2.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel2.Location = new System.Drawing.Point(32, 168);
            this.ktLabel2.Name = "ktLabel2";
            this.ktLabel2.Size = new System.Drawing.Size(99, 25);
            this.ktLabel2.TabIndex = 41;
            this.ktLabel2.Text = "UserName";
            this.ktLabel2.Click += new System.EventHandler(this.ktLabel2_Click);
            // 
            // ktTextBox3
            // 
            this.ktTextBox3.AcceptsReturn = false;
            this.ktTextBox3.AcceptsTab = false;
            this.ktTextBox3.AnimationSpeed = 200;
            this.ktTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox3.AutoSizeHeight = true;
            this.ktTextBox3.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox3.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox3.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox3.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox3.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox3.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox3.CustomIconLeft = null;
            this.ktTextBox3.CustomIconRight = null;
            this.ktTextBox3.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox3.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox3.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox3.HideSelection = true;
            this.ktTextBox3.Lines = new string[0];
            this.ktTextBox3.Location = new System.Drawing.Point(358, 196);
            this.ktTextBox3.MaxLength = 32767;
            this.ktTextBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox3.Modified = false;
            this.ktTextBox3.Name = "ktTextBox3";
            this.ktTextBox3.Password = true;
            this.ktTextBox3.PasswordChar = '\0';
            this.ktTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox3.SelectedText = "";
            this.ktTextBox3.SelectionLength = 0;
            this.ktTextBox3.SelectionStart = 0;
            this.ktTextBox3.ShortcutsEnabled = true;
            this.ktTextBox3.Size = new System.Drawing.Size(235, 27);
            this.ktTextBox3.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox3.TabIndex = 57;
            this.ktTextBox3.TextMarginBottom = 0;
            this.ktTextBox3.TextPlaceholder = "Enter Password";
            // 
            // ktLabel7
            // 
            this.ktLabel7.AutoSize = true;
            this.ktLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel7.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel7.Location = new System.Drawing.Point(363, 168);
            this.ktLabel7.Name = "ktLabel7";
            this.ktLabel7.Size = new System.Drawing.Size(90, 25);
            this.ktLabel7.TabIndex = 56;
            this.ktLabel7.Text = "Password";
            // 
            // ktTextBox4
            // 
            this.ktTextBox4.AcceptsReturn = false;
            this.ktTextBox4.AcceptsTab = false;
            this.ktTextBox4.AnimationSpeed = 200;
            this.ktTextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox4.AutoSizeHeight = true;
            this.ktTextBox4.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox4.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox4.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox4.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox4.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox4.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox4.CustomIconLeft = null;
            this.ktTextBox4.CustomIconRight = null;
            this.ktTextBox4.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox4.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox4.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox4.HideSelection = true;
            this.ktTextBox4.Lines = new string[0];
            this.ktTextBox4.Location = new System.Drawing.Point(32, 196);
            this.ktTextBox4.MaxLength = 32767;
            this.ktTextBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox4.Modified = false;
            this.ktTextBox4.Name = "ktTextBox4";
            this.ktTextBox4.Password = false;
            this.ktTextBox4.PasswordChar = '\0';
            this.ktTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox4.SelectedText = "";
            this.ktTextBox4.SelectionLength = 0;
            this.ktTextBox4.SelectionStart = 0;
            this.ktTextBox4.ShortcutsEnabled = true;
            this.ktTextBox4.Size = new System.Drawing.Size(230, 27);
            this.ktTextBox4.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox4.TabIndex = 55;
            this.ktTextBox4.TextMarginBottom = 0;
            this.ktTextBox4.TextPlaceholder = "Enter UserName";
            // 
            // ktLabel8
            // 
            this.ktLabel8.AutoSize = true;
            this.ktLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel8.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel8.Location = new System.Drawing.Point(32, 168);
            this.ktLabel8.Name = "ktLabel8";
            this.ktLabel8.Size = new System.Drawing.Size(99, 25);
            this.ktLabel8.TabIndex = 54;
            this.ktLabel8.Text = "UserName";
            // 
            // ktComboBox1
            // 
            this.ktComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ktComboBox1.BackgroundColor = System.Drawing.Color.White;
            this.ktComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.ktComboBox1.BorderRadius = 1;
            this.ktComboBox1.Color = System.Drawing.Color.Silver;
            this.ktComboBox1.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.ktComboBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ktComboBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ktComboBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ktComboBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ktComboBox1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ktComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ktComboBox1.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.ktComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ktComboBox1.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.ktComboBox1.FillDropDown = true;
            this.ktComboBox1.FillIndicator = false;
            this.ktComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ktComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ktComboBox1.ForeColor = System.Drawing.Color.Black;
            this.ktComboBox1.FormattingEnabled = true;
            this.ktComboBox1.Icon = null;
            this.ktComboBox1.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.ktComboBox1.IndicatorColor = System.Drawing.Color.Gray;
            this.ktComboBox1.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.ktComboBox1.ItemBackColor = System.Drawing.Color.White;
            this.ktComboBox1.ItemBorderColor = System.Drawing.Color.White;
            this.ktComboBox1.ItemForeColor = System.Drawing.Color.Black;
            this.ktComboBox1.ItemHeight = 26;
            this.ktComboBox1.ItemHighLightColor = System.Drawing.Color.BlueViolet;
            this.ktComboBox1.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ktComboBox1.Items.AddRange(new object[] {
            "Active",
            "NonActive"});
            this.ktComboBox1.ItemTopMargin = 3;
            this.ktComboBox1.Location = new System.Drawing.Point(358, 124);
            this.ktComboBox1.Name = "ktComboBox1";
            this.ktComboBox1.Size = new System.Drawing.Size(235, 32);
            this.ktComboBox1.TabIndex = 53;
            this.ktComboBox1.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.ktComboBox1.TextLeftMargin = 5;
            // 
            // ktComboBox2
            // 
            this.ktComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.ktComboBox2.BackgroundColor = System.Drawing.Color.White;
            this.ktComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.ktComboBox2.BorderRadius = 1;
            this.ktComboBox2.Color = System.Drawing.Color.Silver;
            this.ktComboBox2.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.ktComboBox2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ktComboBox2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ktComboBox2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ktComboBox2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ktComboBox2.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ktComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ktComboBox2.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.ktComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ktComboBox2.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.ktComboBox2.FillDropDown = true;
            this.ktComboBox2.FillIndicator = false;
            this.ktComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ktComboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ktComboBox2.ForeColor = System.Drawing.Color.Black;
            this.ktComboBox2.FormattingEnabled = true;
            this.ktComboBox2.Icon = null;
            this.ktComboBox2.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.ktComboBox2.IndicatorColor = System.Drawing.Color.Gray;
            this.ktComboBox2.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.ktComboBox2.ItemBackColor = System.Drawing.Color.White;
            this.ktComboBox2.ItemBorderColor = System.Drawing.Color.White;
            this.ktComboBox2.ItemForeColor = System.Drawing.Color.Black;
            this.ktComboBox2.ItemHeight = 26;
            this.ktComboBox2.ItemHighLightColor = System.Drawing.Color.BlueViolet;
            this.ktComboBox2.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ktComboBox2.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.ktComboBox2.ItemTopMargin = 3;
            this.ktComboBox2.Location = new System.Drawing.Point(32, 124);
            this.ktComboBox2.Name = "ktComboBox2";
            this.ktComboBox2.Size = new System.Drawing.Size(230, 32);
            this.ktComboBox2.TabIndex = 52;
            this.ktComboBox2.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.ktComboBox2.TextLeftMargin = 5;
            // 
            // ktButton1
            // 
            this.ktButton1.BackColor = System.Drawing.Color.Empty;
            this.ktButton1.BorderShape = KimTools.WinForms.KtSize.Default;
            this.ktButton1.BorderSize = KimTools.WinForms.KtSize.Default;
            this.ktButton1.CustomColors = new System.Drawing.Color[0];
            this.ktButton1.FlatAppearance.BorderSize = 0;
            this.ktButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ktButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ktButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ktButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ktButton1.IconName = "";
            this.ktButton1.IconSize = 16;
            this.ktButton1.IconStroke = 2.5D;
            this.ktButton1.Location = new System.Drawing.Point(493, 291);
            this.ktButton1.Name = "ktButton1";
            this.ktButton1.Size = new System.Drawing.Size(95, 37);
            this.ktButton1.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.ktButton1.TabIndex = 51;
            this.ktButton1.Text = "ADD";
            this.ktButton1.UseVisualStyleBackColor = false;
            // 
            // ktLabel9
            // 
            this.ktLabel9.AutoSize = true;
            this.ktLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel9.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel9.Location = new System.Drawing.Point(363, 96);
            this.ktLabel9.Name = "ktLabel9";
            this.ktLabel9.Size = new System.Drawing.Size(63, 25);
            this.ktLabel9.TabIndex = 50;
            this.ktLabel9.Text = "Status";
            // 
            // ktLabel10
            // 
            this.ktLabel10.AutoSize = true;
            this.ktLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel10.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel10.Location = new System.Drawing.Point(32, 96);
            this.ktLabel10.Name = "ktLabel10";
            this.ktLabel10.Size = new System.Drawing.Size(74, 25);
            this.ktLabel10.TabIndex = 49;
            this.ktLabel10.Text = "Gender";
            // 
            // ktTextBox7
            // 
            this.ktTextBox7.AcceptsReturn = false;
            this.ktTextBox7.AcceptsTab = false;
            this.ktTextBox7.AnimationSpeed = 200;
            this.ktTextBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox7.AutoSizeHeight = true;
            this.ktTextBox7.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox7.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox7.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox7.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox7.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox7.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox7.CustomIconLeft = null;
            this.ktTextBox7.CustomIconRight = null;
            this.ktTextBox7.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox7.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox7.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox7.HideSelection = true;
            this.ktTextBox7.Lines = new string[0];
            this.ktTextBox7.Location = new System.Drawing.Point(358, 56);
            this.ktTextBox7.MaxLength = 32767;
            this.ktTextBox7.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox7.Modified = false;
            this.ktTextBox7.Name = "ktTextBox7";
            this.ktTextBox7.Password = false;
            this.ktTextBox7.PasswordChar = '\0';
            this.ktTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox7.SelectedText = "";
            this.ktTextBox7.SelectionLength = 0;
            this.ktTextBox7.SelectionStart = 0;
            this.ktTextBox7.ShortcutsEnabled = true;
            this.ktTextBox7.Size = new System.Drawing.Size(235, 27);
            this.ktTextBox7.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox7.TabIndex = 48;
            this.ktTextBox7.TextMarginBottom = 0;
            this.ktTextBox7.TextPlaceholder = "Enter Last Name";
            // 
            // ktLabel11
            // 
            this.ktLabel11.AutoSize = true;
            this.ktLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel11.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel11.Location = new System.Drawing.Point(363, 28);
            this.ktLabel11.Name = "ktLabel11";
            this.ktLabel11.Size = new System.Drawing.Size(99, 25);
            this.ktLabel11.TabIndex = 47;
            this.ktLabel11.Text = "Last Name";
            // 
            // ktTextBox8
            // 
            this.ktTextBox8.AcceptsReturn = false;
            this.ktTextBox8.AcceptsTab = false;
            this.ktTextBox8.AnimationSpeed = 200;
            this.ktTextBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox8.AutoSizeHeight = true;
            this.ktTextBox8.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox8.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox8.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox8.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox8.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox8.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox8.CustomIconLeft = null;
            this.ktTextBox8.CustomIconRight = null;
            this.ktTextBox8.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox8.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox8.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox8.HideSelection = true;
            this.ktTextBox8.Lines = new string[0];
            this.ktTextBox8.Location = new System.Drawing.Point(32, 56);
            this.ktTextBox8.MaxLength = 32767;
            this.ktTextBox8.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox8.Modified = false;
            this.ktTextBox8.Name = "ktTextBox8";
            this.ktTextBox8.Password = false;
            this.ktTextBox8.PasswordChar = '\0';
            this.ktTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox8.SelectedText = "";
            this.ktTextBox8.SelectionLength = 0;
            this.ktTextBox8.SelectionStart = 0;
            this.ktTextBox8.ShortcutsEnabled = true;
            this.ktTextBox8.Size = new System.Drawing.Size(230, 27);
            this.ktTextBox8.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox8.TabIndex = 46;
            this.ktTextBox8.TextMarginBottom = 0;
            this.ktTextBox8.TextPlaceholder = "Enter First Name";
            // 
            // ktLabel12
            // 
            this.ktLabel12.AutoSize = true;
            this.ktLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel12.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel12.Location = new System.Drawing.Point(32, 28);
            this.ktLabel12.Name = "ktLabel12";
            this.ktLabel12.Size = new System.Drawing.Size(102, 25);
            this.ktLabel12.TabIndex = 45;
            this.ktLabel12.Text = "First Name";
            // 
            // ktButton2
            // 
            this.ktButton2.BackColor = System.Drawing.Color.Empty;
            this.ktButton2.BorderShape = KimTools.WinForms.KtSize.Default;
            this.ktButton2.BorderSize = KimTools.WinForms.KtSize.Default;
            this.ktButton2.CustomColors = new System.Drawing.Color[0];
            this.ktButton2.FlatAppearance.BorderSize = 0;
            this.ktButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ktButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ktButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ktButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ktButton2.IconName = "";
            this.ktButton2.IconSize = 16;
            this.ktButton2.IconStroke = 2.5D;
            this.ktButton2.Location = new System.Drawing.Point(493, 291);
            this.ktButton2.Name = "ktButton2";
            this.ktButton2.Size = new System.Drawing.Size(95, 37);
            this.ktButton2.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.ktButton2.TabIndex = 51;
            this.ktButton2.Text = "ADD";
            this.ktButton2.UseVisualStyleBackColor = false;
            // 
            // ktTextBox11
            // 
            this.ktTextBox11.AcceptsReturn = false;
            this.ktTextBox11.AcceptsTab = false;
            this.ktTextBox11.AnimationSpeed = 200;
            this.ktTextBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox11.AutoSizeHeight = true;
            this.ktTextBox11.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox11.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox11.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox11.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox11.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox11.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox11.CustomIconLeft = null;
            this.ktTextBox11.CustomIconRight = null;
            this.ktTextBox11.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox11.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox11.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox11.HideSelection = true;
            this.ktTextBox11.Lines = new string[0];
            this.ktTextBox11.Location = new System.Drawing.Point(358, 56);
            this.ktTextBox11.MaxLength = 32767;
            this.ktTextBox11.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox11.Modified = false;
            this.ktTextBox11.Name = "ktTextBox11";
            this.ktTextBox11.Password = true;
            this.ktTextBox11.PasswordChar = '\0';
            this.ktTextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox11.SelectedText = "";
            this.ktTextBox11.SelectionLength = 0;
            this.ktTextBox11.SelectionStart = 0;
            this.ktTextBox11.ShortcutsEnabled = true;
            this.ktTextBox11.Size = new System.Drawing.Size(235, 27);
            this.ktTextBox11.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox11.TabIndex = 48;
            this.ktTextBox11.TextMarginBottom = 0;
            this.ktTextBox11.TextPlaceholder = "Enter Password";
            // 
            // ktLabel17
            // 
            this.ktLabel17.AutoSize = true;
            this.ktLabel17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel17.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel17.Location = new System.Drawing.Point(363, 28);
            this.ktLabel17.Name = "ktLabel17";
            this.ktLabel17.Size = new System.Drawing.Size(108, 30);
            this.ktLabel17.TabIndex = 47;
            this.ktLabel17.Text = "Password";
            // 
            // ktTextBox12
            // 
            this.ktTextBox12.AcceptsReturn = false;
            this.ktTextBox12.AcceptsTab = false;
            this.ktTextBox12.AnimationSpeed = 200;
            this.ktTextBox12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox12.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox12.AutoSizeHeight = true;
            this.ktTextBox12.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox12.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox12.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox12.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox12.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox12.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox12.CustomIconLeft = null;
            this.ktTextBox12.CustomIconRight = null;
            this.ktTextBox12.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox12.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox12.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox12.HideSelection = true;
            this.ktTextBox12.Lines = new string[0];
            this.ktTextBox12.Location = new System.Drawing.Point(32, 56);
            this.ktTextBox12.MaxLength = 32767;
            this.ktTextBox12.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox12.Modified = false;
            this.ktTextBox12.Name = "ktTextBox12";
            this.ktTextBox12.Password = false;
            this.ktTextBox12.PasswordChar = '\0';
            this.ktTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox12.SelectedText = "";
            this.ktTextBox12.SelectionLength = 0;
            this.ktTextBox12.SelectionStart = 0;
            this.ktTextBox12.ShortcutsEnabled = true;
            this.ktTextBox12.Size = new System.Drawing.Size(230, 27);
            this.ktTextBox12.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox12.TabIndex = 46;
            this.ktTextBox12.TextMarginBottom = 0;
            this.ktTextBox12.TextPlaceholder = "Enter UserName";
            // 
            // ktLabel18
            // 
            this.ktLabel18.AutoSize = true;
            this.ktLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel18.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel18.Location = new System.Drawing.Point(32, 28);
            this.ktLabel18.Name = "ktLabel18";
            this.ktLabel18.Size = new System.Drawing.Size(99, 25);
            this.ktLabel18.TabIndex = 45;
            this.ktLabel18.Text = "UserName";
            // 
            // ktTextBox13
            // 
            this.ktTextBox13.AcceptsReturn = false;
            this.ktTextBox13.AcceptsTab = false;
            this.ktTextBox13.AnimationSpeed = 200;
            this.ktTextBox13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox13.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox13.AutoSizeHeight = true;
            this.ktTextBox13.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox13.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ktTextBox13.CustomBorderColor = System.Drawing.Color.Empty;
            this.ktTextBox13.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ktTextBox13.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ktTextBox13.CustomFillColor = System.Drawing.Color.Empty;
            this.ktTextBox13.CustomIconLeft = null;
            this.ktTextBox13.CustomIconRight = null;
            this.ktTextBox13.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ktTextBox13.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktTextBox13.ForeColor = System.Drawing.Color.Empty;
            this.ktTextBox13.HideSelection = true;
            this.ktTextBox13.Lines = new string[0];
            this.ktTextBox13.Location = new System.Drawing.Point(32, 270);
            this.ktTextBox13.MaxLength = 32767;
            this.ktTextBox13.MinimumSize = new System.Drawing.Size(1, 1);
            this.ktTextBox13.Modified = false;
            this.ktTextBox13.Name = "ktTextBox13";
            this.ktTextBox13.Password = false;
            this.ktTextBox13.PasswordChar = '\0';
            this.ktTextBox13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktTextBox13.SelectedText = "";
            this.ktTextBox13.SelectionLength = 0;
            this.ktTextBox13.SelectionStart = 0;
            this.ktTextBox13.ShortcutsEnabled = true;
            this.ktTextBox13.Size = new System.Drawing.Size(230, 27);
            this.ktTextBox13.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox13.TabIndex = 59;
            this.ktTextBox13.TextMarginBottom = 0;
            this.ktTextBox13.TextPlaceholder = "Enter Teacher Salary";
            // 
            // ktLabel19
            // 
            this.ktLabel19.AutoSize = true;
            this.ktLabel19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel19.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel19.Location = new System.Drawing.Point(32, 242);
            this.ktLabel19.Name = "ktLabel19";
            this.ktLabel19.Size = new System.Drawing.Size(62, 25);
            this.ktLabel19.TabIndex = 58;
            this.ktLabel19.Text = "Salary";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 461);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.Opacity = 1D;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "ADD USER";
            this.top.ResumeLayout(false);
            this.Pages.ResumeLayout(false);
            this.Student.ResumeLayout(false);
            this.Student.PerformLayout();
            this.Teacher.ResumeLayout(false);
            this.Teacher.PerformLayout();
            this.Admin.ResumeLayout(false);
            this.Admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private KimTools.WinForms.KtButton StSwBtn;
        private KimTools.WinForms.KtButton AdSwBtn;
        private KimTools.WinForms.KtButton tcSwBtn;
        private KimTools.WinForms.KtPages Pages;
        private System.Windows.Forms.TabPage Student;
        private System.Windows.Forms.TabPage Teacher;
        private System.Windows.Forms.TabPage Admin;
        private KimTools.WinForms.KtButton ktButton3;
        private KimTools.WinForms.KtLabel ktLabel3;
        private KimTools.WinForms.KtLabel ktLabel4;
        private KimTools.WinForms.KtTextBox ktTextBox5;
        private KimTools.WinForms.KtLabel ktLabel5;
        private KimTools.WinForms.KtTextBox ktTextBox6;
        private KimTools.WinForms.KtLabel ktLabel6;
        private KimTools.WinForms.KtComboBox GenderCmb;
        private KimTools.WinForms.KtComboBox StudentStatusCmb;
        private KimTools.WinForms.KtTextBox ktTextBox1;
        private KimTools.WinForms.KtLabel ktLabel1;
        private KimTools.WinForms.KtTextBox ktTextBox2;
        private KimTools.WinForms.KtLabel ktLabel2;
        private KimTools.WinForms.KtTextBox ktTextBox13;
        private KimTools.WinForms.KtLabel ktLabel19;
        private KimTools.WinForms.KtTextBox ktTextBox3;
        private KimTools.WinForms.KtLabel ktLabel7;
        private KimTools.WinForms.KtTextBox ktTextBox4;
        private KimTools.WinForms.KtLabel ktLabel8;
        private KimTools.WinForms.KtComboBox ktComboBox1;
        private KimTools.WinForms.KtComboBox ktComboBox2;
        private KimTools.WinForms.KtButton ktButton1;
        private KimTools.WinForms.KtLabel ktLabel9;
        private KimTools.WinForms.KtLabel ktLabel10;
        private KimTools.WinForms.KtTextBox ktTextBox7;
        private KimTools.WinForms.KtLabel ktLabel11;
        private KimTools.WinForms.KtTextBox ktTextBox8;
        private KimTools.WinForms.KtLabel ktLabel12;
        private KimTools.WinForms.KtButton ktButton2;
        private KimTools.WinForms.KtTextBox ktTextBox11;
        private KimTools.WinForms.KtLabel ktLabel17;
        private KimTools.WinForms.KtTextBox ktTextBox12;
        private KimTools.WinForms.KtLabel ktLabel18;
    }
}