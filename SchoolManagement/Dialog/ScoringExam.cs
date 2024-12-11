using SchoolManagement.DBAccess;
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
    public partial class ScoringExam : Form
    {
        SchoolDBEntities db = new SchoolDBEntities();
        CrudExam crudexam = new CrudExam();
        CrudUsers users = new CrudUsers();
        public ScoringExam()
        {
            InitializeComponent();
            LoadCmb();
        }

        private List<Student> GetStudents(string search)
        {
            return db.Students
                .Where(s => s.FirstName.Contains(search) || s.LastName.Contains(search))
                .Select(s => new Student
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName
                })
                .ToList();
        }
        private class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        private void LoadCmb()
        {
            var exam = crudexam.GetAllExam();
            var student = users.GetStudents("");

            var studentDisplay = student.Select(s => new {
                FullName = s.FirstName + " " + s.LastName,
                Id = s.Id
            }).ToList();

            ScoreClassNameCmb.DataSource = exam;
            ScoreClassNameCmb.DisplayMember = "Name";
            ScoreClassNameCmb.ValueMember = "Id";

            ScoreStudentCmb.DataSource = studentDisplay;
            ScoreStudentCmb.DisplayMember = "FullName";
            ScoreStudentCmb.ValueMember = "Id";
        }
        private void ScoringExam_Load(object sender, EventArgs e)
        {

            ScoringTbl.Rows.Clear();
            var scoringexam = crudexam.GetAllScoringList();

            int num = 1;

            foreach (var se in scoringexam)
            {
                var newScoringTbl = ScoringTbl.NewRow();

                newScoringTbl["No"] = num++;
                newScoringTbl["ExamName"] = se.ExamName;
                newScoringTbl["StudentName"] = se.Student;
                newScoringTbl["Score"] = se.Score;
                

                ScoringTbl.Rows.Add(newScoringTbl);
            }
        }


    }
}
