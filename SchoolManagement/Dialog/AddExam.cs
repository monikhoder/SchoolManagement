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
        CrudClassroom crudClassroom = new CrudClassroom();
        CrudExam exam = new CrudExam();
        public AddExam()
        {
            InitializeComponent();
           
        }

        private async void AddExam_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(100);
            });

           LoadClassName();
          // LoadClassSubject();
        }
        private void LoadClassSubject()
        {
           
            int id = ClassNameCmb.SelectedValue is int ? (int)ClassNameCmb.SelectedValue : 1;
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

        private void ClassNameCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadClassSubject();
        }

        private void AddExamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int subjectId = ClassSubjectCmb.SelectedValue is int ? (int)ClassSubjectCmb.SelectedValue : 1;
                int duration = DurationTxb.Text.Length > 0 ? int.Parse(DurationTxb.Text) : 0;
                exam.AddExam(ExamNameTxb.Text, subjectId, ExamDate.Value, duration);

                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertIcon.Image = Properties.Resources._checked;
                alertDialogs.AlertLbl.Text = "Exam Added Successfully";
                alertDialogs.AlertLbl.LabelColor = KtColor.Tailwind_Violet;
                alertDialogs.ShowDialog();
            }catch (Exception ex)
            {
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertIcon.Image = Properties.Resources.warning_icon;
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertLbl.LabelColor = KtColor.Danger;
                alertDialogs.ShowDialog();

            }
            
        }
        private void AddExamBtnEnable()
        {
            if (ExamNameTxb.Text.Length > 0 && DurationTxb.Text.Length > 0 && ExamDate.Value >= DateTime.Now)
            {
                AddExamBtn.Enabled = true;
            }
            else
            {
                AddExamBtn.Enabled = false;
            }
        }

        private void ExamNameTxb_TextChange(object sender, EventArgs e)
        {
            AddExamBtnEnable();
        }

        private void DurationTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
