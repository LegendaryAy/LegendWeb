using LegendWeb2._0.Data;
using LegendWeb2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Models.Services
{
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly LegendDbContext _context;

        public ProjectsRepository(LegendDbContext context)
        {
            _context = context;
        }
        public List<Projects> GetProjects(string userId)
        {
            var projects = _context.Projects.Where(p => p.UserId == userId).ToList();
            return projects;
        }

        public void Update(Projects project)
        {
            var newProject = _context.Projects.FirstOrDefault(a => a.Id == project.Id);
            _context.Entry(newProject).CurrentValues.SetValues(project);
            _context.SaveChanges();
        }
    }
}
