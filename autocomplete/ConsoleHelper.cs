using System;
using System.Collections.Generic;

namespace autocomplete
{
	public class ConsoleHelper
	{
		public void UseAutocompleteViaConsole()
		{
			Autocomplete autocomplete = new Autocomplete();

			string input = string.Empty;
			ConsoleKeyInfo keyInfo = Console.ReadKey(true);

			while (keyInfo.Key != ConsoleKey.Enter)
			{
				input += keyInfo.KeyChar.ToString();

				if (input.Length != 0)
				{
					List<string> foundElements = autocomplete.AutocompleteString(input, "input.txt");

					Console.Clear();
					Console.WriteLine(input);
					foreach (string foundElement in foundElements)
					{
						Console.WriteLine(foundElement);
					}
				}
				keyInfo = Console.ReadKey(true);
			}
		}
	}
}
