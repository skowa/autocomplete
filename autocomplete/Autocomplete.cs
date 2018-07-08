using System.Collections.Generic;
using System.Linq;

namespace autocomplete
{
	public class Autocomplete
	{
		public List<string> AutocompleteString(string givenString, string pathToHints)
		{
			AutocompleteHelper helper = new AutocompleteHelper(pathToHints);
			List<string> hints = helper.LoadHints();

			List<string> foundElements = new List<string>();
			foundElements = hints.Where(s => s.StartsWith(givenString)).ToList();

			return foundElements;
		}
	}
}
