using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TreehouseBadges
{
		public class RecentBadge : IComparer<Badge>
		{
			public int Compare(Badge x, Badge y)
			{
				return x.EarnedDate.CompareTo(y.EarnedDate) * -1;
			}

		}
	}


