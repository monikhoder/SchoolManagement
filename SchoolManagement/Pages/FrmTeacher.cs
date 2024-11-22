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
using SchoolManagement.Dialog;

namespace SchoolManagement.Pages
{
    public partial class FrmTeacher : KtWindow
    {
        private int userId = -1;
        public FrmTeacher(int UserId)
        {
            InitializeComponent();
            userId = UserId;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
           this.Hide();
           FrmLogin frmLogin = new FrmLogin();
           frmLogin.ShowDialog();

        }
        private void Logo_Click(object sender, EventArgs e)
        {
            if (LeftBarTeacher.Width == 63)
            {
                LeftBarTeacher.Size = new Size(120, 673);
            }
            else
            {
                LeftBarTeacher.Size = new Size(63, 673);
            }
        }
    }
}
