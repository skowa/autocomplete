using System;
using System.Collections.Generic;

namespace autocomplete
{
	public class Program
	{
		private static AutocompleteFromFileHelper helper = new AutocompleteFromFileHelper("input.txt");
		private static Autocomplete autocomplete = new Autocomplete();

		static void Main(string[] args)
		{
			string input = string.Empty;
			ConsoleKeyInfo keyInfo;

			do
			{
				keyInfo = Console.ReadKey(true);
				input += keyInfo.KeyChar.ToString();

				if (input.Length != 0)
				{
					List<string> foundElements = autocomplete.AutocompleteString(input, helper);

					Console.Clear();
					Console.WriteLine(input);
					foreach (string foundElement in foundElements)
					{
						Console.WriteLine(foundElement);
					}
				}
			} while (keyInfo.Key != ConsoleKey.Enter);
		}
	}
}
