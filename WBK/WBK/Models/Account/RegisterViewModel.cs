using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBK.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Blijf tussen de 5 en 25 tekens!", MinimumLength = 5)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Wachtwoord bevestigen komt niet overeen, check opnieuw!")]
        [StringLength(255, ErrorMessage = "Blijf tussen de 5 en 25 tekens!", MinimumLength = 5)]
        public string ConfirmPassword { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string PrePesition { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
