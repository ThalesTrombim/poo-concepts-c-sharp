using System;
namespace PooNoteControl
{
  public class Student : IStudentInterface
  {
    public Student()
    {
      this.Name = "";
      this.Email = "";
    }
    public Student(string name, string email)
    {
      this.Name = name;
      this.Email = email;
    }

    private string name = "";
    public string Name
    {
      get { return this.name; }
      set { this.name = value.ToUpper(); }
    }
    private string email = "";
    public string Email
    {
      get { return this.email; }
      set { this.email = value.ToUpper(); }
    }

    public void ShowData()
    {
      Console.WriteLine("Dados do aluno");
      Console.WriteLine("Nome: " + this.Name);
      Console.WriteLine("Email: " + this.Email);
    }
  }
}

