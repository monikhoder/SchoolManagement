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
using SchoolManagement.Pages;
namespace SchoolManagement
{
    public partial class FrmLogin : KtWindow
    {
        CrudUsers userdb = new CrudUsers();
        public int UserId { get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
           
        }
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnLoginEnable()
        {
            InvalidUserLbl.Visible = false;
            if (UsernameTxb.Text.Trim().Length > 0 && PasswordTxb.Text.Trim().Length > 0)
            {
                BtnLogin.Enabled = true;
            }else
            {
                BtnLogin.Enabled = false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            BtnLoginEnable();
        }

        private void UsernameTxb_TextChange(object sender, EventArgs e)
        {
            BtnLoginEnable();
            InvalidUserLbl.Visible = false;
        }

        private void PasswordTxb_TextChange(object sender, EventArgs e)
        {
            BtnLoginEnable();
            InvalidUserLbl.Visible=false;
        }

        private void UsernameTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PasswordTxb.Focus();
            }

        }

        private void PasswordTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (UsernameTxb.Text.Trim().Length > 0 && PasswordTxb.Text.Trim().Length > 0)
                {
                    BtnLogin_Click(sender, e);
                }
                
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           int userId = userdb.ValidateUser(UsernameTxb.Text.ToLower(), PasswordTxb.Text);

            if (userId <= 0)
            {
                InvalidUserLbl.Visible = true;
                BtnLogin.Enabled = false;
            }
            else
            {
                UserId = userId; 
                DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
    }
    
}
