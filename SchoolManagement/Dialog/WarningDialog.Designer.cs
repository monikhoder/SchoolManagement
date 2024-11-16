namespace SchoolManagement.Dialog
{
    partial class WarningDialog
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
            this.ktLabel1 = new KimTools.WinForms.KtLabel();
            this.SuspendLayout();
            // 
            // ktLabel1
            // 
            this.ktLabel1.AutoSize = true;
            this.ktLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.ktLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel1.KtFontSize = KimTools.WinForms.KtFont.H4;
            this.ktLabel1.Location = new System.Drawing.Point(119, 85);
            this.ktLabel1.Name = "ktLabel1";
            this.ktLabel1.Size = new System.Drawing.Size(66, 30);
            this.ktLabel1.TabIndex = 0;
            this.ktLabel1.Text = "Label";
            this.ktLabel1.Click += new System.EventHandler(this.ktLabel1_Click);
            // 
            // WarningDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 306);
            this.Controls.Add(this.ktLabel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarningDialog";
            this.Opacity = 1D;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KimTools.WinForms.KtLabel ktLabel1;
    }
}