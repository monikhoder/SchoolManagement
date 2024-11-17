using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimTools.WinForms;
using SchoolManagement.DBAccess;
using SchoolManagement.Properties;
using SmartFormat.Core.Extensions;

namespace SchoolManagement.Dialog
{
    public partial class AddUser : KtWindow
    {
        CrudUsers CrudUsers = new CrudUsers();
        public AddUser()
        {
            InitializeComponent();
        }

        private void tcSwBtn_Click(object sender, EventArgs e)
        {
            Pages.SetPage(Teacher);
        }

        private void StSwBtn_Click(object sender, EventArgs e)
        {
            Pages.SetPage(Student);
        }

        private void AdSwBtn_Click(object sender, EventArgs e)
        {
            Pages.SetPage(Admin);
        }

        private void InsertAdminBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CrudUsers.InsertUser("admin", AdminUsernameTxb.Text.Trim(), AdminPassTxb.Text.Trim(),"","","",0,true);
                //reset texbox
                AdminUsernameTxb.Text = "";
                AdminPassTxb.Text = "";

                //alert 
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = "Admin Added Succesful";
                alertDialogs.AlertLbl.LabelColor = KtColor.Tailwind_Violet;
                alertDialogs.AlertIcon.Image = Properties.Resources._checked;
                alertDialogs.ShowDialog();
            }catch (Exception ex)
            {
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertLbl.LabelColor = KtColor.Danger;
                alertDialogs.AlertIcon.Image = Properties.Resources.warning_icon;
                alertDialogs.ShowDialog();
            }
        }

        private void AdminUsernameTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; 
            }

        }

        private void AdminUsernameTxb_TextChange(object sender, EventArgs e)
        {
            AdminInsertBtnEnable();
           
        }

        private void AdminInsertBtnEnable()
        {
            if (AdminUsernameTxb.Text.Length > 0 && AdminPassTxb.Text.Length > 0)
            {
                InsertAdminBtn.Enabled = true;
            }
            else
            {
                InsertAdminBtn.Enabled = false;
            }                 

        }

        private void AddTeacherBtn_Click(object sender, EventArgs e)
        {
            string role = "teacher";
            string username = TeacherUsernameTxb.Text;
            string pass = TeacherPassTxb.Text;
            string firstname = TeacherFirstNameTxb.Text;
            string lastname = TeacherLastNameTxb.Text;
            string gender = TeacherGenderCmb.Text;
            decimal salary = 0; if (TeacherSalaryTxb.Text.Length > 0) {salary = Convert.ToDecimal(TeacherSalaryTxb.Text); }
            bool status = true;
            if(TeacherStatusCmb.Text.ToLower() == "nonactive") {status = false;}
            try
            {
                CrudUsers.InsertUser(role,username,pass,firstname,lastname,gender,salary,status);

                // Clear input fields
                TeacherUsernameTxb.Text = "";
                TeacherPassTxb.Text = "";
                TeacherFirstNameTxb.Text = "";
                TeacherLastNameTxb.Text = "";
                TeacherSalaryTxb.Text = "";

                // Display success message
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = "Teacher Added Succesful";
                alertDialogs.AlertLbl.LabelColor = KtColor.Tailwind_Violet;
                alertDialogs.AlertIcon.Image = Properties.Resources._checked;
                alertDialogs.ShowDialog();
            }
            catch (Exception ex)
            {
                // Display error message
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertLbl.LabelColor = KtColor.Danger;
                alertDialogs.AlertIcon.Image = Properties.Resources.warning_icon;
                alertDialogs.ShowDialog();
            }

        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            string role = "student";
            string username = StudentUsernameTxb.Text;
            string pass = StudentPassTxb.Text;
            string firstname = StudentFirstNameTxb.Text;
            string lastname = StudentLastNameTxb.Text;
            string gender = StudentGenderCmb.Text;
            decimal salary = 0;
            bool status;
            if (StudentStatusCmb.Text.ToLower() == "nonactive") { status = false; }else {  status = true; }

            try
            {
                CrudUsers.InsertUser(role, username, pass, firstname, lastname, gender, salary, status);

                // Clear input fields
                StudentUsernameTxb.Text = "";
                StudentPassTxb.Text = "";
                StudentFirstNameTxb.Text = "";
                StudentLastNameTxb.Text = "";

                // Display success message
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = "Student Added Succesful";
                alertDialogs.AlertLbl.LabelColor = KtColor.Tailwind_Violet;
                alertDialogs.AlertIcon.Image = Properties.Resources._checked;
                alertDialogs.ShowDialog();
            }
            catch (Exception ex)
            {
                // Display error message
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = ex.Message;
                alertDialogs.AlertLbl.LabelColor = KtColor.Danger;
                alertDialogs.AlertIcon.Image = Properties.Resources.warning_icon;
                alertDialogs.ShowDialog();
            }

        }
        private void StudentInsertBtnEnable()
        {
            if (StudentUsernameTxb.Text.Length > 0 && StudentPassTxb.Text.Length > 0 && StudentFirstNameTxb.Text.Length > 0 && StudentLastNameTxb.Text.Length > 0)
            {
               AddStudentBtn.Enabled = true;
            }
            else
            {
                AddStudentBtn.Enabled = false;
            }


        }
        private void TeacherInsertBtnEnable()
        {
            if (TeacherUsernameTxb.Text.Length > 0 && TeacherPassTxb.Text.Length > 0 && TeacherFirstNameTxb.Text.Length > 0 && TeacherLastNameTxb.Text.Length > 0 && TeacherSalaryTxb.Text.Length > 0)
            {
                AddTeacherBtn.Enabled = true;
            }
            else
            {
                AddTeacherBtn.Enabled = false;
            }


        }


        private void TeacherSalaryTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;

            // Allow control keys (like Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && !txtBox.Text.Contains('.'))
            {
                return;
            }

            // If none of the above, disallow the input
            e.Handled = true;
        }

        private void StudentTxb_TextChange(object sender, EventArgs e)
        {
            StudentInsertBtnEnable();
        }

        private void TeacherTxb_TextChange(object sender, EventArgs e)
        {
            TeacherInsertBtnEnable();
        }
    }
}
