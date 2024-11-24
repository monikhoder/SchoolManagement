using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DBAccess
{
    public class CrudExam
    {
        private readonly SchoolDBEntities db;
        public CrudExam()
        {
            db = new SchoolDBEntities();
        }
        public List<Exam> GetAllExam()
        {
            return db.Exams.ToList();
        }
        public List<ExamResult> GetAllExamResult()
        {
            return db.ExamResults.ToList();
        }
        public List<Exam> GetAllExamByName(string text)
        {
            string name = text.Length >= 5 ? text.Substring(0, 5) : text;
            return db.Exams
                     .Where(e => e.Name.StartsWith(name))
                     .ToList();
        }
        public List<ExamResult> GetAllExamResultByName(string text)
        {
            string name = text.Length >= 5 ? text.Substring(0, 5) : text;
            return db.ExamResults
                     .Where(e => e.Exam.Name.StartsWith(name))
                     .ToList();
        }
        public string GetClassroomByExamId(int examId)
        {
            string classroom = (from e in db.Exams
                                join cs in db.ClassSubjects on e.ClassSubjectId equals cs.Id
                                join c in db.Classrooms on cs.ClassroomId equals c.Id
                                where e.Id == examId
                                select c.Name).FirstOrDefault();
            return classroom;
        }
        public string GetSubjectByExamId(int examId)
        {
            string subject = (from e in db.Exams
                              join cs in db.ClassSubjects on e.ClassSubjectId equals cs.Id
                              join s in db.Subjects on cs.SubjectId equals s.Id
                              where e.Id == examId
                              select s.Name).FirstOrDefault();
            return subject;
        }
        public string GetTeacherByExamId(int examId)
        {
            string teacher = (from e in db.Exams
                              join cs in db.ClassSubjects on e.ClassSubjectId equals cs.Id
                              join t in db.Teachers on cs.TeacherId equals t.Id
                              where e.Id == examId
                              select t.FirstName + " " + t.LastName).FirstOrDefault();
            return teacher;
        }
        public string GetTeacherByExamResultId(int examId, int userId)
        {
            string teacher = (from er in db.ExamResults
                              join e in db.Exams on er.ExamId equals e.Id
                              join cs in db.ClassSubjects on e.ClassSubjectId equals cs.Id
                              join t in db.Teachers on cs.TeacherId equals t.Id
                              join ce in db.ClassEnrollments on cs.ClassroomId equals ce.Id
                              where er.Id == examId && ce.Id == userId
                              select t.FirstName + " " + t.LastName).FirstOrDefault();
            return teacher;
        }
        public string GetSubjectByExamResultId(int examId, int userId)
        {
            string subject = (from er in db.ExamResults
                              join e in db.Exams on er.ExamId equals e.Id
                              join cs in db.ClassSubjects on e.ClassSubjectId equals cs.Id
                              join s in db.Subjects on cs.SubjectId equals s.Id
                              join ce in db.ClassEnrollments on cs.ClassroomId equals ce.Id
                              where er.Id == examId && ce.Id == userId
                              select s.Name).FirstOrDefault();
            return subject;
        }
        //Create schedule exam
        public void AddExam(string name,int classSubjectId, DateTime date, int duratin )
        {
            //check if this subject already has an exam
            if (db.Exams.Any(e => e.ClassSubjectId == classSubjectId))
            {
                throw new Exception("This subject already has an exam");
            }
            var newExam = new Exam
            {
                Name = name,
                ClassSubjectId = classSubjectId,
                ExamDate = date,
                Duration = duratin
            };
            db.Exams.Add(newExam);
            db.SaveChanges();           
        }
        //Get exam list
        public List<examlist> GetExamList()
        {
            var examList = (from e in db.Exams
                            join cs in db.ClassSubjects on e.ClassSubjectId equals cs.Id
                            join c in db.Classrooms on cs.ClassroomId equals c.Id
                            join s in db.Subjects on cs.SubjectId equals s.Id
                            join t in db.Teachers on cs.TeacherId equals t.Id
                            select new examlist
                            {
                                Id = e.Id,
                                Name = e.Name,
                                Classroom = c.Name,
                                Subject = s.Name,
                                Teacher = t.FirstName + " " + t.LastName,
                                ExamDate = e.ExamDate,
                                Duration = e.Duration
                            }).ToList();
            return examList;
        }
        //Get up coming exam count
        public int GetUpComingExamCount()
        {
            var upComingExamCount = db.Exams
                .Where(e => e.ExamDate >= DateTime.Now)
                .Count();
            return upComingExamCount;
        }

        
    }
    public class examlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Classroom { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public DateTime ExamDate { get; set; }
        public int Duration { get; set; }
    }
}
