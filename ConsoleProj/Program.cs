using System;
using JenkinsTestClassLibrary;

namespace ConsoleProj
{
	class Program
	{
		static void Main(string[] args)
		{
			var api = new Api();

			api.SayHello("Ted");

			for (int i = 0; i < 10; i++)
			{
				api.SaveLineToFile(string.Format("Line {0}", i++));
			}

			Console.ReadLine();
		}
	}
}
