using System;

namespace PooNoteControl
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int op = 0;
      string subjectName = "";
      double n1 = 0, n2 = 0, ar = 5;
      Subject subject;

      Console.WriteLine("Controle de materias");
      SubjectsManager gm = new SubjectsManager("Thales Trombim", "thalestr@outlook.com");
      
      while (op != 5)
      {
        gm.Aluno.ShowData();
        op = Menu();
        Console.Clear();
        if (op == 1)
        {
          gm.ListSubjects();
        }
        if (op == 2)
        {
          Console.WriteLine("Cadastro de materias");
          Console.Write("Matéria: ");
          subjectName = Console.ReadLine();
          Console.Write("Nota 1: ");
          n1 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Nota 2: ");
          n2 = Convert.ToDouble(Console.ReadLine());
          subject = new Subject(subjectName, n1, n2, ar);
          gm.RegisterSubject(subject);
          Console.WriteLine("Materia cadastrada");
        }
        if (op == 3)
        {
          Console.WriteLine("Alterar materia");
          Console.Write("Matéria: ");
          subjectName = Console.ReadLine();
          Console.Write("Nota 1: ");
          n1 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Nota 2: ");
          n2 = Convert.ToDouble(Console.ReadLine());
          subject = new Subject(subjectName, n1, n2, ar);
          if(gm.ChangeSubject(subject))
          {
            Console.WriteLine("Materia alterada");
          }
          else
          {
            Console.WriteLine("Materia " + subjectName + " Nao foi encontrada");
          }
        }
        if (op == 4)
        {
          Console.WriteLine("Excluir uma materia");
          Console.Write("Matéria: ");
          subjectName = Console.ReadLine();

          if(gm.DeleteSubject(subjectName))
          {
            Console.WriteLine("Materia excluida!");
          }
          else
          {
            Console.WriteLine("Materia " + subjectName + " Nao foi encontrada");
          }
        }
        Console.ReadKey();
      }

      Console.ReadKey();
    }

    static int Menu()
    {
      int op = 0;
      while (op < 1 || op > 5)
      {
        Console.WriteLine("1 - Exibir matérias");
        Console.WriteLine("2 - Cadastrar matérias");
        Console.WriteLine("3 - Alterar dados das matérias");
        Console.WriteLine("4 - Excluir matérias");
        Console.WriteLine("5 - Sair");
        Console.Write("Opcao: ");
        op = Convert.ToInt32(Console.ReadLine());
      }
      return op;
    }
  }
}