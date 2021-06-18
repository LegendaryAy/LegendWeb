using LegendWeb2._0.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb2._0.Data
{
    public class LegendDbContext : IdentityDbContext<User>
    {
            public LegendDbContext(DbContextOptions<LegendDbContext> options) : base(options)
            {

            }

            //Calling the Seeding methods
            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                this.SeedUser(builder);
                this.SeedAddress(builder);
                this.SeedSkills(builder);
                this.SeedProjects(builder);
            }

            //Seeding the Database
            private void SeedUser(ModelBuilder builder)
            {
                var user = new User
                {
                    Id = "1",
                    FirstName = "Ayobami",
                    LastName = "Fadeni",
                    Email = "fadeniayobami@gmail.com",
                    PhoneNumber = "+234-8106322363",
                    ImageUrl = "images/1.jpg",
                    ImageThumbNailUrl = "images/2.jpg",
                    Bio = "Experienced Software Developer adept in bringing forth expertise in design, installation, testing and maintenance of software systems. Equipped with a diverse and promising skill-set. Proficient in various platforms, languages, and embedded systems. Experienced with the latest cutting edge development tools and procedures. Able to effectively self-manage during independent projects, as well as collaborate as part of a productive team.",
                    Description = "I am a Software Engineer from Lagos",
                    DateOfBirth = "17 September, 1998",
                    Degree = "Proficient",
                    WorkStatus = "Available",
                    Education = "B.Sc (Hons) Biochemistry, Obafemi Awolowo University",
                    Gender = "Male",
                    JobTitle = "Intermediate Software Engineer",
                    Age = "23"
                };
                builder.Entity<User>().HasData(user);
            }

            private void SeedAddress(ModelBuilder builder)
            {
                var address = new Address
                {
                    Street = "No 8, Alaba Obe Street, Off Ajuwon Road",
                    City = "Lagos",
                    Country = "Nigeria",
                    UserId = "1"
                };
                builder.Entity<Address>().HasData(address);
            }
            private void SeedSkills(ModelBuilder builder)
            {
                var a = new Skills { Name = "HTML", Progress = 100, UserId = "1" };
                var b = new Skills { Name = "CSS", Progress = 95, UserId = "1" };
                var c = new Skills { Name = "JavaScript", Progress = 89, UserId = "1" };
                var d = new Skills { Name = "C#", Progress = 90, UserId = "1" };
                var e = new Skills { Name = "SQL", Progress = 82, UserId = "1" };
                var f = new Skills { Name = "Python", Progress = 76, UserId = "1" };
                builder.Entity<Skills>().HasData(a);
                builder.Entity<Skills>().HasData(b);
                builder.Entity<Skills>().HasData(c);
                builder.Entity<Skills>().HasData(d);
                builder.Entity<Skills>().HasData(e);
                builder.Entity<Skills>().HasData(f);
            }

            private void SeedProjects(ModelBuilder builder)
            {
                var a = new Projects { Name = "Password Generator", Body = "A Javascript application that creates random passwords", ImageUrl = "images/work1.png", Url = "https://legendaryay.github.io/PasswordGenerator/", UserId = "1" };
                var b = new Projects { Name = "LegendTravels", Body = "A Travel website template showing different cities and means to travel", ImageUrl = "images/work2.png", Url = "https://legendaryay.github.io/LegendTravels/", UserId = "1" };
                var c = new Projects { Name = "LegendHealth", Body = "An Health website template showing different means of achieving good health", ImageUrl = "images/work3.png", Url = "https://legendaryay.github.io/LegendHealth/", UserId = "1" };
                var d = new Projects { Name = "LegendDesign", Body = "A template showing different designs created by the owner", ImageUrl = "images/work4.png", Url = "https://legendaryay.github.io/LegendDesign/", UserId = "1" };
                var e = new Projects { Name = "ContactMangerAPI", Body = "A RESTful API for managing contacts", ImageUrl = "images/work5.png", Url = "https://github.com/LegendaryAy/ContactManagerApi", UserId = "1" };
                var f = new Projects { Name = "LegendBank", Body = "A simple Bank application that perorms basic transactions", ImageUrl = "images/work6.png", Url = "https://github.com/LegendaryAy/LegendBank", UserId = "1" };
                builder.Entity<Projects>().HasData(a);
                builder.Entity<Projects>().HasData(b);
                builder.Entity<Projects>().HasData(c);
                builder.Entity<Projects>().HasData(d);
                builder.Entity<Projects>().HasData(e);
                builder.Entity<Projects>().HasData(f);
            }

            public DbSet<Address> Address { get; set; }
            public DbSet<Contact> Contact { get; set; }
            public DbSet<Skills> Skills { get; set; }
            public DbSet<Projects> Projects { get; set; }


    }
}
