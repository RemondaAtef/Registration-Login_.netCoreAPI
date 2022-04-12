using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tagroba1000.Models
{
    public class UserVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [MinLength(3, ErrorMessage = "Min Len 3")]
        [MaxLength(50, ErrorMessage = "Max Len 50")]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
