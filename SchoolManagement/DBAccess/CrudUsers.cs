using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DBAccess
{
    
    public class CrudUsers
    {
        private readonly TeamProjectEntities db;
        public CrudUsers()
        {
            db = new TeamProjectEntities();
        }

        // Validate user credentials
        public int ValidateUser(string username, string password)
        {
            // this function will return the user id if the credentials are valid
            // otherwise it will return -1
           
            return -1;
        }
        // Get User details by user id parameter (that should be return user detail such as name, username, etc.)
       public User GetUserDetails(int userId)
        {
            return null; //modify here
        }

       
    }
}
