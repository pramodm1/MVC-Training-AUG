using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingMVCAppWithTemplate.Models
{
    public class StudentRepository:IStudentRepository
    {
        public StudentRepository()
        { 
        }

        List<Student> Data = new List<Student>()
            {
                new Student() { StudentId = 101, Name = "Ravi", Branch = "CSE", Section = "A", Gender = "Male" },
                new Student() { StudentId = 102, Name = "Shubham", Branch = "ETC", Section = "B", Gender = "Male" },
                new Student() { StudentId = 103, Name = "Amar", Branch = "CSE", Section = "A", Gender = "Male" },
                new Student() { StudentId = 104, Name = "Suchita", Branch = "CSE", Section = "A", Gender = "Female" },
                new Student() { StudentId = 105, Name = "Khushbu", Branch = "ETC", Section = "B", Gender = "Female" }
            };

        public List<Student> getAllStudent()
        {
            return Data;
        }

        public Student getStudentById(int id)
        {
            return Data.FirstOrDefault(a => a.StudentId == id);
        }

        public Boolean CreateStudent(Student student)
        {
            try
            {
                var maxId = Data.Select(a => a.StudentId).Max();
                student.StudentId = maxId + 1;
                Data.Add(student);

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public Boolean UpdateStudent(Student student)
        {
            try
            {
                var resultStudent = Data.Where(a=>a.StudentId==student.StudentId).FirstOrDefault();
                resultStudent.Name = student.Name;
                resultStudent.Branch = student.Branch;
                resultStudent.Section = student.Section;
                resultStudent.Gender = student.Gender;
                

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


    }
}
