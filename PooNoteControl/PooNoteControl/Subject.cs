using System;
namespace PooNoteControl
{
  public class Subject : SubjectsModel
  {
    public Subject()
    {
      this.Name = "";
      this.Grade1 = 0;
      this.Grade2 = 0;
      this.ApprovalRating = 5;
    }

    public Subject(string name, double grade1, double grade2, double approvalRating)
    {
      this.Name = name;
      this.Grade1 = grade1;
      this.Grade2 = grade2;
      this.ApprovalRating = approvalRating;
    }
    public double ApprovalRating { get; set; }
    public double Rating {
      get
      {
        return (this.Grade1 + this.Grade2) / 2;
      }
    }

    public override void ShowData()
    {
      Console.WriteLine("Materia: " + this.Name);
      Console.WriteLine("Nota 1: " + this.Grade1);
      Console.WriteLine("Nota 2: " + this.Grade2);
      Console.WriteLine("Media: " + this.Rating);
      Console.WriteLine("Media de aprovacao: " + this.ApprovalRating);
      Console.WriteLine("Status da materia: " + SubjectStatus());
    }

    public string SubjectStatus()
    {
      string msg = "Aluno nao aprovado na materia";
      if(this.Rating >= this.ApprovalRating)
      {
        msg = "Aluno aprovado na materia";
      }

      return msg;
    }
  }
}

