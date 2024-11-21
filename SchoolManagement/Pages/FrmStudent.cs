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
        public FrmStudent(int UserId)
        {
            InitializeComponent();
            userId = UserId;
            cc = new CrudClassroom();
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
            foreach ( var c in Classes )
            {
                var ClassTbl = ClassroomTbl.NewRow();
                int totalStudent = cc.GetTotalStudentByClassId(num);
                ClassTbl["No"] = num++;
                ClassTbl["Name"] = c.Classroom.Name;
                ClassTbl["Total student"] = totalStudent;
                ClassTbl["Start date"] = c.Classroom.StartDate.ToString("MM/dd/yyyy");
                ClassTbl["End date"] = c.Classroom.EndDate.ToString("MM/dd/yyyy");
                ClassTbl["Status"] = (bool)c.Status ? "Active" : "Non-Active";
            }
        }
    }
}
