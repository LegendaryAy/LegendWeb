using LegendWeb2._0.Models.Services;
using LegendWeb2._0.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LegendWeb2._0.Controllers
{
    public class ContactController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly IAddressRepository _addressRepo;
        public ContactController(IUserRepository userRepository, IAddressRepository addressRepository)
        {
            _userRepo = userRepository;
            _addressRepo = addressRepository;
        }
        [HttpGet]
        public IActionResult Form()
        {
            var user = _userRepo.GetUser("1");
            var address = _addressRepo.GetAddress("1");
            var userToReturn = new ContactLocationViewModel
            {
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                City = $"{address.Street}, {address.City}, {address.Country}"

            };
            return View(userToReturn);
        }

        //[HttpPost]
        //public IActionResult Form()
        //{
        //    return View();
        //}
    }
}
