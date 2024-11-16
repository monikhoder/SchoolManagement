using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DBAccess
{
    
    public class CrudUsers
    {
        private readonly SchoolDBEntities db;
        public CrudUsers()
        {
            db = new SchoolDBEntities();
        }

        // Validate user credentials by return user ID
        public int ValidateUser(string username, string password)
        {
            int userID = db.Users.Where(u => u.Username == username && u.Password == password).Select(u => u.Id).FirstOrDefault();
            if (userID > 0)
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

        // Insert admin
        public void InsertAdmin(string username, string password)
        {
            if (db.Users.Any(u => u.Username == username))
            {
                throw new Exception("Username already exists.");
            }
            User admin = new User
            {
                Username = username,
                Password = password,
                RoleId = 1
            };

            db.Users.Add(admin);
            db.SaveChanges();
        }

        // insert Teacher
        public void InsertTeacher(string username, string password, string firstname, string lastname, string gender, decimal salary)
        {
            if (db.Users.Any(u => u.Username == username))
            {
                throw new Exception("Username already exists.");
            }
            var newUser = new User
            {
                Username = username,
                Password = password,
                RoleId = 2
            };
            db.Users.Add(newUser);
            db.SaveChanges();
            var newTeacher = new Teacher
            {
                UserId = newUser.Id,
                FirstName = firstname,
                LastName = lastname,
                Gender = gender,
                Salary = salary
            };
            db.Teachers.Add(newTeacher);
            db.SaveChanges();
        }
        // insert User
        public void InsertUser(string role, string username, string password, string firstname, string lastname, string gender, decimal salary, bool status)
        {
            // Check if username exists
            if (db.Users.Any(u => u.Username == username))
            {
                throw new Exception("Username already exists.");
            }

            // Check or create role
            var userRole = db.Roles.FirstOrDefault(r => r.Name == role);
            if (userRole == null)
            {
                userRole = new Role { Name = role };
                db.Roles.Add(userRole);
            }

            // Insert new user
            var newUser = new User
            {
                Username = username,
                Password = password,
                RoleId = userRole.Id,
                Firstlogin = true
            };
            db.Users.Add(newUser);

            // Handle role-specific entities
            if (role.Equals("teacher", StringComparison.OrdinalIgnoreCase))
            {
                var newTeacher = new Teacher
                {
                    UserId = newUser.Id,
                    FirstName = firstname,
                    LastName = lastname,
                    Gender = gender,
                    Salary = salary,
                    RegisterDate = DateTime.Now,
                    Status = status
                };
                db.Teachers.Add(newTeacher);
            }
            else if (role.Equals("student", StringComparison.OrdinalIgnoreCase))
            {
                var newStudent = new Student
                {
                    UserId = newUser.Id,
                    FirstName = firstname,
                    LastName = lastname,
                    Gender = gender,
                    RegisterDate = DateTime.Now,
                    Status = status
                };
                db.Students.Add(newStudent);
            }

            // Save all changes 
            db.SaveChanges();
        }


    }
}
