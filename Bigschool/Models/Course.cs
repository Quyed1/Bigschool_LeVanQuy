using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bigschool.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lencturer { get; set; }
        [Required]
        public string LencturerId { get; set; }
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}