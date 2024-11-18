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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace SchoolManagement.Dialog
{
    public partial class AddClass : KtWindow
    {
        CrudClassroom classroom = new CrudClassroom();
        public AddClass()
        {
            InitializeComponent();
        }

        private void ktTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktLabel5_Click(object sender, EventArgs e)
        {

        }

        private void ktDate1_ValueChanged(object sender, EventArgs e)
        {

        }

    

        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                classroom.AddClassroom(ClassnameTxb.Text, ClassStartDate.Value, ClassEndDate.Value);
                // Clear input fields
                ClassnameTxb.Text = "";
                ClassStartDate.Value = DateTime.Now;
                ClassEndDate.Value = DateTime.Now;

                // Display success message
                AlertDialogs alertDialogs = new AlertDialogs();
                alertDialogs.AlertLbl.Text = "Class Added Succesful";
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

        private void ClassnameTxb_TextChange(object sender, EventArgs e)
        {
            AddClassBtnEnable();
        }
        private void AddClassBtnEnable()
        {
            if (ClassnameTxb.Text != "" && ClassStartDate.Value < ClassEndDate.Value)
            {
                AddClassBtn.Enabled = true;
            }
            else
            {
                AddClassBtn.Enabled = false;
            }

        }
    }
}
