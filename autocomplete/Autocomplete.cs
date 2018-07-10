using System.Collections.Generic;
using System.Linq;

namespace autocomplete
{
	public class Autocomplete
	{
		public List<string> AutocompleteString(string givenString, List<string> hints) => hints.Where(s => s.StartsWith(givenString)).ToList();
	}
}
