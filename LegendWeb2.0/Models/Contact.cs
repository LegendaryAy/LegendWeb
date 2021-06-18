using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Models
{
    public class Contact
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [StringLength(40)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(40)]
        [Required]
        public string LastName { get; set; }
        [StringLength(40)]
        [Required]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
