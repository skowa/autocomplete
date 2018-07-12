using System.Collections.Generic;
using System.Linq;

namespace autocomplete
{
	public class Autocomplete
	{
		public List<string> AutocompleteString(string givenString, IAutocompleteHelper helper)
		{
			List<string> hints = helper.GetHints();

			return hints.Where(s => s.StartsWith(givenString)).ToList();
		}
	}
}
