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

namespace SchoolManagement.Dialog
{
    public partial class AddUser : KtWindow
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void ktTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktTextBox7_TextChanged(object sender, EventArgs e)
        {

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

        private void Pages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ktLabel6_Click(object sender, EventArgs e)
        {

        }

        private void ktTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktLabel4_Click(object sender, EventArgs e)
        {

        }

        private void GenderCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ktLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ktTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ktLabel1_Click(object sender, EventArgs e)
        {

        }

        private void StudentStatusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ktLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ktTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktLabel5_Click(object sender, EventArgs e)
        {

        }

        private void ktButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
