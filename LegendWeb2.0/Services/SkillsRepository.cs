using LegendWeb2._0.Data;
using LegendWeb2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Models.Services
{
    public class SkillsRepository : ISkillsRepository
    {
        private readonly LegendDbContext _context;

        public SkillsRepository(LegendDbContext context)
        {
            _context = context;
        }
        public List<Skills> GetSkills(string userId)
        {
            var skills = _context.Skills.Where(s => s.UserId == userId).ToList();
            return skills;
        }

        public void Update(Skills skills)
        {
            var newSkills = _context.Skills.FirstOrDefault(a => a.Id == skills.Id);
            _context.Entry(newSkills).CurrentValues.SetValues(skills);
            _context.SaveChanges();
        }
    }
}
