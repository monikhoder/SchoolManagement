namespace SchoolManagement.Dialog
{
    partial class AlertDialogs
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
            this.AlertLbl = new KimTools.WinForms.KtLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AlertIcon = new KimTools.WinForms.KtPictureBox();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlertIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlertLbl
            // 
            this.AlertLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlertLbl.AutoSize = true;
            this.AlertLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.AlertLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AlertLbl.KtFontSize = KimTools.WinForms.KtFont.H4;
            this.AlertLbl.Location = new System.Drawing.Point(47, 23);
            this.AlertLbl.Name = "AlertLbl";
            this.AlertLbl.Shade = KimTools.WinForms.KtShade.Light_10;
            this.AlertLbl.Size = new System.Drawing.Size(68, 30);
            this.AlertLbl.TabIndex = 0;
            this.AlertLbl.Text = "{Text}";
            this.AlertLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AlertIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 146);
            this.panel1.TabIndex = 1;
            // 
            // AlertIcon
            // 
            this.AlertIcon.AllowFocused = false;
            this.AlertIcon.AutoSizeHeight = true;
            this.AlertIcon.BorderRadius = 32;
            this.AlertIcon.Image = global::SchoolManagement.Properties.Resources._checked;
            this.AlertIcon.IsCircle = true;
            this.AlertIcon.Location = new System.Drawing.Point(103, 41);
            this.AlertIcon.Name = "AlertIcon";
            this.AlertIcon.Size = new System.Drawing.Size(64, 64);
            this.AlertIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlertIcon.TabIndex = 0;
            this.AlertIcon.TabStop = false;
            this.AlertIcon.Type = KimTools.WinForms.KtPictureBox.Types.Circle;
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 3000;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AlertLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 77);
            this.panel2.TabIndex = 2;
            // 
            // AlertDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 233);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertDialogs";
            this.Opacity = 1D;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Shade = KimTools.WinForms.KtShade.Light_10;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlertIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public KimTools.WinForms.KtLabel AlertLbl;
        public KimTools.WinForms.KtPictureBox AlertIcon;
        private System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.Panel panel2;
    }
}