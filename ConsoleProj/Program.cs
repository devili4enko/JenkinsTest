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
			Console.ReadLine();
		}
	}
}
