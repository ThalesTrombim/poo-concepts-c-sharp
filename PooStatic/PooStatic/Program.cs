using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooStatic
{
  class Program
  {
    static void Main(string[] args)
    {
      Tool t = new Tool("Martelo", 100);
      t.ShowToolData();
      Tool t2 = new Tool("Serra", 100);
      t2.ShowToolData();
    }
  }
}