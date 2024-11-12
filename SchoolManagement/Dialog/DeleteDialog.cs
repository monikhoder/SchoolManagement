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
    public partial class DeleteDialog : KtWindow
    {
        public DeleteDialog()
        {
            InitializeComponent();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ktButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
