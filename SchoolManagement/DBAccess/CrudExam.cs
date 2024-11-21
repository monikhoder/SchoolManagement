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
        public void AddExam(string name, int classId ,int classSubjectId, DateTime date, int duratin )
        {
            var newExam = new Exam
            {
                Name = name,
                ClassSubjectId = classSubjectId,
                ExamDate = date,
                Duration = duratin
            };
           
        }
    }
}
