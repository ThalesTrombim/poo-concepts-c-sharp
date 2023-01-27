using System;
namespace PooPolymorphism
{
	public class Shapes
	{
		public Shapes()
		{
			this.ShapeName = "";
			this.Base = 0;
			this.Height = 0;
		}
    public Shapes(string name, double Mbase, double height)
    {
      this.ShapeName = name;
      this.Base = Mbase;
      this.Height = height;
    }

    public Double Base { get; set; }
		public Double Height { get; set; }
		public virtual string ShapeName { get; set; }

		public virtual Double CalculateArea()
		{
			return 0;
		}
	}
}

