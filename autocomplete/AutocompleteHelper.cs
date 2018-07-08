using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace autocomplete
{
	public class AutocompleteHelper
	{
		public AutocompleteHelper(string path)
		{
			FilePath = path;
		}

		public string FilePath { get; set; }

		public List<string> LoadHints()
		{
			List<string> hints = new List<string>();
			string buff;

			using (StreamReader reader = new StreamReader(FilePath))
			{
				buff = reader.ReadToEnd();
			}

			buff = Regex.Replace(buff, "[^A-Za-z ]", String.Empty);
			hints = buff.Split(' ', '\n').Distinct().ToList();
			hints.Sort();

			return hints;
		}
	}
}
