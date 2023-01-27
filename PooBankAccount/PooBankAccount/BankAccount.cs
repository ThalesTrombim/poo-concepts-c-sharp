using System;
namespace PooBankAccount
{
	public class BankAccount
	{
		public Client AccountHolder { get; set; }

    public BankAccount()
		{
			this.balance = 0;
			this.AccountHolder = new Client();
		}

		protected Double balance;
		public Double Balance {
			get
			{
				return balance;
			}
		}

		public void Deposit(double val)
		{
			this.balance += val;
		}

		public virtual Double Withdraw(double val)
		{
			if(this.balance >= val)
			{
				this.balance -= val;
			}
			else
			{
				throw new Exception("Saldo insuficiente");
			}
			return this.balance;
		}

  }
}

