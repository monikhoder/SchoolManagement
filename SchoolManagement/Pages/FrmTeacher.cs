using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        CrudClassroom crudClassroom = new CrudClassroom();

        public FrmTeacher(int UserId)
        {
            InitializeComponent();
            userId = UserId;
            UsernameDisplay(userId);
            //LoadClassSubject();
        }

        private void UsernameDisplay(int UserId)
        {
            //userId = UserId;    
            ktLabelUsername.Text = UserId.ToString();
        }
        private void LoadClassSubject()
        {
            using ( var context = new SchoolDBEntities())
            {
                var classSubjects = context.ClassSubjects.Include(cs => cs.Subject).ToList();
                ktcmbClassSubject.DataSource = classSubjects;
                ktcmbClassSubject.DisplayMember = "Subject.Name";
                ktcmbClassSubject.ValueMember = "Id";
            }
        }
        private void ktLabelLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }
    }
}
