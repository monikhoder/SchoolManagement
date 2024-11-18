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
    public partial class EnrollStudent : KtWindow
    {
        CrudClassroom crudClassroom = new CrudClassroom();
        CrudUsers users = new CrudUsers();
        public EnrollStudent()
        {
            InitializeComponent();
        }

        private async void EnrollStudent_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(100);
            });
            LoadCmb();
        }
        private void LoadCmb()
        {
            var classrom = crudClassroom.GetClassRoom();
            var student = users.GetStudents("");

        }
    }
}
