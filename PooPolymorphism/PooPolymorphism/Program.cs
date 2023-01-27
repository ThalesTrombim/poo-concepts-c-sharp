using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPolymorphism
{
  class Program
  {
    static void Main(string[] args)
    {
      Square q1 = new Square(2, 2);
      Square q2 = new Square(4, 4);
      Square q3 = new Square(8, 8);
      Triangle t2 = new Triangle(4, 4);
      Triangle t1 = new Triangle(2, 2);
      Triangle t3 = new Triangle(8, 8);

      List<Shapes> shapes = new List<Shapes>();
      shapes.Add(q1);
      shapes.Add(q2);
      shapes.Add(q3);
      shapes.Add(t1);
      shapes.Add(t2);
      shapes.Add(t3);

      foreach(var item in shapes)
      {
        ShowType(item);
      }

      Console.ReadKey();
    }

    static void ShowType(Shapes shape)
    {
      Console.WriteLine(shape.ShapeName);
    }
  }
}