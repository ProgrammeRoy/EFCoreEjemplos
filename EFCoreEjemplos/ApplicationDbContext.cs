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
      optionsBuilder.UseSqlServer("Server=.\\SQLSERVER;user id=sa;password=Pa$$123;Database=EFCore");
    }

    //Table Sql
    public DbSet<Estudiante> Estudiantes { get; set; }

    //In Package Manager Console

      //To prepare migration
      //Add-Migration Initial

      //Create DataBase and update
      //update-database
  }
}
