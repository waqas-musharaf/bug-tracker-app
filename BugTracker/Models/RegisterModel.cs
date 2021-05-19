using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class RegisterModel : LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
