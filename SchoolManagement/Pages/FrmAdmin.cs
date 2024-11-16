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
using SchoolManagement.Dialog;

namespace SchoolManagement.Pages
{
    public partial class FrmAdmin : KtWindow
    {
        private int userId = -1;
        public FrmAdmin(int UserId)
        {
            InitializeComponent();
            userId = UserId;
        }
      

        private void ProfileBtn_Change(object sender, bool selected, EventArgs e)
        {
            MainPages.SetPage(Profile);
            PageLbl.Text = "My Profile";
            FrmProfile frmProfile = new FrmProfile();
            frmProfile.TopLevel = false;
            frmProfile.Dock = DockStyle.Fill;

            ProfilePanel.Controls.Clear();
            ProfilePanel.Controls.Add(frmProfile);
            frmProfile.Show();
        }

        private void DashboardBtn_Change(object sender, bool selected, EventArgs e)
        {
            MainPages.SetPage(Dasboard);
            PageLbl.Text = "Dashboard";
        }

        private void UsersBtn_Change(object sender, bool selected, EventArgs e)
        {   MainPages.SetPage(Users);
            PageLbl.Text = "All Users";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteDialog dialog = new DeleteDialog();
            dialog.ShowDialog();
        }

        private void ClassBtn_Change(object sender, bool selected, EventArgs e)
        {
            MainPages.SetPage(Class);
            PageLbl.Text = "Class";

        }

        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.ShowDialog();
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
        }

        private void EnrollBtn_Click(object sender, EventArgs e)
        {
            EnrollStudent enrollStudent = new EnrollStudent();
            enrollStudent.ShowDialog();
        }

        private void ExamBtn_Change(object sender, bool selected, EventArgs e)
        {
            MainPages.SetPage(Exam);
            PageLbl.Text = "Exam";
        }
    }
}
