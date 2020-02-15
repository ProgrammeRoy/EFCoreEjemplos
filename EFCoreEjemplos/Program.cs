﻿using System;
using System.Linq;

namespace EFCoreEjemplos
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //InsertEstudiante();
      //ReadEstudiante();
      UpdateEstudiante();
    }

    static void UpdateEstudiante()
    {
      using (var context = new ApplicationDbContext())
      {
        var estudiantes = context.Estudiantes.ToList();
        estudiantes[0].Nombre += " Iron Side";
        context.SaveChanges();  
      }
    }

    static void ReadEstudiante()
    {
      using (var context = new ApplicationDbContext())
      {
        //Add up "using System.Linq;"
        var estudiantes = context.Estudiantes.ToList();
      }
    }

    static void InsertEstudiante()
    {
      using (var context = new ApplicationDbContext())
      {
        var estudiante = new Estudiante();
        estudiante.Nombre = "Bjorn";
        context.Add(estudiante);
        context.SaveChanges();
      }

    }
  }

  class Estudiante
  {
    public int Id { get; set; }
    public string Nombre { get; set; }
  }
}
