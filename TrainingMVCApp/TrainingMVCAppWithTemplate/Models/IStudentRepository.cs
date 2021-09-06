using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingMVCAppWithTemplate.Models
{
   public interface IStudentRepository
    {
        public List<Student> getAllStudent();
        public Student getStudentById(int id);
        public Boolean CreateStudent(Student student);
        public Boolean UpdateStudent(Student student);
    }
}
