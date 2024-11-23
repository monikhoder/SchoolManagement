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
        // get end date of class
        private DateTime GetClassEndDate(int classId)
        {
            return db.Classrooms.Where(c => c.Id == classId).Select(c => c.EndDate).FirstOrDefault();
        }
        // Enroll Student
        public void EnrollStudent(int classId, int studentId)
        {
            // Check if student already enrolled in class
            if (db.ClassEnrollments.Any(e => e.ClassroomId == classId && e.StudentId == studentId))
            {
                throw new Exception("Student already enrolled in this class.");
            }
            // Check if class is not completed
            if (db.Classrooms.Any(c => c.Id == classId && c.EndDate < DateTime.Now))
            {
                throw new Exception("Class is already completed can not enroll student");
            }

            var enrollment = new ClassEnrollment()
            {
                ClassroomId = classId ,
                StudentId = studentId ,
                EnrollmentDate = DateTime.Now,
                EndDate = GetClassEndDate(classId),
            };
            db.ClassEnrollments.Add(enrollment);
            db.SaveChanges();
        }
        //Get classEnroll count by class ID
        public int GetClassEnrollCountByClassId(int classId)
        {
            return db.ClassEnrollments.Count(e => e.ClassroomId == classId);
        }
        //Get all class enrollment
        public List<ClassEnrollment> GetAllClassEnrollment()
        {
            return db.ClassEnrollments.ToList();
        }
        //Get total student by class id
        public int GetTotalStudentByClassId(int classId)
        {
            int num = db.ClassEnrollments
                        .Where(ce => ce.ClassroomId == classId)
                        .Count();
            return num;
        }
        //Search classroom name
        public List<ClassEnrollment> GetAllClassEnrollmentByName(string text)
        {
            string name = text.Length >= 5 ? text.Substring(0, 5) : text;
            return db.ClassEnrollments
                     .Where(ce => ce.Classroom.Name.StartsWith(name))
                     .ToList();
        }
       
        // Get Class Subject by class ID
        public List<SubjectData> GetClassSubjectByClassId(int classId)
        {
            return db.ClassSubjects
                .Where(cs => cs.ClassroomId == classId)
                .Select(cs => new SubjectData
                {
                    Id = cs.Id,
                    Name = cs.Subject.Name
                })
                .ToList();           
        }
        // Get class count
        public int GetClassCount()
        {
            return db.Classrooms.Count();
        }
        // Get Subject count by class ID
        public int GetSubjectCountByClassId(int classId)
        {
            return db.ClassSubjects.Count(cs => cs.ClassroomId == classId);
        }
    }
    public class SubjectData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
