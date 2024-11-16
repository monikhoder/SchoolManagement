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
            this.ktTextBox6 = new KimTools.WinForms.KtTextBox();
            this.ktLabel6 = new KimTools.WinForms.KtLabel();
            this.ktDate1 = new KimTools.WinForms.KtDate();
            this.ktButton3 = new KimTools.WinForms.KtButton();
            this.ktDate2 = new KimTools.WinForms.KtDate();
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
            // ktTextBox6
            // 
            this.ktTextBox6.AcceptsReturn = false;
            this.ktTextBox6.AcceptsTab = false;
            this.ktTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktTextBox6.AnimationSpeed = 200;
            this.ktTextBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktTextBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktTextBox6.AutoSizeHeight = true;
            this.ktTextBox6.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ktTextBox6.Bg = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktTextBox6.Border = KimTools.WinForms.KtColor.Tailwind_White;
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
            this.ktTextBox6.Location = new System.Drawing.Point(153, 56);
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
            this.ktTextBox6.Size = new System.Drawing.Size(230, 38);
            this.ktTextBox6.Style = KimTools.WinForms.KtTextBox.KtTextBoxStyle.Tailwind;
            this.ktTextBox6.TabIndex = 40;
            this.ktTextBox6.TextMarginBottom = 0;
            this.ktTextBox6.TextPlaceholder = "Enter Class Name";
            this.ktTextBox6.TextChanged += new System.EventHandler(this.ktTextBox6_TextChanged);
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
            // ktDate1
            // 
            this.ktDate1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktDate1.BackColor = System.Drawing.Color.Transparent;
            this.ktDate1.BorderRadius = 1;
            this.ktDate1.Color = System.Drawing.Color.Silver;
            this.ktDate1.DateBorderThickness = KimTools.WinForms.KtDate.BorderThickness.Thin;
            this.ktDate1.DateTextAlign = KimTools.WinForms.KtDate.TextAlign.Left;
            this.ktDate1.DisabledColor = System.Drawing.Color.Gray;
            this.ktDate1.DisplayWeekNumbers = false;
            this.ktDate1.DPHeight = 0;
            this.ktDate1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ktDate1.FillDatePicker = false;
            this.ktDate1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ktDate1.ForeColor = System.Drawing.Color.Black;
            this.ktDate1.Icon = ((System.Drawing.Image)(resources.GetObject("ktDate1.Icon")));
            this.ktDate1.IconColor = System.Drawing.Color.Gray;
            this.ktDate1.IconLocation = KimTools.WinForms.KtDate.Indicator.Right;
            this.ktDate1.LeftTextMargin = 5;
            this.ktDate1.Location = new System.Drawing.Point(153, 113);
            this.ktDate1.MinimumSize = new System.Drawing.Size(4, 32);
            this.ktDate1.Name = "ktDate1";
            this.ktDate1.Size = new System.Drawing.Size(230, 32);
            this.ktDate1.TabIndex = 52;
            this.ktDate1.ValueChanged += new System.EventHandler(this.ktDate1_ValueChanged);
            // 
            // ktButton3
            // 
            this.ktButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.ktButton3.Location = new System.Drawing.Point(404, 232);
            this.ktButton3.Name = "ktButton3";
            this.ktButton3.Size = new System.Drawing.Size(117, 38);
            this.ktButton3.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.ktButton3.TabIndex = 53;
            this.ktButton3.Text = "ADD";
            this.ktButton3.UseVisualStyleBackColor = false;
            // 
            // ktDate2
            // 
            this.ktDate2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktDate2.BackColor = System.Drawing.Color.Transparent;
            this.ktDate2.BorderRadius = 1;
            this.ktDate2.Color = System.Drawing.Color.Silver;
            this.ktDate2.DateBorderThickness = KimTools.WinForms.KtDate.BorderThickness.Thin;
            this.ktDate2.DateTextAlign = KimTools.WinForms.KtDate.TextAlign.Left;
            this.ktDate2.DisabledColor = System.Drawing.Color.Gray;
            this.ktDate2.DisplayWeekNumbers = false;
            this.ktDate2.DPHeight = 0;
            this.ktDate2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ktDate2.FillDatePicker = false;
            this.ktDate2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ktDate2.ForeColor = System.Drawing.Color.Black;
            this.ktDate2.Icon = ((System.Drawing.Image)(resources.GetObject("ktDate2.Icon")));
            this.ktDate2.IconColor = System.Drawing.Color.Gray;
            this.ktDate2.IconLocation = KimTools.WinForms.KtDate.Indicator.Right;
            this.ktDate2.LeftTextMargin = 5;
            this.ktDate2.Location = new System.Drawing.Point(153, 175);
            this.ktDate2.MinimumSize = new System.Drawing.Size(4, 32);
            this.ktDate2.Name = "ktDate2";
            this.ktDate2.Size = new System.Drawing.Size(230, 32);
            this.ktDate2.TabIndex = 55;
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
            this.Controls.Add(this.ktDate2);
            this.Controls.Add(this.ktLabel1);
            this.Controls.Add(this.ktButton3);
            this.Controls.Add(this.ktDate1);
            this.Controls.Add(this.ktTextBox6);
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
        private KimTools.WinForms.KtTextBox ktTextBox6;
        private KimTools.WinForms.KtLabel ktLabel6;
        private KimTools.WinForms.KtDate ktDate1;
        private KimTools.WinForms.KtButton ktButton3;
        private KimTools.WinForms.KtDate ktDate2;
        private KimTools.WinForms.KtLabel ktLabel1;
    }
}