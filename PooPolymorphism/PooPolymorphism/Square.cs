using System;
namespace PooPolymorphism
{
	public class Square:Shapes
	{
		public Square():base() {
			base.ShapeName = "Quadrado";
		}
    public Square(double Mbase, double height) : base("Quadrado", Mbase, height)
		{
		}

    public override string ShapeName {
			get => base.ShapeName;
		}

    public override Double CalculateArea()
		{
			return this.Base * this.Height;
		}
  }
}

