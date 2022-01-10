using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyMVCProject.DAL.Data
{
    public class VoterInfo
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
