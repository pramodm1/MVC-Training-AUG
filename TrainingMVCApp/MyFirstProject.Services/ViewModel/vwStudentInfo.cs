using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Services.ViewModel
{
   public class vwStudentInfo
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Branch { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
