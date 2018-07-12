using System.Collections.Generic;

namespace autocomplete
{
	public interface IAutocompleteHelper
	{
		List<string> GetHints();
	}
}
