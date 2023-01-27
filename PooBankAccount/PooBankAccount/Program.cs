using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBankAccount
{
  class Program
  {
    static void Main(string[] args)
    {
      StudentAccount account = new StudentAccount();
      account.AccountHolder.Name = "Thales Trombim";
      account.Deposit(600);

      int menu = 0;
      while(menu != 4)
      {
        //Console.Clear();
        Console.WriteLine("Menu de opcoes");
        Console.WriteLine("1 - Exibir dados do correntista");
        Console.WriteLine("2 - Retirar");
        Console.WriteLine("3 - Depositar");
        Console.WriteLine("4 - Sair");
        Console.Write("opcao: ");
        menu = Convert.ToInt32(Console.ReadLine());
        if(menu == 1)
        {
          account.ShowAccountData();
        }
        if(menu == 2)
        {
          try
          {
            Console.Write("Valor para retirada");
            Double val = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Saldo restante: " + account.Withdraw(val));
          }
          catch (Exception err)
          {
            Console.WriteLine("Ops, Algo deu errado");
            Console.WriteLine("Erro:" + err.Message);
          }
        }
        if(menu == 3)
        {
          try
          {
            Console.Write("Valor para deposito");
            Double val = Convert.ToDouble(Console.ReadLine());
            account.Deposit(val);
            Console.WriteLine("Saldo atual: " + account.Balance);
          }
          catch (Exception err)
          {
            Console.WriteLine("Ops, Algo deu errado");
            Console.WriteLine("Erro:" + err.Message);
          }
        }
      }
      Console.ReadKey();
    }
  }
}