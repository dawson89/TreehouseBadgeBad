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
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("icon_url")]
		public string IconUrl { get; set; }
		[JsonProperty ("earned_date")]
		public DateTime EarnedDate { get; set; }
		[JsonProperty("courses")]
		public Cours[] Courses { get; set; }
	}



}
