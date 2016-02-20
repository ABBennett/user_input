using System;

namespace user_input
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("What is your name?: ");

			string name = Console.ReadLine ();
			Console.Write ("Hello, {0}! It's nice to finally meet you. ", name);

			Console.WriteLine ("Welcome to this computer");
		}
	}
}
