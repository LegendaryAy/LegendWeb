using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Models
{
    public class User : IdentityUser
    {
        [StringLength(40)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(40)]
        [Required]
        public string LastName { get; set; }
        public string Description { get; set; }
        [StringLength(40)]
        public string Degree { get; set; }
        [StringLength(40)]
        public string WorkStatus { get; set; }        
        public string Bio { get; set; }
        public string DateOfBirth { get; set; }
        public string JobTitle { get; set; }
        public string Age { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbNailUrl { get; set; }
        [StringLength(40)]
        public string Education { get; set; }
        public Address Address { get; set; }
        public string Gender { get; set; }
        public ICollection<Skills> Skills { get; set; } = new HashSet<Skills>();
        public ICollection<Projects> Projects { get; set; } = new HashSet<Projects>();
    }
}
