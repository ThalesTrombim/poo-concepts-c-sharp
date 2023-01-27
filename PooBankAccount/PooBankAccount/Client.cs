using System;
namespace PooBankAccount
{
	public class Client
	{
		public Client()
		{
			this.Id = 0;
			this.Name = "";
			this.Cpf = "";
		}
		public int Id { get; set; }
		public string Name { get; set; }
    public string Cpf { get; set; }
  }
}

