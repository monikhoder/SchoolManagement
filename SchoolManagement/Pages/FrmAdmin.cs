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

namespace SchoolManagement.Pages
{
    public partial class FrmAdmin : KtWindow
    {
        public FrmAdmin()
        {
            InitializeComponent();
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
    }
}
