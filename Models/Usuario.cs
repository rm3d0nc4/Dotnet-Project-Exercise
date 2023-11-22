using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dot_project.Models
{
    public class Usuario
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Display(Name = "Senha")]
        public string Password {get; set; }
        [Display(Name = "Email"), RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }
    }
}