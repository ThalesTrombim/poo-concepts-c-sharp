using System;
namespace PooStatic
{
	public class Tool
	{
		static private int NextId;

		public Tool(string name, int durability)
		{
			try
			{
				NextId++;
      }
			catch
			{
				NextId = 1;
			}
			this.Id = NextId;
			this.Name = name;
			this.Durability = durability;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public int Durability { get; set; }

		public void ShowToolData()
		{
			Console.WriteLine("Nome: " + this.Name + " Durabilidade: " + this.Durability + " Id: " + this.Id);
		}
	}
}

