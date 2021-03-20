using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cine_printWayy.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage ="Campo Obrigatorio")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Password { get; set; }
    }
}
