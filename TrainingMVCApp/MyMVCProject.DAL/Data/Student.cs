using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCProject.DAL.Data
{
    public class Student
    {
        public Student()
        {
            StudentInfo = new HashSet<StudentInfo>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("Student")]
        public virtual ICollection<StudentInfo> StudentInfo { get; set; }

    }

    public class StudentInfo
    {
       

        public int Id { get; set; }
        public int StudentId  { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Branch { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        [ForeignKey(nameof(StudentId))]
        [InverseProperty("StudentInfo")]
        public virtual Student Student { get; set; }
    }

    

}
