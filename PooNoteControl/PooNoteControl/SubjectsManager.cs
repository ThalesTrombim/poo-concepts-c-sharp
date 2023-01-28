using System;
using System.Xml.Linq;

namespace PooNoteControl
{
	public class SubjectsManager
	{
		public SubjectsManager()
		{
			this.Aluno = new Student();
			this.subjects = new List<Subject>();
		}
    public SubjectsManager(string name, string email)
    {
      this.Aluno = new Student(name, email);
      this.subjects = new List<Subject>();
    }

    public Student Aluno { get; set; }
		private List<Subject> subjects;

		public List<Subject> Subjects
		{
			get
			{
				return this.subjects;
			}
		}

		public void RegisterSubject(Subject subject)
		{
			try
			{
				subjects.Add(subject);
			}
			catch (Exception err)
			{
				throw new Exception("Erro: " + err.Message);
			}
		}

		public void ListSubjects()
		{
			Console.WriteLine("Materias");
			for (int i = 0; i < subjects.Count; i++)
			{
				Subject m = subjects[i];
				m.ShowData();
			}
		}

		public Boolean DeleteSubject(string name)
		{
			Boolean res = false;

			if(this.subjects.Exists(s => s.Name == name))
			{
				res = true;
				Subject sub = this.subjects.Find(m => m.Name == name);
				this.subjects.Remove(sub);
			}

			return res;
		}

		public Boolean ChangeSubject(Subject subjectObj)
		{
			Boolean res = false;

      if (this.subjects.Exists(s => s.Name == subjectObj.Name))
      {
				res = true;
        Subject sub = this.subjects.Find(m => m.Name == subjectObj.Name);
				sub.Grade1 = subjectObj.Grade1;
        sub.Grade2 = subjectObj.Grade2;
      }

      return res;
    }
	}
}

