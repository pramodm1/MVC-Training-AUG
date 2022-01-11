using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVCProject.DAL.Data
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Course name cannot be less than or equal to 2 characters")]
        public string Name { get; set; }

        //public AppUser User { get; set; }
        [Required(ErrorMessage = "Please provide Description")]
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
