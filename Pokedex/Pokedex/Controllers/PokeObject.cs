﻿using System.Collections.Generic;

namespace Pokedex.Controllers
{
	public class PokeObject
	{
		public string name { get; set; }
		public bool is_legendary { get; set; }
		public Habitat habitat { get; set; }
		public List<FlavorTextEntry> flavor_text_entries { get; set; }
	}

	public class Habitat
	{
		public string name { get; set; }
		public string url { get; set; }
	}

	public class FlavorTextEntry
	{
		public string flavor_text { get; set; }
		public FlavorTextEntryLanguage language { get; set; }
		public FlavorTextEntryVersion version { get; set; }
	}

	public class FlavorTextEntryLanguage
	{
		public string name { get; set; }
		public string url { get; set; }
	}

	public class FlavorTextEntryVersion
	{
		public string name { get; set; }
		public string url { get; set; }
	}
}