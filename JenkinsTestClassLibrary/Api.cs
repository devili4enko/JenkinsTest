using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTestClassLibrary
{
	public class Api
	{
		private const string Greeting = "Hello {0}!!!";

		public void SayHello(string name)
		{
			Console.WriteLine(MakeString(name));	
		}

		private string MakeString(string name)
		{
			return string.Format(Greeting, name);
		}

		public bool SaveLineToFile(string line)
		{

			File.AppendText("..\\Text\\SimpleText.txt");

			return true;
		}
	}
}
