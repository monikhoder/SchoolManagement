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
using SchoolManagement.Dialog;
using SchoolManagement.Properties;

namespace SchoolManagement.Pages
{
    public partial class FrmStudent : KtWindow
    {
        private int userId = -1;
        CrudClassroom cc;
        CrudExam ce;
        public FrmStudent(int UserId)
        {
            InitializeComponent();
            userId = UserId;
            cc = new CrudClassroom();
            ce = new CrudExam();
        }
        private async void DashboardBtn_Selected(object sender, EventArgs e)
        {
            KtButtonSelect btn = sender as KtButtonSelect;
            string BtnName = btn.Name;
            await SetLoadingpage(BtnName.Substring(0, BtnName.Length - 3));
        }
        private async void ProfileBtn_Selected(object sender, EventArgs e)
        {
            await SetLoadingpage("Profile");

            FrmProfile frmProfile = new FrmProfile();
            frmProfile.TopLevel = false;
            frmProfile.Dock = DockStyle.Fill;

            ProfilePanel.Controls.Clear();
            ProfilePanel.Controls.Add(frmProfile);
            frmProfile.Show();
        }
        private async Task SetLoadingpage(string page)
        {
            try
            {
                MainPages.SetPage(Loader);

                await Task.Run(() =>
                {
                    System.Threading.Thread.Sleep(500);
                });
                MainPages.SetPage(page);
                PageLbl.Text = page;

            }
            catch (Exception ex)
            {
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertIcon.Image = Resources.warning_icon;
                alertDialogs.ShowDialog();
            }
        }

        private void ClassroomTbl_Load(object sender, EventArgs e)
        {
            ClassroomTbl.Rows.Clear();
            var Classes = cc.GetAllClassEnrollment();
            int num = 1;
            foreach ( var c in Classes)
            {
                var ClassTbl = ClassroomTbl.NewRow();
                int totalStudent = cc.GetTotalStudentByClassId(num);
                ClassTbl["No"] = num++;
                ClassTbl["ClassName"] = c.Classroom.Name;
                ClassTbl["TotalStudent"] = totalStudent;
                ClassTbl["StartDate"] = c.Classroom.StartDate.ToString("MM/dd/yyyy");
                ClassTbl["EndDate"] = c.Classroom.EndDate.ToString("MM/dd/yyyy");
                ClassTbl["Status"] = c.Status.HasValue ? (c.Status.Value ? "Active" : "Non-Active") : "Active";
                ClassroomTbl.Rows.Add(ClassTbl);
            }
        }
        private void ExamTbl_Load(object sender, EventArgs e)
        {
            ExamTbl.Rows.Clear();
            var Exams = ce.GetAllExam();
            int num = 1;
            foreach (var ee in Exams)
            {
                var ExamsTbl = ExamTbl.NewRow();
                var Classroom = ce.GetClassroomByExamId(num);
                var Subject = ce.GetSubjectByExamId(num);
                var Teacher = ce.GetTeacherByExamId(num);
                ExamsTbl["No"] = num++;
                ExamsTbl["Name"] = ee.Name;
                ExamsTbl["Classroom"] = Classroom ?? "N/A";
                ExamsTbl["Subject"] = Subject ?? "N/A";
                ExamsTbl["Teacher"] = Teacher ?? "N/A";
                ExamsTbl["ExamDate"] = ee.ExamDate.ToString("MM/dd/yyyy");
                ExamsTbl["Duration"] = ee.Duration.ToString() + "minutes";
                ExamTbl.Rows.Add(ExamsTbl);
            }
        }
        private void ScoreTbl_Load(object sender, EventArgs e)
        {
            ScoreTbl.Rows.Clear();
            var Scores = ce.GetAllExamResult();
            int num = 1;
            foreach (var s in Scores)
            {
                var items = ScoreTbl.NewRow();
                var Teacher = ce.GetTeacherByExamResultId(num, userId);
                var Subject = ce.GetSubjectByExamResultId(num, userId);
                items["No"] = num++;
                items["Name"] = s.Exam.Name;
                items["Teacher"] = Teacher ?? "N/A";
                items["Subject"] = Subject ?? "N/A";
                items["ExamDate"] = s.Exam.ExamDate.ToString("MM/dd/yyyy");
                items["Score"] = s.Score;
                ScoreTbl.Rows.Add(items);
            }
        }
        private void ClassroomSch_TextChanged(object sender, EventArgs e)
        {
            string text = ClassroomSch.Text.Trim();
            var Classes = cc.GetAllClassEnrollmentByName(text);

            ClassroomTbl.Rows.Clear();
            int num = 1;

            foreach (var c in Classes)
            {
                var ClassTbl = ClassroomTbl.NewRow();
                int totalStudent = cc.GetTotalStudentByClassId(c.Classroom.Id);
                ClassTbl["No"] = num++;
                ClassTbl["ClassName"] = c.Classroom.Name;
                ClassTbl["TotalStudent"] = totalStudent;
                ClassTbl["StartDate"] = c.Classroom.StartDate.ToString("MM/dd/yyyy");
                ClassTbl["EndDate"] = c.Classroom.EndDate.ToString("MM/dd/yyyy");
                ClassTbl["Status"] = c.Status.HasValue ? (c.Status.Value ? "Active" : "Non-Active") : "Active";
                ClassroomTbl.Rows.Add(ClassTbl);
            }
        }
        private void ExamSch_TextChanged(object sender, EventArgs e)
        {
            string text = ExamSch.Text.Trim();
            var Exams = ce.GetAllExamByName(text);

            ExamTbl.Rows.Clear();
            int num = 1;
            foreach (var ee in Exams)
            {
                var ExamsTbl = ExamTbl.NewRow();
                var Classroom = ce.GetClassroomByExamId(ee.Id);
                var Subject = ce.GetSubjectByExamId(ee.Id);
                var Teacher = ce.GetTeacherByExamId(ee.Id);
                ExamsTbl["No"] = num++;
                ExamsTbl["Name"] = ee.Name;
                ExamsTbl["Classroom"] = Classroom ?? "N/A";
                ExamsTbl["Subject"] = Subject ?? "N/A";
                ExamsTbl["Teacher"] = Teacher ?? "N/A";
                ExamsTbl["ExamDate"] = ee.ExamDate.ToString("MM/dd/yyyy");
                ExamsTbl["Duration"] = ee.Duration.ToString() + "minutes";
                ExamTbl.Rows.Add(ExamsTbl);
            }
        }
        private void ScoreSch_TextChanged(object sender, EventArgs e)
        {
            string text = ScoreSch.Text.Trim();
            var Scores = ce.GetAllExamResultByName(text);

            ScoreTbl.Rows.Clear();
            int num = 1;
            foreach (var s in Scores)
            {
                var items = ScoreTbl.NewRow();
                var Teacher = ce.GetTeacherByExamResultId(s.Exam.Id, userId);
                var Subject = ce.GetSubjectByExamResultId(s.Exam.Id, userId);
                items["No"] = num++;
                items["Name"] = s.Exam.Name;
                items["Teacher"] = Teacher ?? "N/A";
                items["Subject"] = Subject ?? "N/A";
                items["ExamDate"] = s.Exam.ExamDate.ToString("MM/dd/yyyy");
                items["Score"] = s.Score;
                ScoreTbl.Rows.Add(items);
            }
        }
    }
}
