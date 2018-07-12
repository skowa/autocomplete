using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace autocomplete
{
	public class AutocompleteFromFileHelper : IAutocompleteHelper
	{
		public AutocompleteFromFileHelper(string path)
		{
			FilePath = path;
		}

		public string FilePath { get; }

		public List<string> GetHints()
		{
			List<string> hints = new List<string>();
			string buff;

			using (StreamReader reader = new StreamReader(FilePath))
			{
				buff = reader.ReadToEnd();
			}

			buff = Regex.Replace(buff, "[^A-Za-z ]", String.Empty);
			hints = buff.Split(' ', '\n').Distinct().ToList();

			return hints;
		}
	}
}
