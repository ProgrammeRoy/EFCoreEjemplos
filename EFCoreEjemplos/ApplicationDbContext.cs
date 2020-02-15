using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEjemplos
{
  class ApplicationDbContext: DbContext
  {
    //Server
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Data Source = SQLSERVER; Initial Catalog=EFCore; Integrated Security=True");
    }

    //Table Sql
    public DbSet<Estudiante> Estudiantes { get; set; }

    //In Package Manager Console

    //To prepare migration
    //Add-Migration Initial
  }
}
