using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimTools.WinForms;
using SchoolManagement.DBAccess;
namespace SchoolManagement.Dialog
{
    public partial class EnrollStudent : KtWindow
    {
        CrudClassroom crudClassroom = new CrudClassroom();
        CrudUsers users = new CrudUsers();
        public EnrollStudent()
        {
            InitializeComponent();
        }

        private async void EnrollStudent_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(100);
            });
            LoadCmb();
        }
        private void LoadCmb()
        {
            var classrom = crudClassroom.GetClassRoom();
            var student = users.GetStudents("");
            
            ClassNameCmb.DataSource = classrom;
            ClassNameCmb.DisplayMember = "Name";
            ClassNameCmb.ValueMember = "Id";

            StudentCmb.DataSource = student;
            StudentCmb.DisplayMember = "LastName";
            StudentCmb.ValueMember = "Id";
        }

        private void EnrollBtn_Click(object sender, EventArgs e)
        {
            int classId = Convert.ToInt32(ClassNameCmb.SelectedValue);
            int studentId = Convert.ToInt32(StudentCmb.SelectedValue);

            try
            {
                crudClassroom.EnrollStudent(classId, studentId);
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = "Student Enrolled Successfully";
                alertDialogs.AlertIcon.Image = Properties.Resources._checked;
                alertDialogs.AlertLbl.LabelColor = KtColor.Tailwind_Violet;
                alertDialogs.ShowDialog();
            }
            catch (Exception ex)
            {
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertIcon.Image = Properties.Resources.warning_icon;
                alertDialogs.AlertLbl.LabelColor = KtColor.Danger;
                alertDialogs.ShowDialog();

            }
        }
    }
}
