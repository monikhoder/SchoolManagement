using KimTools.WinForms;
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

        private void AssignScore(int examId, int studentId)
        {
           
            if (db.ExamResults.Any(e => e.ExamId == examId && e.StudentId == studentId))
            {
                throw new Exception("Student Score already added in this class.");
            }

            var assignscore = new ExamResult()
            {
                ExamId = examId,
                StudentId = studentId,
                Score = decimal.Parse(ktTextBoxScore.Text),
                GradedDate = DateTime.Now,
            };
            db.ExamResults.Add(assignscore);
            db.SaveChanges();

        }
        private void AddScorebtn_Click(object sender, EventArgs e)
        {
            int examId = Convert.ToInt32(ScoreClassNameCmb.SelectedValue);
            int studentId = Convert.ToInt32(ScoreStudentCmb.SelectedValue);

            try
            {
                AssignScore(examId, studentId);
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
            LoadScore();
            ClearScore();
        }
        private void ScoringExam_Load(object sender, EventArgs e)
        {
            LoadScore();
        }

        private void ClearScore()
        {
            ScoreClassNameCmb.Text = "";
            ScoreStudentCmb.Text= "";
            ktTextBoxScore.Text = "";
        }
        private void LoadScore()
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
        private void ktButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacher frmTeacher = new FrmTeacher(1);
            frmTeacher.Show();
        }
    }
}
