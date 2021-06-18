using LegendWeb2._0.Data;
using LegendWeb2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Models.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly LegendDbContext _context;

        public UserRepository(LegendDbContext context)
        {
            _context = context;
        }
        public User GetUser(string id)
        {
            var user = _context.Users.FirstOrDefault(a => a.Id == id);
            return user;
        }

        public void Update(User user)
        {
            var newUser = _context.Users.FirstOrDefault(a => a.Id == user.Id);
            _context.Entry(newUser).CurrentValues.SetValues(user);
            _context.SaveChanges();
        }
    }
}
