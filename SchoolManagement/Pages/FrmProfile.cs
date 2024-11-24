using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using KimTools.WinForms;
using SchoolManagement.DBAccess;
using SchoolManagement.Dialog;

namespace SchoolManagement.Pages
{
    public partial class FrmProfile : KtWindow
    {
        private int UserId;
        private string role;
        CrudUsers Users;
        public FrmProfile(int Id)
        {
            InitializeComponent();
            Users = new CrudUsers();
            UserId = Id;
            role = Users.GetUserRole(Id);
           
        }
        private void SaveBtnEnable(string role)
        {
            if (role.ToLower() == "admin")
            {
                if (UsernameTxb.Text.Length > 0)
                {
                    SaveBtn.Enabled = true;
                }
                else
                {
                    SaveBtn.Enabled = false;
                }
            }

        }
        private void ChangePassEnable()
        {
            if (OldPasswordTxb.Text.Length > 0 && NewPasswordTxb.Text.Length > 0)
            {
                ChangePassBtn.Enabled = true;
            }
            else
            {
               ChangePassBtn.Enabled = false;
            }
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            var currentUser = Users.GetUserbyId(UserId);
            if (role.ToLower() == "admin")
            {
                UsernameTxb.Text = currentUser.Username;
            }else if (role.ToLower() == "teacher")
            {
                var teacher = Users.GetTeacherById(UserId);
                FirstNameTxb.Text = teacher.FirstName;
                LastNameTxb.Text = teacher.LastName;
                FirstNameTxb.Enabled = true;
                LastNameTxb.Enabled = true ;
                UsernameTxb.Text = currentUser.Username;
            }else if (role.ToLower() == "student")
            {
                var student = Users.GetStudentById(UserId);
                FirstNameTxb.Text = student.FirstName;
                LastNameTxb.Text = student.LastName;
                FirstNameTxb.Enabled = true;
                LastNameTxb.Enabled = true;
                UsernameTxb.Text = currentUser.Username;
            }

        }
        private void Textbox_TextChange(object sender, EventArgs e)
        {
            SaveBtnEnable(role);
            UpdatepassEnable();
        }
        private void UpdatepassEnable()
        {
            if (OldPasswordTxb.Text.Length > 0 && NewPasswordTxb.Text.Length > 0)
            {
                ChangePassBtn.Enabled = true;
            }
            else
            {
                ChangePassBtn.Enabled = false;
            }
        }
        private void Nospace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }        

        }

        private void PhoneNumberTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Users.UpdatePassword(UserId, NewPasswordTxb.Text, OldPasswordTxb.Text);
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = "Password Changed Successfully";
                alertDialogs.AlertLbl.LabelColor = KtColor.Tailwind_Violet;
                alertDialogs.AlertIcon.Image = Properties.Resources._checked;
                alertDialogs.ShowDialog();
            }
            catch (Exception ex) {
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertLbl.LabelColor = KtColor.Danger;
                alertDialogs.AlertIcon.Image = Properties.Resources.warning_icon;
                alertDialogs.ShowDialog();
            }


            
        }
    }
}
