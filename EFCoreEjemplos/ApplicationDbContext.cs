using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEjemplos
{
  class ApplicationDbContext: DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Data Source = SQLSERVER; Initial Catalog=EFCore; Integrated Security=True");
    }
  }
}
