using System;
namespace PooBankAccount
{
	public class StudentAccount:BankAccount
	{
		public StudentAccount():base()
		{
			this.limit = 500;
		}

		private double limit;
		public double Limit { get; }

    public override double Withdraw(double val)
    {
      if(this.balance >= val && val <= this.limit)
			{
				this.balance -= val;
			}
			else
			{
				throw new Exception("Saldo insuficiente");
			}
			return this.balance;
    }

		public void ShowAccountData()
		{
			Console.WriteLine("Dados do correntista: " + this.AccountHolder.Name);
      Console.WriteLine("Saldo: " + this.Balance);
      Console.WriteLine("Limite: " + this.Limit);
    }
  }
}

