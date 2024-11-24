using SchoolManagement.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SchoolManagement.Dialog
{
    public partial class TeachingClass : Form
    {
        SchoolDBEntities dbContext = new SchoolDBEntities();
        public TeachingClass()
        {
            InitializeComponent();
            this.ControlBox = false;
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacher frmTeacher = new FrmTeacher(1);
            frmTeacher.ShowDialog();
        }

        private void LoadData()
        {

            var query = (from cs in dbContext.ClassSubjects
                        join c in dbContext.Classrooms on cs.ClassroomId equals c.Id
                        join s in dbContext.Subjects on cs.SubjectId equals s.Id
                        join t in dbContext.Teachers on cs.TeacherId equals t.Id
                        join ce in dbContext.ClassEnrollments on cs.Id equals ce.ClassroomId
                        join st in dbContext.Students on ce.StudentId equals st.Id
                        select new
                        {
                            Id = cs.Id,
                            ClassroomName = c.Name,
                            SubjectName = s.Name,
                            TeacherName = t.FirstName + t.LastName,
                            StudentName = st.FirstName + st.LastName,
                         }).ToList();

            foreach (var item in query)
            {
                dgteachingClass.Rows.Add(
                    item.Id,
                    item.ClassroomName,
                    item.SubjectName,
                    item.TeacherName,
                    item.StudentName);
            }


        }

    }
}
