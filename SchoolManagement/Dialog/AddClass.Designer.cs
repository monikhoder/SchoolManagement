namespace SchoolManagement.Dialog
{
    partial class AddClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClass));
            this.ktLabel5 = new KimTools.WinForms.KtLabel();
            this.ClassnameTxb = new KimTools.WinForms.KtTextBox();
            this.ktLabel6 = new KimTools.WinForms.KtLabel();
            this.ClassStartDate = new KimTools.WinForms.KtDate();
            this.AddClassBtn = new KimTools.WinForms.KtButton();
            this.ClassEndDate = new KimTools.WinForms.KtDate();
            this.ktLabel1 = new KimTools.WinForms.KtLabel();
            this.SuspendLayout();
            // 
            // ktLabel5
            // 
            this.ktLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktLabel5.AutoSize = true;
            this.ktLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel5.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel5.Location = new System.Drawing.Point(40, 120);
            this.ktLabel5.Name = "ktLabel5";
            this.ktLabel5.Size = new System.Drawing.Size(98, 25);
            this.ktLabel5.TabIndex = 41;
            this.ktLabel5.Text = "Class Start";
            this.ktLabel5.Click += new System.EventHandler(this.ktLabel5_Click);
            // 
            // ClassnameTxb
            // 
            this.ClassnameTxb.AcceptsReturn = false;
            this.ClassnameTxb.AcceptsTab = false;
            this.ClassnameTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassnameTxb.AnimationSpeed = 200;
            this.ClassnameTxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ClassnameTxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ClassnameTxb.AutoSizeHeight = true;
            this.ClassnameTxb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClassnameTxb.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ClassnameTxb.Border = KimTools.WinForms.KtColor.Tailwind_White;
            this.ClassnameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClassnameTxb.CustomBorderColor = System.Drawing.Color.Empty;
            this.ClassnameTxb.CustomBorderColorActive = System.Drawing.Color.Empty;
            this.ClassnameTxb.CustomBorderColorDisabled = System.Drawing.Color.Empty;
            this.ClassnameTxb.CustomFillColor = System.Drawing.Color.Empty;
            this.ClassnameTxb.CustomIconLeft = null;
            this.ClassnameTxb.CustomIconRight = null;
            this.ClassnameTxb.CustomPlaceholderColor = System.Drawing.Color.Empty;
            this.ClassnameTxb.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ClassnameTxb.ForeColor = System.Drawing.Color.Empty;
            this.ClassnameTxb.HideSelection = true;
            this.ClassnameTxb.Lines = new string[0];
            this.ClassnameTxb.Location = new System.Drawing.Point(153, 56);
            this.ClassnameTxb.MaxLength = 32767;
            this.ClassnameTxb.MinimumSize = new System.Drawing.Size(1, 1);
            this.ClassnameTxb.Modified = false;
            this.ClassnameTxb.Name = "ClassnameTxb";
            this.ClassnameTxb.Password = false;
            this.ClassnameTxb.PasswordChar = '\0';
            this.ClassnameTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClassnameTxb.SelectedText = "";
            this.ClassnameTxb.SelectionLength = 0;
            this.ClassnameTxb.SelectionStart = 0;
            this.ClassnameTxb.ShortcutsEnabled = true;
            this.ClassnameTxb.Size = new System.Drawing.Size(230, 38);
            this.ClassnameTxb.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ClassnameTxb.TabIndex = 40;
            this.ClassnameTxb.TextMarginBottom = 0;
            this.ClassnameTxb.TextPlaceholder = "Enter Class Name";
            this.ClassnameTxb.TextChange += new System.EventHandler(this.ClassnameTxb_TextChange);
            this.ClassnameTxb.TextChanged += new System.EventHandler(this.ktTextBox6_TextChanged);
            // 
            // ktLabel6
            // 
            this.ktLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktLabel6.AutoSize = true;
            this.ktLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel6.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel6.Location = new System.Drawing.Point(40, 60);
            this.ktLabel6.Name = "ktLabel6";
            this.ktLabel6.Size = new System.Drawing.Size(107, 25);
            this.ktLabel6.TabIndex = 39;
            this.ktLabel6.Text = "Class Name";
            // 
            // ClassStartDate
            // 
            this.ClassStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassStartDate.BackColor = System.Drawing.Color.Transparent;
            this.ClassStartDate.BorderRadius = 1;
            this.ClassStartDate.Color = System.Drawing.Color.Silver;
            this.ClassStartDate.DateBorderThickness = KimTools.WinForms.KtDate.BorderThickness.Thin;
            this.ClassStartDate.DateTextAlign = KimTools.WinForms.KtDate.TextAlign.Left;
            this.ClassStartDate.DisabledColor = System.Drawing.Color.Gray;
            this.ClassStartDate.DisplayWeekNumbers = false;
            this.ClassStartDate.DPHeight = 0;
            this.ClassStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ClassStartDate.FillDatePicker = false;
            this.ClassStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClassStartDate.ForeColor = System.Drawing.Color.Black;
            this.ClassStartDate.Icon = ((System.Drawing.Image)(resources.GetObject("ClassStartDate.Icon")));
            this.ClassStartDate.IconColor = System.Drawing.Color.Gray;
            this.ClassStartDate.IconLocation = KimTools.WinForms.KtDate.Indicator.Right;
            this.ClassStartDate.LeftTextMargin = 5;
            this.ClassStartDate.Location = new System.Drawing.Point(153, 113);
            this.ClassStartDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.ClassStartDate.Name = "ClassStartDate";
            this.ClassStartDate.Size = new System.Drawing.Size(230, 32);
            this.ClassStartDate.TabIndex = 52;
            this.ClassStartDate.ValueChanged += new System.EventHandler(this.ClassnameTxb_TextChange);
            // 
            // AddClassBtn
            // 
            this.AddClassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddClassBtn.BackColor = System.Drawing.Color.Empty;
            this.AddClassBtn.BorderShape = KimTools.WinForms.KtSize.Default;
            this.AddClassBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.AddClassBtn.CustomColors = new System.Drawing.Color[0];
            this.AddClassBtn.Enabled = false;
            this.AddClassBtn.FlatAppearance.BorderSize = 0;
            this.AddClassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddClassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClassBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddClassBtn.IconName = "";
            this.AddClassBtn.IconSize = 16;
            this.AddClassBtn.IconStroke = 2.5D;
            this.AddClassBtn.Location = new System.Drawing.Point(404, 232);
            this.AddClassBtn.Name = "AddClassBtn";
            this.AddClassBtn.Size = new System.Drawing.Size(117, 38);
            this.AddClassBtn.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.AddClassBtn.TabIndex = 53;
            this.AddClassBtn.Text = "ADD";
            this.AddClassBtn.UseVisualStyleBackColor = false;
            this.AddClassBtn.Click += new System.EventHandler(this.AddClassBtn_Click);
            // 
            // ClassEndDate
            // 
            this.ClassEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassEndDate.BackColor = System.Drawing.Color.Transparent;
            this.ClassEndDate.BorderRadius = 1;
            this.ClassEndDate.Color = System.Drawing.Color.Silver;
            this.ClassEndDate.DateBorderThickness = KimTools.WinForms.KtDate.BorderThickness.Thin;
            this.ClassEndDate.DateTextAlign = KimTools.WinForms.KtDate.TextAlign.Left;
            this.ClassEndDate.DisabledColor = System.Drawing.Color.Gray;
            this.ClassEndDate.DisplayWeekNumbers = false;
            this.ClassEndDate.DPHeight = 0;
            this.ClassEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ClassEndDate.FillDatePicker = false;
            this.ClassEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClassEndDate.ForeColor = System.Drawing.Color.Black;
            this.ClassEndDate.Icon = ((System.Drawing.Image)(resources.GetObject("ClassEndDate.Icon")));
            this.ClassEndDate.IconColor = System.Drawing.Color.Gray;
            this.ClassEndDate.IconLocation = KimTools.WinForms.KtDate.Indicator.Right;
            this.ClassEndDate.LeftTextMargin = 5;
            this.ClassEndDate.Location = new System.Drawing.Point(153, 175);
            this.ClassEndDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.ClassEndDate.Name = "ClassEndDate";
            this.ClassEndDate.Size = new System.Drawing.Size(230, 32);
            this.ClassEndDate.TabIndex = 55;
            this.ClassEndDate.ValueChanged += new System.EventHandler(this.ClassnameTxb_TextChange);
            // 
            // ktLabel1
            // 
            this.ktLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktLabel1.AutoSize = true;
            this.ktLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ktLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel1.KtFontSize = KimTools.WinForms.KtFont.Default;
            this.ktLabel1.Location = new System.Drawing.Point(40, 182);
            this.ktLabel1.Name = "ktLabel1";
            this.ktLabel1.Size = new System.Drawing.Size(98, 25);
            this.ktLabel1.TabIndex = 54;
            this.ktLabel1.Text = "Class Start";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 286);
            this.Controls.Add(this.ClassEndDate);
            this.Controls.Add(this.ktLabel1);
            this.Controls.Add(this.AddClassBtn);
            this.Controls.Add(this.ClassStartDate);
            this.Controls.Add(this.ClassnameTxb);
            this.Controls.Add(this.ktLabel5);
            this.Controls.Add(this.ktLabel6);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClass";
            this.Opacity = 1D;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Role = KimTools.WinForms.KtColor.Tailwind_White;
            this.Text = "AddClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KimTools.WinForms.KtLabel ktLabel5;
        private KimTools.WinForms.KtTextBox ClassnameTxb;
        private KimTools.WinForms.KtLabel ktLabel6;
        private KimTools.WinForms.KtDate ClassStartDate;
        private KimTools.WinForms.KtButton AddClassBtn;
        private KimTools.WinForms.KtDate ClassEndDate;
        private KimTools.WinForms.KtLabel ktLabel1;
    }
}