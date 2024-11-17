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
    public partial class AlertDialogs : KtWindow
    {
        
        public AlertDialogs()
        {
            InitializeComponent();
        }

        private void ktLabel1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CloseTimer.Start();
        }
        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            CloseTimer.Stop();
            this.Close();
        }
    }
}
