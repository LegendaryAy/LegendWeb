using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.ViewModels
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            GenderType = new Dictionary<string, string>();
            GenderType.Add("M", "Male");
            GenderType.Add("F", "Female");
            GenderType.Add("O", "Others");
        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords MisMatch")]
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public Dictionary<string, string> GenderType { get; set; }
    }
}
