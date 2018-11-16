using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseBadges
{

	public class FullBadge
	{
		public string name { get; set; }
		public string profile_name { get; set; }
		public string profile_url { get; set; }
		public string gravatar_url { get; set; }
		public string gravatar_hash { get; set; }
		public Badge[] Badges { get; set; }
		public Points points { get; set; }
	}

	public class Points
	{
		public int total { get; set; }
		public int HTML { get; set; }
		public int CSS { get; set; }
		public int Design { get; set; }
		public int JavaScript { get; set; }
		public int Ruby { get; set; }
		public int PHP { get; set; }
		public int WordPress { get; set; }
		public int iOS { get; set; }
		public int Android { get; set; }
		public int DevelopmentTools { get; set; }
		public int Business { get; set; }
		public int Python { get; set; }
		public int Java { get; set; }
		public int DigitalLiteracy { get; set; }
		public int C { get; set; }
		public int Databases { get; set; }
		public int DataAnalysis { get; set; }
		public int APIs { get; set; }
		public int Security { get; set; }
		public int Go { get; set; }
		public int QualityAssurance { get; set; }
		public int MachineLearning { get; set; }
		public int ComputerScience { get; set; }
	}

	public class Cours
	{
		public string title { get; set; }
		public string url { get; set; }
		public int badge_count { get; set; }
	}

}
