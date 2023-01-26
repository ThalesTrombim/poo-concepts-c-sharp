using System;
namespace PooStatic
{
	public class TextMode
	{
		//public TextMode()
		//{
		//}
		static public void Write(string text)
		{
			Console.WriteLine(text); 
		}
		static public void Pause()
		{
			Console.ReadKey();
		}
		static public string Read()
		{
			return Console.ReadLine();
		}
    static public string Read(string text)
    {
			Console.Write(text); 
      return Console.ReadLine();
    }
  }
}

