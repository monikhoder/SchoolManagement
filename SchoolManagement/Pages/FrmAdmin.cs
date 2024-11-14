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
    }
}
