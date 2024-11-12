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
    }
}
