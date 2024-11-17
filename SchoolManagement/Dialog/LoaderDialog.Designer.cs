namespace SchoolManagement.Dialog
{
    partial class LoaderDialog
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
            this.ktSpinner1 = new KimTools.WinForms.KtSpinner();
            this.SuspendLayout();
            // 
            // ktSpinner1
            // 
            this.ktSpinner1.AllowPresets = false;
            this.ktSpinner1.BackColor = System.Drawing.Color.White;
            this.ktSpinner1.CapPoint = KimTools.WinForms.KtSpinner.CapPoints.Both;
            this.ktSpinner1.CapStyle = KimTools.WinForms.KtSpinner.CapStyles.Round;
            this.ktSpinner1.Color = System.Drawing.Color.SlateBlue;
            this.ktSpinner1.Colors = new KimTools.WinForms.Bloom[0];
            this.ktSpinner1.Customization = "";
            this.ktSpinner1.DashCap = KimTools.WinForms.KtSpinner.DashCaps.Round;
            this.ktSpinner1.DashWidth = 0.5F;
            this.ktSpinner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ktSpinner1.Font = new System.Drawing.Font("Verdana", 8F);
            this.ktSpinner1.Image = null;
            this.ktSpinner1.Location = new System.Drawing.Point(0, 0);
            this.ktSpinner1.Name = "ktSpinner1";
            this.ktSpinner1.NoRounding = false;
            this.ktSpinner1.Preset = KimTools.WinForms.KtSpinner.Presets.Solid;
            this.ktSpinner1.ShowText = false;
            this.ktSpinner1.Size = new System.Drawing.Size(127, 110);
            this.ktSpinner1.Speed = 3;
            this.ktSpinner1.Style = KimTools.WinForms.KtSpinner.Styles.Solid;
            this.ktSpinner1.TabIndex = 0;
            this.ktSpinner1.Text = "ktSpinner1";
            this.ktSpinner1.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ktSpinner1.Thickness = 10;
            this.ktSpinner1.Transparent = true;
            // 
            // LoaderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(127, 110);
            this.Controls.Add(this.ktSpinner1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoaderDialog";
            this.ResumeLayout(false);

        }

        #endregion

        public KimTools.WinForms.KtSpinner ktSpinner1;
    }
}