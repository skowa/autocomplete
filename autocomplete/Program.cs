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
			List<string> hints = helper.GetHints();

			string input = string.Empty;
			ConsoleKeyInfo keyInfo;

			do
			{
				keyInfo = Console.ReadKey(true);
				input += keyInfo.KeyChar.ToString();

				if (input.Length != 0)
				{
					List<string> foundElements = autocomplete.AutocompleteString(input, hints);

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
