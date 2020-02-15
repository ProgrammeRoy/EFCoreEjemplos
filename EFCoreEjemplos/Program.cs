using System;
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
      //UpdateEstudiante();
      //UpdateEstudiantesWithoutConection();
      DeleteEstudiante();
    }

    static void DeleteEstudiante()
    {
      using (var context = new ApplicationDbContext())
      {
        var estudiante = context.Estudiantes.Where(x => x.Id == 1).FirstOrDefault();
        context.Estudiantes.Remove(estudiante);
        context.SaveChanges();
      }
    }

    static void UpdateEstudiantesWithoutConection()
    {
      Estudiante Bjorn;

      using (var context = new ApplicationDbContext())
      {
        Bjorn = context.Estudiantes.Where(x => x.Nombre == "Bjorn Iron Side").FirstOrDefault();
      }

      Bjorn.Nombre += " Viking";

      using (var context = new ApplicationDbContext())
      {
        context.Entry(Bjorn).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        context.SaveChanges();
      }
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
