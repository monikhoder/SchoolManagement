using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DBAccess
{
    
    public class CrudUsers
    {
        private readonly DBSchoolEntities db;
        public CrudUsers()
        {
            db = new DBSchoolEntities();
        }

        // Validate user credentials by return user ID
        public int ValidateUser(string username, string password)
        {
            int userID = db.Users.Where(u => u.Username == username && u.Password == password).Select(u => u.Id).FirstOrDefault();
            if (userID != null)
            {
                return userID;
            }          
            return -1;
        }
        // Get User Role by Id
        public string GetUserRole(int userId)
        {
            string role = db.Users
            .Where(u => u.Id == userId)
            .Select(u => u.Role.Name)
            .FirstOrDefault();
            return role;
        }
      

       
    }
}
