using LegendWeb2._0.Data;
using LegendWeb2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Models.Services
{
    public class AddressRepository : IAddressRepository
    {
        private readonly LegendDbContext _context;

        public AddressRepository(LegendDbContext context)
        {
            _context = context;
        }
        public Address GetAddress(string userId)
        {
            var address = _context.Address.FirstOrDefault(a => a.UserId == userId);
            return address;
        }

        public void Update(Address address)
        {
            var newAddress = _context.Address.FirstOrDefault(a => a.Id == address.Id);
            _context.Entry(newAddress).CurrentValues.SetValues(address);
            _context.SaveChanges();
        }
    }
}
