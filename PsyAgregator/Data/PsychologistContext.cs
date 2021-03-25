using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PsyAgregator.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PsyAgregator.Data
{
    public class PsychologistContext: DbContext
    {
        public PsychologistContext(DbContextOptions<PsychologistContext> options):base(options)
        {

        }

        public DbSet<Psychologist> Psychologists { get; set; }
        //public DbSet<User> PsychologySkyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Psychologist>().HasData(
                 new Psychologist
                 {
                     PsychologistID = 1,
                     FirstName = "Татьяна",
                     MidName = "Викторовна",
                     LastName = "Дымова",
                     TelNumber = 89213567848,
                     Email = "psy@m.com",
                     PhotoFileName = "actress.jpg",
                     ImageMimeType = "image/jpeg"
                 },
                new Psychologist
                {
                    PsychologistID = 2,
                    FirstName = "Алекс",
                    MidName = "Викторович",
                    LastName = "Личёв",
                    TelNumber = 89213567868,
                    Email = "psy1@m.com",
                    PhotoFileName = "actor.jpg",
                    ImageMimeType = "image/jpeg"
                },
                new Psychologist
                {
                    PsychologistID = 3,
                    FirstName = "Михаил",
                    MidName = "Андреевич",
                    LastName = "Душнилов",
                    TelNumber = 89213167868,
                    Email = "psy2@m.com",
                    PhotoFileName = "psychologist.jpg",
                    ImageMimeType = "image/jpeg"
                });
        }
    }
}
