using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolManagement.DBAccess
{
    
    public class CrudClassroom
    {
        private readonly SchoolDBEntities db;
        public CrudClassroom()
        {
            db = new SchoolDBEntities();
        }
        public void AddClassroom(string name , DateTime startDate , DateTime endDate)
        {
            // Check if Class name exists
            if (db.Classrooms.Any(c => c.Name == name))
            {
                throw new Exception("Class Name already exists.");
            }

            var classroom = new Classroom()
            {
               Name = name ,
               StartDate = startDate ,
               EndDate = endDate ,
          
            };         
            db.Classrooms.Add(classroom);
            db.SaveChanges();
        }
        // Get Classroom
        public List<Classroom> GetClassRoom()
        {
            return db.Classrooms.ToList();
        }
        // Add Subject 
        public void AddSubject(string name)
        {
            // Check if Subject name exists
            if (db.Subjects.Any(s => s.Name == name))
            {
                throw new Exception("Subject Name already exists.");
            }
            var subject = new Subject()
            {
                Name = name,
            };
            db.Subjects.Add(subject);
            db.SaveChanges();
        }
        // get Subject
        public List<Subject> GetSubjects()
        {
            return db.Subjects.ToList();
        }
        // Get class Count by subject ID
        public int GetClassCountBySubjectId(int subjectId)
        {
            return db.ClassSubjects.Count(c => c.SubjectId == subjectId);
        }
        // Add Class Subject
       public void AddClassSubject(int classId, int subjectId, int teacherId)
        {
            // Check if subject already added to class
            if (db.ClassSubjects.Any(c => c.ClassroomId == classId && c.SubjectId == subjectId))
            {
                throw new Exception("This Subject already added to this class.");
            }
            
            var classSubject = new ClassSubject()
            {
                ClassroomId = classId ,
                SubjectId = subjectId ,
                TeacherId = teacherId ,
                CreatedDate = DateTime.Now,
            };
            db.ClassSubjects.Add(classSubject);
            db.SaveChanges();
        }
    }
}
