﻿using SchoolManagement.DBAccess;
using SchoolManagement.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            CrudUsers userdb = new CrudUsers();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //using (FrmLogin frmLogin = new FrmLogin())
            //{
            //    DialogResult result = frmLogin.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {
            //        int userId = 1;
            //        var user = userdb.GetUserDetails(userId);
            //        string userRole = user.Role;
            //        switch (userRole.ToLower())
            //        {
            //            case "admin":
            //                using (FrmAdmin adminForm = new FrmAdmin(userId))
            //                {
            //                    adminForm.ShowDialog();
            //                }
            //                break;

            //            case "teacher":
            //                using (FrmTeacher teacherForm = new FrmTeacher(userId))
            //                {
            //                    teacherForm.ShowDialog();
            //                }
            //                break;

            //            case "student":
            //                using (FrmStudent studentForm = new FrmStudent(userId))
            //                {
            //                    studentForm.ShowDialog();
            //                }
            //                break;

            //            default:
            //                break;
            //        }
            //    }
            //}
            FrmAdmin frmAdmin = new FrmAdmin(1);
            frmAdmin.ShowDialog();

        }
    }
}
