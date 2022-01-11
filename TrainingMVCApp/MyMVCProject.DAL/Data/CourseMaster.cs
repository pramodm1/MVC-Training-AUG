using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVCProject.DAL.Data
{
    public class CourseMaster
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2,ErrorMessage ="Name cannot be less than 2 characters")]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
