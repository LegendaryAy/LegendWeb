using System;
using System.ComponentModel.DataAnnotations;

namespace LegendWeb2._0.Models
{
    public class Address
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [StringLength(40)]
        [Required]
        public string Street { get; set; }
        [StringLength(40)]
        [Required]
        public string City { get; set; }
        [StringLength(40)]
        public string Country { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
    }
}