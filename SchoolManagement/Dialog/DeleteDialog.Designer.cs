namespace SchoolManagement.Dialog
{
    partial class DeleteDialog
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
            this.ktButton1 = new KimTools.WinForms.KtButton();
            this.NoBtn = new KimTools.WinForms.KtButton();
            this.SuspendLayout();
            // 
            // ktLabel1
            // 
            this.ktLabel1.AutoSize = true;
            this.ktLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.ktLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ktLabel1.KtFontSize = KimTools.WinForms.KtFont.H4;
            this.ktLabel1.Location = new System.Drawing.Point(12, 32);
            this.ktLabel1.Name = "ktLabel1";
            this.ktLabel1.Size = new System.Drawing.Size(294, 30);
            this.ktLabel1.TabIndex = 0;
            this.ktLabel1.Text = "Are you want to delete this?";
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
            this.ktButton1.Location = new System.Drawing.Point(238, 151);
            this.ktButton1.Name = "ktButton1";
            this.ktButton1.Size = new System.Drawing.Size(120, 38);
            this.ktButton1.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.ktButton1.TabIndex = 1;
            this.ktButton1.Text = "YES";
            this.ktButton1.UseVisualStyleBackColor = false;
            this.ktButton1.Click += new System.EventHandler(this.ktButton1_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.Empty;
            this.NoBtn.Bg = KimTools.WinForms.KtColor.Danger;
            this.NoBtn.BorderShape = KimTools.WinForms.KtSize.Default;
            this.NoBtn.BorderSize = KimTools.WinForms.KtSize.Default;
            this.NoBtn.CustomColors = new System.Drawing.Color[0];
            this.NoBtn.FlatAppearance.BorderSize = 0;
            this.NoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NoBtn.IconName = "";
            this.NoBtn.IconSize = 16;
            this.NoBtn.IconStroke = 2.5D;
            this.NoBtn.Location = new System.Drawing.Point(12, 151);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(120, 38);
            this.NoBtn.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.NoBtn.TabIndex = 2;
            this.NoBtn.Text = "NO";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // DeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 208);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.ktButton1);
            this.Controls.Add(this.ktLabel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteDialog";
            this.Opacity = 1D;
            this.Text = "DeleteDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KimTools.WinForms.KtLabel ktLabel1;
        private KimTools.WinForms.KtButton ktButton1;
        private KimTools.WinForms.KtButton NoBtn;
    }
}