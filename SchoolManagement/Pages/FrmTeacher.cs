using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimTools.WinForms;
using SchoolManagement.DBAccess;
using SchoolManagement.Dialog;

namespace SchoolManagement.Pages
{
    public partial class FrmTeacher : KtWindow
    {
        private int userId = -1;
        private SchoolDBEntities dbContext;
        public FrmTeacher(int UserId)
        {
            this.ControlBox = false;
            InitializeComponent();
            dbContext = new SchoolDBEntities();
            userId = UserId;
            UsernameDisplay(userId);
            LoadComboBox();
        }

        private void UsernameDisplay(int UserId)
        {
            //userId = UserId;    
            ktLabelUsername.Text = UserId.ToString();
        }
        private void LoadComboBox()
        {


        }

        private void ktButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }


        private void btnteachingClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachingClass teachingClass = new TeachingClass();
            teachingClass.ShowDialog();
        }

        private void btnscoringExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScoringExam scoringExam = new ScoringExam();
            scoringExam.ShowDialog();
        }
    }
}
