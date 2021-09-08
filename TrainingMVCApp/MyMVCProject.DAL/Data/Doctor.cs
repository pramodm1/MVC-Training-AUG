using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCProject.DAL.Data
{
    public class Doctor
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }

        //public AppUser User { get; set; }
        [Required(ErrorMessage = "Please provide Specialization")]
        public string Specialization { get; set; }

        [Required(ErrorMessage = "Please provide Years of Experience")]
        [Display(Name = "Years of Experience")]
        public int YOE { get; set; }

        [ForeignKey(nameof(UserID))]
        [InverseProperty("Doctor")]
        public virtual AppUser User { get; set; }
    }
}
