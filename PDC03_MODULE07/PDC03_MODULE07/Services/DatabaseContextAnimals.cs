using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using PDC03_MODULE07.Model;
using System.IO;

namespace PDC03_MODULE07.Services
{
    public class DatabaseContextAnimals:DbContext
    {
        public DbSet<AnimalModel> Animals { get; set; }
        public DatabaseContextAnimals()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Animals.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

    }
}
