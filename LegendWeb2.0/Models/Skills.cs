using System;
using System.ComponentModel.DataAnnotations;

namespace LegendWeb2._0.Models
{
    public class Skills
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Progress { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
    }
}