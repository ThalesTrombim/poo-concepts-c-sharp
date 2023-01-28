using System;
namespace PooNoteControl
{
	abstract public class SubjectsModel
	{
		//public SubjectsModel()
		//{
		//}
		public string Name { get; set; }
		public double Grade1 { get; set; }
    public double Grade2 { get; set; }

		abstract public void ShowData();


  }
}

