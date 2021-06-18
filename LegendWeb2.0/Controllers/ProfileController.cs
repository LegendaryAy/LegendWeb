using LegendWeb2._0.Models;
using LegendWeb2._0.Models.Services;
using LegendWeb2._0.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LegendWeb2._0.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly IAddressRepository _addressRepo;
        private readonly ISkillsRepository _skillsRepo;
        private readonly IProjectsRepository _projectsRepo;
        private readonly UserBioViewModel _userToEdit;
        private readonly List<SkillsViewModel> _skillToEdit;
        private readonly List<ProjectsViewModel> _projectsToEdit;

        public ProfileController(IUserRepository userRepository, IAddressRepository addressRepository, ISkillsRepository skillsRepository, IProjectsRepository projectsRepository)
        {
            _userRepo = userRepository;
            _addressRepo = addressRepository;
            _skillsRepo = skillsRepository;
            _projectsRepo = projectsRepository;
            _userToEdit = new UserBioViewModel();
            _skillToEdit = new List<SkillsViewModel>();
            _projectsToEdit = new List<ProjectsViewModel>();
        }
        [HttpGet]
        public IActionResult Board()
        {
            var user = _userRepo.GetUser("1");
            var address = _addressRepo.GetAddress("1");
            var userToReturn = new ProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Description = user.Description,
                Education = user.Education,
                DateOfBirth = user.DateOfBirth,
                Degree = user.Degree,
                PhoneNumber = user.PhoneNumber,
                ProfileImageUrl = user.ImageThumbNailUrl,
                Bio = user.Bio,
                WorkStatus = user.WorkStatus,
                Age = user.Age,
                Gender = user.Gender,
                Job = user.JobTitle,
                City = $"{address.City}, {address.Country}",
                Skills = _skillsRepo.GetSkills("1"),
                Projects = _projectsRepo.GetProjects("1")

            };
            return View(userToReturn);
        }
        [HttpGet]
        public IActionResult EditBio()
        {
            var user = _userRepo.GetUser("1");
            _userToEdit.FirstName = user.FirstName;
            _userToEdit.LastName = user.LastName;
            _userToEdit.Gender = user.Gender;
            _userToEdit.PhoneNumber = user.PhoneNumber;
            _userToEdit.DateOfBirth = user.DateOfBirth;
            _userToEdit.WorkStatus = user.WorkStatus;
            _userToEdit.Job = user.JobTitle;
            _userToEdit.Age = user.Age;
            _userToEdit.Bio = user.Bio;
            _userToEdit.Education = user.Education;
            _userToEdit.Degree = user.Degree;
            _userToEdit.Description = user.Description;

            return View(_userToEdit);
        }
        [HttpPost]
        public IActionResult EditBio(UserBioViewModel model)
        {
            var user = _userRepo.GetUser("1");
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.DateOfBirth = model.DateOfBirth;
            user.Gender = model.Gender;
            user.PhoneNumber = model.PhoneNumber;
            user.WorkStatus = model.WorkStatus;
            user.Age = model.Age;
            user.Bio = model.Bio;
            user.JobTitle = model.Job;
            user.Education = model.Education;
            user.Degree = model.Degree;
            user.Description= model.Description;
            _userRepo.Update(user);
            return RedirectToAction("Board", "Profile");
        }

        [HttpGet]
        public IActionResult EditSkills()
        {
            var skills = _skillsRepo.GetSkills("1");
            for(var i= 0; i<skills.Count; i++)
            {
                var x = new SkillsViewModel { Name = skills[i].Name, Progress = skills[i].Progress };
                _skillToEdit.Add(x);
            }
            return View(_skillToEdit);
        }
        
        [HttpPost]
        public IActionResult EditSkills(List<SkillsViewModel> model)
        {
            var skills = _skillsRepo.GetSkills("1");
            for(var i = 0; i<model.Count; i++)
            {
                skills[i].Name = model[i].Name;
                skills[i].Progress = model[i].Progress;
            }
            foreach (var skill in skills)
            {
                _skillsRepo.Update(skill);
            }
            return RedirectToAction("Board", "Profile");
        }
        [HttpGet]
        public IActionResult EditProjects()
        {
            var projects = _projectsRepo.GetProjects("1");
            for (var i = 0; i < projects.Count; i++)
            {
                var x = new ProjectsViewModel { Name = projects[i].Name, Body = projects[i].Body, ImageUrl = "images/work.jpg" };
                _projectsToEdit.Add(x);
            }
            return View(_projectsToEdit);
        }

        [HttpPost]
        public IActionResult EditProjects(List<ProjectsViewModel> model)
        {
            var projects = _projectsRepo.GetProjects("1");
            for (var i = 0; i < model.Count; i++)
            {
                projects[i].Name = model[i].Name;
                projects[i].Body = model[i].Body;
            }
            foreach (var project in projects)
            {
                _projectsRepo.Update(project);
            }
            return RedirectToAction("Board", "Profile");
        }
    }
}
