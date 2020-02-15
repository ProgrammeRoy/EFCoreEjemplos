using System;

namespace EFCoreEjemplos
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //InsertEstudiante();

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
