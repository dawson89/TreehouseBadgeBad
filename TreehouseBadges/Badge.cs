using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TreehouseBadges
{

	public class Badge
	{
		public int id { get; set; }
		public string name { get; set; }
		public string url { get; set; }
		public string icon_url { get; set; }
		[JsonProperty ("earned_date")]
		public DateTime EarnedDate { get; set; }
		public Cours[] courses { get; set; }
	}



}
