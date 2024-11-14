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
      

       
    }
}
