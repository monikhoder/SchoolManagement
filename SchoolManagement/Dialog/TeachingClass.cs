using SchoolManagement.DBAccess;
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

        CrudClassroom cc;
        SchoolDBEntities db = new SchoolDBEntities();
        CrudExam crudexam = new CrudExam();
        private readonly int userId = -1;
        public TeachingClass()
        {
            InitializeComponent();
            cc= new CrudClassroom();
            this.ControlBox = false;

        }
        private void ktLabelBack_Click(object sender, EventArgs e)
        {
            
        }

         private void TeachingClass_Load(object sender, EventArgs e)
        {
            ClassTbl.Rows.Clear();
            var teachingclass = crudexam.GetTeachinglists();

            int num = 1;

            foreach (var t in teachingclass)
            {
                var newclassTbl = ClassTbl.NewRow();

                newclassTbl["No"] = num++;
                newclassTbl["ClassName"] = t.ClassName;
                newclassTbl["Subject"] = t.Subject;
                newclassTbl["Teacher"] = t.Teacher;
                newclassTbl["Student"] = t.Student;
                newclassTbl["Gender"] = t.StudentGender;

                ClassTbl.Rows.Add(newclassTbl);
            }

        }

        private void ktButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacher frmTeacher = new FrmTeacher(1);
            frmTeacher.Show();
        }
    }
}
