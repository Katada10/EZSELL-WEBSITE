using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class User
    {
        [Required, Key]
        public int AcctNumber { get; set; }

        [Required, MaxLength(30)]
        public string UserName { get; set; }

        [Required, MaxLength(30)]
        public string Email { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    
        public int rating { get; set; }
    }
}
