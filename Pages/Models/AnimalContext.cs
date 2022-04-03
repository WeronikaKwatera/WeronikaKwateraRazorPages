using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WeronikaKwateraRazorPagesFINAL.Pages.Models
{
    public class AnimalContext : DbContext
    {
        public DbSet <Animal> Animals { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WeronikaKwateraAnimal");
        }
    }
}
