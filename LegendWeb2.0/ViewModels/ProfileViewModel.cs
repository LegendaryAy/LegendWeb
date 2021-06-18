using LegendWeb2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.ViewModels
{
    public class ProfileViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Job { get; set; }
        public string DateOfBirth { get; set; }
        public string Degree { get; set; }
        public string Education { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkStatus { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Projects> Projects { get; set; }
    }
}
