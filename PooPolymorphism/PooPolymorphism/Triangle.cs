using System;
namespace PooPolymorphism
{
	public class Triangle:Shapes
	{
    public Triangle():base()
    {
      base.ShapeName = "Triangulo";
    }
    public Triangle(double Mbase, double Height) : base("Triangulo", Mbase, Height)
    {
    }

    public override string ShapeName {
      get => base.ShapeName;
    }

    public override double CalculateArea()
    {
      return (this.Base * this.Height) / 2;
    }
  }
}

