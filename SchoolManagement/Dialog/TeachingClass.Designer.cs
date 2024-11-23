namespace SchoolManagement.Dialog
{
    partial class TeachingClass
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
            this.btnBack = new KimTools.WinForms.KtButton();
            this.dgteachingClass = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SujectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgteachingClass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Empty;
            this.btnBack.BorderShape = KimTools.WinForms.KtSize.Default;
            this.btnBack.BorderSize = KimTools.WinForms.KtSize.Default;
            this.btnBack.CustomColors = new System.Drawing.Color[0];
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.IconName = "";
            this.btnBack.IconSize = 16;
            this.btnBack.IconStroke = 2.5D;
            this.btnBack.Location = new System.Drawing.Point(1048, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 45);
            this.btnBack.Style = KimTools.WinForms.KtStyle.Tailwind;
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgteachingClass
            // 
            this.dgteachingClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgteachingClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ClassroomId,
            this.SujectId,
            this.TeacherId,
            this.Student});
            this.dgteachingClass.Location = new System.Drawing.Point(12, 73);
            this.dgteachingClass.Name = "dgteachingClass";
            this.dgteachingClass.RowTemplate.Height = 24;
            this.dgteachingClass.Size = new System.Drawing.Size(1131, 533);
            this.dgteachingClass.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.HeaderText = "Number";
            this.ID.Name = "ID";
            // 
            // ClassroomId
            // 
            this.ClassroomId.HeaderText = "Class room";
            this.ClassroomId.Name = "ClassroomId";
            // 
            // SujectId
            // 
            this.SujectId.HeaderText = "Subject";
            this.SujectId.Name = "SujectId";
            // 
            // TeacherId
            // 
            this.TeacherId.HeaderText = "Teacher";
            this.TeacherId.Name = "TeacherId";
            // 
            // Student
            // 
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // TeachingClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 625);
            this.Controls.Add(this.dgteachingClass);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeachingClass";
            this.Text = "TeachingClass";
            ((System.ComponentModel.ISupportInitialize)(this.dgteachingClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KimTools.WinForms.KtButton btnBack;
        private System.Windows.Forms.DataGridView dgteachingClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SujectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
    }
}