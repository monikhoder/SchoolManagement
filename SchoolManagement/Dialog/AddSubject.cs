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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace SchoolManagement.Dialog
{
    public partial class AddSubject : KtWindow
    {
        CrudClassroom classroom = new CrudClassroom();
        CrudUsers CrudUsers = new CrudUsers();
        public AddSubject()
        {
            InitializeComponent();
        }

        private void ktLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SubjectTxb_TextChange(object sender, EventArgs e)
        {
            if (SubjectTxb.Text.Length > 0)
            {
                AddSubjectBtn.Enabled = true;
            }
            else
            {
                AddSubjectBtn.Enabled = false;
            }
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                classroom.AddSubject(SubjectTxb.Text);
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = "Subject Added successful";
                alertDialogs.AlertIcon.Image = Properties.Resources._checked;
                alertDialogs.ShowDialog();
                SubjectTxb.Text = "";
            }
            catch (Exception ex)
            {
                
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertIcon.Image = Properties.Resources.warning_icon;
                alertDialogs.AlertLbl.LabelColor = KtColor.Danger;
                alertDialogs.ShowDialog();
            }
        }

   
        private void LoadSubjectTbl()
        {
            SubjectTbl.Rows.Clear();
            var subjects = classroom.GetSubjects();
            int no = 1;
            foreach ( var subject in subjects )
            {
                var row = SubjectTbl.NewRow();
                row["No"] = no++;
                row["Name"] = subject.Name;
                row["TotalClass"] = classroom.GetClassCountBySubjectId(subject.Id);
            }

        }
       private void ComboboxLoad()
        {
            ClassNameCmb.Items.Clear();
            TeacherCmb.Items.Clear();
            var getclass = classroom.GetClassRoom();            
            var getteacher = CrudUsers.GetTeachers("");

            ClassNameCmb.DataSource = getclass;
            ClassNameCmb.DisplayMember = "Name";
            ClassNameCmb.ValueMember = "Id";

            TeacherCmb.DataSource = getteacher;
            TeacherCmb.DisplayMember = "LastName";
            TeacherCmb.ValueMember = "Id";
        }
        private void SubjectCmbLoad()
        {
            SubjectCmb.Items.Clear();
            var getsubject = classroom.GetSubjects();
            SubjectCmb.DataSource = getsubject;
            SubjectCmb.DisplayMember = "Name";
            SubjectCmb.ValueMember = "Id";

        }
        private async void AddSubject_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(100); 
            });
            ComboboxLoad();
            SubjectCmbLoad();
            LoadSubjectTbl();            
        }
        private void BtnAddSubjectToClassEnable()
        {
            if(ClassNameCmb.SelectedItem != null && SubjectCmb.SelectedItem != null && TeacherCmb.SelectedItem != null)
            {
                AddSubjectToClassBtn.Enabled = true;
            }
            else
            {
                AddSubjectToClassBtn.Enabled = false;
            }

        }

        private void ClassNameCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAddSubjectToClassEnable();
        }

        private void AddSubjectToClassBtn_Click(object sender, EventArgs e)
        {
            int classId = Convert.ToInt32(ClassNameCmb.SelectedValue);
            int subjectId = Convert.ToInt32(SubjectCmb.SelectedValue);
            int teacherId = Convert.ToInt32(TeacherCmb.SelectedValue);            

            try
            {
                classroom.AddClassSubject(classId, subjectId, teacherId);
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = "Subject Added to classroom successful";
                alertDialogs.AlertIcon.Image = Properties.Resources._checked;
                alertDialogs.AlertLbl.LabelColor = KtColor.Tailwind_Violet;
                alertDialogs.ShowDialog();

            }catch(Exception ex)
            {
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertIcon.Image = Properties.Resources.warning_icon;
                alertDialogs.AlertLbl.LabelColor = KtColor.Danger;
                alertDialogs.ShowDialog();
            }
        }
    }
}
