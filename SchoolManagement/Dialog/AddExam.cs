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
namespace SchoolManagement.Dialog
{
    public partial class AddExam : KtWindow
    {
        CrudClassroom crudClassroom;
        public AddExam()
        {
            InitializeComponent();
            crudClassroom = new CrudClassroom();
        }

        private async void AddExam_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(100);
            });

            LoadClassName();
            LoadClassSubject();
        }
        private void LoadClassSubject()
        {
            ClassSubjectCmb.Items.Clear();
            int id = Convert.ToInt32(ClassNameCmb.SelectedValue);
            var subjectList = crudClassroom.GetClassSubjectByClassId(id);
            ClassSubjectCmb.DataSource = subjectList;
            ClassSubjectCmb.DisplayMember = "Name";
            ClassSubjectCmb.ValueMember = "Id";
        }
        private void LoadClassName()
        {
            ClassNameCmb.Items.Clear();
            var classname = crudClassroom.GetClassRoom();
            ClassNameCmb.DataSource = classname;
            ClassNameCmb.DisplayMember = "Name";
            ClassNameCmb.ValueMember = "Id";

        }

        private void ClassNameCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassSubject();
        }
    }
}
