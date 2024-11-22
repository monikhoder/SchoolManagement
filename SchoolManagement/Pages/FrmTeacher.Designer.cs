namespace SchoolManagement.Pages
{
    partial class FrmTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeacher));
            this.MenuTooltips = new KimTools.WinForms.KtTooltips(this.components);
            this.TopBarPanel = new KimTools.WinForms.KtPanel();
            this.PageLbl = new KimTools.WinForms.KtLabel();
            this.Icons = new KimTools.WinForms.KtIcons();
            this.ktLabelLogout = new KimTools.WinForms.KtLabel();
            this.ktLabelUsername = new KimTools.WinForms.KtLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ktcmbClassSubject = new KimTools.WinForms.KtComboBox();
            this.ktLabel1 = new KimTools.WinForms.KtLabel();
            this.ktComboBox2 = new KimTools.WinForms.KtComboBox();
            this.ktLabel2 = new KimTools.WinForms.KtLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TopBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTooltips
            // 
            this.MenuTooltips.Active = true;
            this.MenuTooltips.AllowAutoClose = false;
            this.MenuTooltips.AllowFading = true;
            this.MenuTooltips.AutoCloseDuration = 5000;
            this.MenuTooltips.ClickToShowDisplayControl = false;
            this.MenuTooltips.DisplayControl = null;
            this.MenuTooltips.EntryAnimationSpeed = 350;
            this.MenuTooltips.ExitAnimationSpeed = 200;
            this.MenuTooltips.GenerateAutoCloseDuration = false;
            this.MenuTooltips.IconMargin = 6;
            this.MenuTooltips.InitialDelay = 0;
            this.MenuTooltips.Name = "MenuTooltips";
            this.MenuTooltips.Opacity = 1D;
            this.MenuTooltips.Padding = new System.Windows.Forms.Padding(10);
            this.MenuTooltips.ReshowDelay = 100;
            this.MenuTooltips.ShowAlways = true;
            this.MenuTooltips.ShowBorders = false;
            this.MenuTooltips.ShowIcons = true;
            this.MenuTooltips.ShowShadows = true;
            this.MenuTooltips.Tag = null;
            this.MenuTooltips.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.MenuTooltips.TextMargin = 2;
            this.MenuTooltips.ToolTipPosition = new System.Drawing.Point(0, 0);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.TopBarPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(63)))), ((int)(((byte)(218)))));
            this.TopBarPanel.Bg = KimTools.WinForms.KtColor.Primary;
            this.TopBarPanel.BgOpacity = 255;
            this.TopBarPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.TopBarPanel.BorderOpacity = 255;
            this.TopBarPanel.BorderRadiusSize = 15;
            this.TopBarPanel.BorderShape = KimTools.WinForms.KtSize.Default;
            this.TopBarPanel.BorderSize = KimTools.WinForms.KtSize.Default;
            this.TopBarPanel.BorderThickness = 1;
            this.TopBarPanel.Controls.Add(this.ktLabelUsername);
            this.TopBarPanel.Controls.Add(this.ktLabelLogout);
            this.TopBarPanel.Controls.Add(this.PageLbl);
            this.TopBarPanel.CustomColors = new System.Drawing.Color[0];
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.ForeColor = System.Drawing.Color.White;
            this.Icons.SetIcons(this.TopBarPanel, new KimTools.WinForms.KtIcon[0]);
            this.TopBarPanel.Location = new System.Drawing.Point(10, 10);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.ShowBorders = true;
            this.TopBarPanel.Size = new System.Drawing.Size(967, 56);
            this.TopBarPanel.TabIndex = 2;
            this.MenuTooltips.SetToolTip(this.TopBarPanel, "");
            // 
            // PageLbl
            // 
            this.PageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PageLbl.AutoSize = true;
            this.PageLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.PageLbl.ForeColor = System.Drawing.Color.White;
            this.Icons.SetIcons(this.PageLbl, new KimTools.WinForms.KtIcon[0]);
            this.PageLbl.KtFontSize = KimTools.WinForms.KtFont.H2;
            this.PageLbl.LabelColor = KimTools.WinForms.KtColor.Tailwind_White;
            this.PageLbl.Location = new System.Drawing.Point(24, 14);
            this.PageLbl.Name = "PageLbl";
            this.PageLbl.Size = new System.Drawing.Size(92, 25);
            this.PageLbl.TabIndex = 0;
            this.PageLbl.Text = "Welcome";
            this.MenuTooltips.SetToolTip(this.PageLbl, "");
            // 
            // Icons
            // 
            this.Icons.Icon = "Hero.outline.user-group";
            this.Icons.IconColor = System.Drawing.Color.White;
            this.Icons.IconPadding = 0;
            this.Icons.IconSize = 128;
            this.Icons.ImageListBinding = null;
            this.Icons.Property = null;
            this.Icons.Stroke = 1D;
            // 
            // ktLabelLogout
            // 
            this.ktLabelLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktLabelLogout.AutoSize = true;
            this.ktLabelLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.ktLabelLogout.ForeColor = System.Drawing.Color.White;
            this.Icons.SetIcons(this.ktLabelLogout, new KimTools.WinForms.KtIcon[0]);
            this.ktLabelLogout.KtFontSize = KimTools.WinForms.KtFont.H2;
            this.ktLabelLogout.LabelColor = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktLabelLogout.Location = new System.Drawing.Point(879, 14);
            this.ktLabelLogout.Name = "ktLabelLogout";
            this.ktLabelLogout.Size = new System.Drawing.Size(72, 25);
            this.ktLabelLogout.TabIndex = 3;
            this.ktLabelLogout.Text = "Logout";
            this.MenuTooltips.SetToolTip(this.ktLabelLogout, "");
            this.ktLabelLogout.Click += new System.EventHandler(this.ktLabelLogout_Click);
            // 
            // ktLabelUsername
            // 
            this.ktLabelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktLabelUsername.AutoSize = true;
            this.ktLabelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.ktLabelUsername.ForeColor = System.Drawing.Color.White;
            this.Icons.SetIcons(this.ktLabelUsername, new KimTools.WinForms.KtIcon[0]);
            this.ktLabelUsername.KtFontSize = KimTools.WinForms.KtFont.H2;
            this.ktLabelUsername.LabelColor = KimTools.WinForms.KtColor.Tailwind_White;
            this.ktLabelUsername.Location = new System.Drawing.Point(132, 14);
            this.ktLabelUsername.Name = "ktLabelUsername";
            this.ktLabelUsername.Size = new System.Drawing.Size(98, 25);
            this.ktLabelUsername.TabIndex = 4;
            this.ktLabelUsername.Text = "Username";
            this.MenuTooltips.SetToolTip(this.ktLabelUsername, "");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.ktLabel2);
            this.panel1.Controls.Add(this.ktComboBox2);
            this.panel1.Controls.Add(this.ktLabel1);
            this.panel1.Controls.Add(this.ktcmbClassSubject);
            this.Icons.SetIcons(this.panel1, new KimTools.WinForms.KtIcon[0]);
            this.panel1.Location = new System.Drawing.Point(13, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 330);
            this.panel1.TabIndex = 3;
            this.MenuTooltips.SetToolTip(this.panel1, "");
            // 
            // ktcmbClassSubject
            // 
            this.ktcmbClassSubject.BackColor = System.Drawing.Color.Transparent;
            this.ktcmbClassSubject.BackgroundColor = System.Drawing.Color.White;
            this.ktcmbClassSubject.BorderColor = System.Drawing.Color.Silver;
            this.ktcmbClassSubject.BorderRadius = 1;
            this.ktcmbClassSubject.Color = System.Drawing.Color.Silver;
            this.ktcmbClassSubject.Direction = KimTools.WinForms.KtComboBox.Directions.Down;
            this.ktcmbClassSubject.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ktcmbClassSubject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ktcmbClassSubject.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ktcmbClassSubject.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ktcmbClassSubject.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ktcmbClassSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ktcmbClassSubject.DropdownBorderThickness = KimTools.WinForms.KtComboBox.BorderThickness.Thin;
            this.ktcmbClassSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ktcmbClassSubject.DropDownTextAlign = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.ktcmbClassSubject.FillDropDown = true;
            this.ktcmbClassSubject.FillIndicator = false;
            this.ktcmbClassSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ktcmbClassSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ktcmbClassSubject.ForeColor = System.Drawing.Color.Black;
            this.ktcmbClassSubject.FormattingEnabled = true;
            this.ktcmbClassSubject.Icon = null;
            this.Icons.SetIcons(this.ktcmbClassSubject, new KimTools.WinForms.KtIcon[0]);
            this.ktcmbClassSubject.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.ktcmbClassSubject.IndicatorColor = System.Drawing.Color.Gray;
            this.ktcmbClassSubject.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.ktcmbClassSubject.ItemBackColor = System.Drawing.Color.White;
            this.ktcmbClassSubject.ItemBorderColor = System.Drawing.Color.White;
            this.ktcmbClassSubject.ItemForeColor = System.Drawing.Color.Black;
            this.ktcmbClassSubject.ItemHeight = 26;
            this.ktcmbClassSubject.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ktcmbClassSubject.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ktcmbClassSubject.ItemTopMargin = 3;
            this.ktcmbClassSubject.Location = new System.Drawing.Point(132, 17);
            this.ktcmbClassSubject.Name = "ktcmbClassSubject";
            this.ktcmbClassSubject.Size = new System.Drawing.Size(292, 32);
            this.ktcmbClassSubject.TabIndex = 0;
            this.ktcmbClassSubject.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.ktcmbClassSubject.TextLeftMargin = 5;
            this.MenuTooltips.SetToolTip(this.ktcmbClassSubject, "");
            // 
            // ktLabel1
            // 
            this.ktLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktLabel1.AutoSize = true;
            this.ktLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ktLabel1.ForeColor = System.Drawing.Color.Black;
            this.Icons.SetIcons(this.ktLabel1, new KimTools.WinForms.KtIcon[0]);
            this.ktLabel1.KtFontSize = KimTools.WinForms.KtFont.H3;
            this.ktLabel1.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.ktLabel1.Location = new System.Drawing.Point(21, 22);
            this.ktLabel1.Name = "ktLabel1";
            this.ktLabel1.Size = new System.Drawing.Size(105, 21);
            this.ktLabel1.TabIndex = 1;
            this.ktLabel1.Text = "Class Subject";
            this.MenuTooltips.SetToolTip(this.ktLabel1, "");
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
            this.Icons.SetIcons(this.ktComboBox2, new KimTools.WinForms.KtIcon[0]);
            this.ktComboBox2.IndicatorAlignment = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.ktComboBox2.IndicatorColor = System.Drawing.Color.Gray;
            this.ktComboBox2.IndicatorLocation = KimTools.WinForms.KtComboBox.Indicator.Right;
            this.ktComboBox2.ItemBackColor = System.Drawing.Color.White;
            this.ktComboBox2.ItemBorderColor = System.Drawing.Color.White;
            this.ktComboBox2.ItemForeColor = System.Drawing.Color.Black;
            this.ktComboBox2.ItemHeight = 26;
            this.ktComboBox2.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ktComboBox2.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ktComboBox2.ItemTopMargin = 3;
            this.ktComboBox2.Location = new System.Drawing.Point(132, 71);
            this.ktComboBox2.Name = "ktComboBox2";
            this.ktComboBox2.Size = new System.Drawing.Size(295, 32);
            this.ktComboBox2.TabIndex = 2;
            this.ktComboBox2.TextAlignment = KimTools.WinForms.KtComboBox.TextAlign.Left;
            this.ktComboBox2.TextLeftMargin = 5;
            this.MenuTooltips.SetToolTip(this.ktComboBox2, "");
            // 
            // ktLabel2
            // 
            this.ktLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ktLabel2.AutoSize = true;
            this.ktLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ktLabel2.ForeColor = System.Drawing.Color.Black;
            this.Icons.SetIcons(this.ktLabel2, new KimTools.WinForms.KtIcon[0]);
            this.ktLabel2.KtFontSize = KimTools.WinForms.KtFont.H3;
            this.ktLabel2.LabelColor = KimTools.WinForms.KtColor.Tailwind_Black;
            this.ktLabel2.Location = new System.Drawing.Point(56, 72);
            this.ktLabel2.Name = "ktLabel2";
            this.ktLabel2.Size = new System.Drawing.Size(57, 21);
            this.ktLabel2.TabIndex = 3;
            this.ktLabel2.Text = "Exame";
            this.MenuTooltips.SetToolTip(this.ktLabel2, "");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.Icons.SetIcons(this.panel2, new KimTools.WinForms.KtIcon[0]);
            this.panel2.Location = new System.Drawing.Point(492, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 330);
            this.panel2.TabIndex = 4;
            this.MenuTooltips.SetToolTip(this.panel2, "");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Icons.SetIcons(this.dataGridView1, new KimTools.WinForms.KtIcon[0]);
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 324);
            this.dataGridView1.TabIndex = 0;
            this.MenuTooltips.SetToolTip(this.dataGridView1, "");
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopBarPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Icons.SetIcons(this, new KimTools.WinForms.KtIcon[0]);
            this.Name = "FrmTeacher";
            this.Opacity = 1D;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Role = KimTools.WinForms.KtColor.Tailwind_White;
            this.Text = "School Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public KimTools.WinForms.KtTooltips MenuTooltips;
        private KimTools.WinForms.KtIcons Icons;
        private KimTools.WinForms.KtPanel TopBarPanel;
        private KimTools.WinForms.KtLabel PageLbl;
        private KimTools.WinForms.KtLabel ktLabelUsername;
        private KimTools.WinForms.KtLabel ktLabelLogout;
        private System.Windows.Forms.Panel panel1;
        private KimTools.WinForms.KtLabel ktLabel2;
        private KimTools.WinForms.KtComboBox ktComboBox2;
        private KimTools.WinForms.KtLabel ktLabel1;
        private KimTools.WinForms.KtComboBox ktcmbClassSubject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}