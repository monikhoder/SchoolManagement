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
          
                int userID = db.Users.Where(u => u.Username == username && u.Password == password)
                                     .Select(u => u.Id)
                                     .FirstOrDefault();
                return userID > 0 ? userID : -1;
           
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
        // Get Admin
        public List<User> GetAdmins (string search)
        {
            return db.Users.Where(u => u.Role.Name == "Admin" && (u.Username.Contains(search))).ToList();
        }

        // Get Teacher
        public List<Teacher> GetTeachers(string search)
        {
            return db.Teachers .Where(t => t.FirstName.Contains(search) || t.LastName.Contains(search)).ToList();
        }
        // Get Student
        public List<Student> GetStudents (string search)
        {
            return db.Students.Where(s =>  s.FirstName.Contains(search) || s.LastName.Contains(search)).ToList();
        }
        //Get Student Count
        public int StudentCount()
        {
            return db.Students.Count();
        }
        //Get Teacher Count
        public int TeacherCount()
        {
            return db.Teachers.Count();
        }
    }
    
}
