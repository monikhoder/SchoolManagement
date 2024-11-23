using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimTools.WinForms;
using KimTools.WinForms.KtToastHelpers.KtGaugeRadial.Transitions;
using SchoolManagement.DBAccess;
using SchoolManagement.Dialog;
using SchoolManagement.Properties;

namespace SchoolManagement.Pages
{
    public partial class FrmAdmin : KtWindow
    {
        CrudUsers userdb = new CrudUsers();
        CrudClassroom classroom = new CrudClassroom();
        CrudExam crudexam = new CrudExam();
        private readonly int userId = -1;
        public FrmAdmin(int UserId)
        {
            InitializeComponent();
            userId = UserId;
            StudentCountTxb.Text = userdb.StudentCount().ToString();
            TeacherCountTxb.Text = userdb.TeacherCount().ToString();
            ClassCountTxb.Text = classroom.GetClassCount().ToString();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            if (UserlistCmb.Text == "Admin")
            {
                AdminTbl_Load(sender, e);
            }else if (UserlistCmb.Text == "Teacher")
            {
                TeacherTbl_Load(sender, e);
            }else{
                StudentTbl_Load(sender, e);
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteDialog dialog = new DeleteDialog();
            dialog.ShowDialog();
        }
        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.ShowDialog();
            ClassTbl_Load(sender, e);
        }
        private void DeleteClassBtn_Click(object sender, EventArgs e)
        {
            DeleteDialog deleteDialog = new DeleteDialog();
            deleteDialog.ShowDialog();
        }
        private void EditClassBtn_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.ShowDialog();
        }
        private void UserlistCmb_SelectedIndexChanged(object sender, EventArgs e)
        {           
            UsersPages.SetPage(UserlistCmb.Text);           
        }
        private void AddSubjectToClassBtn_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
            LoadClassroom();
        }

        private void EnrollBtn_Click(object sender, EventArgs e)
        {
            EnrollStudent enrollStudent = new EnrollStudent();
            enrollStudent.ShowDialog();
            ClassTbl_Load(sender, e);
        }      
        private async Task setLoadingpage(string page)
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
        private async void DashboardBtn_Selected(object sender, EventArgs e)
        {
            KtButtonSelect btn = sender as KtButtonSelect;
                string BtnName = btn.Name;
                await  setLoadingpage(BtnName.Substring(0, BtnName.Length - 3));
            
        }
        private async void ProfileBtn_Selected(object sender, EventArgs e)
        {
            await setLoadingpage("Profile");

            FrmProfile frmProfile = new FrmProfile(userId);
            frmProfile.TopLevel = false;
            frmProfile.Dock = DockStyle.Fill;

            ProfilePanel.Controls.Clear();
            ProfilePanel.Controls.Add(frmProfile);
            frmProfile.Show();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            
           
        }

        private void AdminTbl_Load(object sender, EventArgs e)
        {
            AdminTbl.Rows.Clear();
            var users = userdb.GetAdmins("");
            int num = 1;
            foreach (var user in users)
            {
                var adminTbl = AdminTbl.NewRow();
                adminTbl["No"] = num++;
                adminTbl["Id"] = user.Id;
                adminTbl["Name"] = user.Username;
                adminTbl["Role"] = "Admin";
            }
        }

        private void UserSearchTxb_TextChange(object sender, EventArgs e)
        {
            if(UserlistCmb.Text.ToLower() == "admin")
            {
                AdminTbl_Load(sender, e);
            }
        }

        private void TeacherTbl_Load(object sender, EventArgs e)
        {
            TeacherTbl.Rows.Clear();
            var users = userdb.GetTeachers("");
            int num = 1;
            foreach (var user in users)
            {
                string status = user.Status == true ? "Active" : "Non active";
                var newTbl = TeacherTbl.NewRow();
                newTbl["No"] = num++;
                newTbl["Id"] = user.UserId;
                newTbl["FullName"] = user.FirstName + " " + user.LastName;
                newTbl["Gender"] = user.Gender;
                newTbl["Salary"] = user.Salary;
                newTbl["Status"] = status;
            }
        }

        private void StudentTbl_Load(object sender, EventArgs e)
        {
            StudentTbl.Rows.Clear();
            var users = userdb.GetStudents("");
            int num = 1;
            foreach (var user in users)
            {
                string status = user.Status == true ? "Active" : "Non active";
                var newTbl = StudentTbl.NewRow();
                newTbl["No"] = num++;
                newTbl["Id"] = user.UserId;
                newTbl["FullName"] = user.FirstName + " " + user.LastName;
                newTbl["Gender"] = user.Gender;
                newTbl["Status"] = status;
            }

        }
        private void LoadClassroom()
        {
            ClassTbl.Rows.Clear();
            var classrooms = classroom.GetClassRoom();
            int num = 1;
            foreach (var classitems in classrooms)
            {
                string status = "Ongoing";
                if (classitems.EndDate < DateTime.Now)
                {
                    status = "Finished";
                }else if (classitems.StartDate > DateTime.Now)
                {
                    status = "Upcoming";
                }   
                var items = ClassTbl.NewRow();
                items["No"] = num++;
                items["ClassName"] = classitems.Name;
                items["TotalStudent"] = classroom.GetClassEnrollCountByClassId(classitems.Id);
                items["TotalSubject"] = classroom.GetSubjectCountByClassId(classitems.Id);
                items["StartDate"] = classitems.StartDate.ToShortDateString();
                items["EndDate"] = classitems.EndDate.ToShortDateString();
                items["Status"] = status;              
            }
        }

        private void ClassTbl_Load(object sender, EventArgs e)
        {
            LoadClassroom();
        }

        private void AddExamBtn_Click(object sender, EventArgs e)
        {
            AddExam addExam = new AddExam();
            addExam.ShowDialog();
        }
        private void LoadExamList()
        {
           ExamsTbl.Rows.Clear();
           var exams = crudexam.GetExamList();
            int num = 1;
            foreach (var exam in exams)
            {
                
                var examTbl = ExamsTbl.NewRow();
                examTbl["No"] = num++;
                examTbl["ExamName"] = exam.Name;
                examTbl["ClassRoom"] = exam.Classroom;
                examTbl["Subject"] = exam.Subject;
                examTbl["Teacher"] = exam.Teacher;
                examTbl["ExamDate"] = exam.ExamDate.ToShortDateString();
                examTbl["Duration"] = exam.Duration;
            }
        }

        private void ExamsTbl_Load(object sender, EventArgs e)
        {
            LoadExamList();
        }
    }
}
