using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zadanie3tabele.Properties
{
    internal class Obsluga : DbContext
    {
       public DbSet<Uczeń> Uczeń { get; set; }
       public DbSet<Klasa> Klasa { get; set; }
       public DbSet<Nauczyciel> Nauczyciel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = zadanietabele.db");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
