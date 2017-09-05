using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotation.Models
{
    public class Student
    {
    
        [Required]
        public int StudId { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Length must be upto 10 chars")]
        [StringLength(10, ErrorMessage = "Length must be upto 10 chars")]
       
        public string StudName { get; set; }
    }
}