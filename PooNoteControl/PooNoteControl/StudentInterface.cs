using System;
namespace PooNoteControl
{
	interface IStudentInterface
	{
		string Name { get; set; }
		string Email { get; set; }
		void ShowData();
	}
}

