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

namespace SchoolManagement.Pages
{
    public partial class FrmProfile : KtWindow
    {
        public FrmProfile()
        {
            InitializeComponent();
        }
        private void SaveBtnEnable()
        {
            if (FirstNameTxb.Text.Length > 0 && LastNameTxb.Text.Length > 0 && UsernameTxb.Text.Length > 0 && PhoneNumberTxb.Text.Length > 0 && AddressTxb.Text.Length > 0)
            {
                SaveBtn.Enabled = true;
            }
            else
            {
                SaveBtn.Enabled = false;
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
            
        }
        private void Textbox_TextChange(object sender, EventArgs e)
        {
            SaveBtnEnable();
            ChangePassEnable();
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
    }
}
