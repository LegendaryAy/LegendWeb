using LegendWeb2._0.Data;
using LegendWeb2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Models.Services
{
    public class ContactRepository : IContactRepository
    {
        private readonly LegendDbContext _context;

        public ContactRepository(LegendDbContext context)
        {
            _context = context;
        }
        public void CreateMessage(Contact contact)
        {
            _context.Contact.Add(contact);
            _context.SaveChanges();
        }
    }
}
