using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoosanTransChatBot.Models
{
	public class Translator
	{
		public Data data { get; set; }

	}

	public class Data

	{

		public List<translations> translations { get; set; }

	}


	public class translations

	{

		public string translatedText { get; set; }

	}
}