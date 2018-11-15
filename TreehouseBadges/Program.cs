using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace TreehouseBadges
{
	class Program
	{
		private readonly string remoteUri;

		public static List<Badge> Badge { get; }

		public static string InternetGet(string remoteUri)
		{

			// Create a new WebClient instance.
			WebClient myWebClient = new WebClient();

			// Download the Web resource and save it into a data buffer.
			byte[] myDataBuffer = myWebClient.DownloadData(remoteUri);

			// Display the downloaded data.
			string download = Encoding.ASCII.GetString(myDataBuffer);
			return download;
		
		}
		static void Main(string[] args)
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			DirectoryInfo directory = new DirectoryInfo(currentDirectory);

			// var fileName = Path.Combine(directory.FullName, "dawson89.json");
			// System.Threading.Tasks.Task<string> xfdfdf = BadgeClient.GetStringAsync("dawson89.json");
			// var fileName = Path.Combine(directory.FullName, "allBadges.json");

			var getMyJsonFile = "https://teamtreehouse.com/dawson89.json";
			var badges = DeserializeBadges(getMyJsonFile);
			var allBadges = GetAllBadges(badges);
			var customImportBadges = GetCustomImportBadges(badges);
			var customExportBadges = GetCustomExportBadges(badges);


			SerializeBadgeToFile(allBadges, Path.Combine(directory.FullName, "allbadges.json"));

		}

		public static List<Badge> DeserializeBadges(string externalUri)
		{
			var badges = new List<Badge>();

			string webResults = Program.InternetGet(externalUri);

			var namingShitIsHard = JsonConvert.DeserializeObject<FullBadge>(webResults);

				badges.AddRange(namingShitIsHard.badges);

			//var serializer = new JsonSerializer();
			//using (var reader = new StreamReader(fileName))
			//using (var jsonReader = new JsonTextReader(reader))
			//{
			//	var fullBadges = serializer.Deserialize<FullBadge>(jsonReader);
			//	badges.AddRange(fullBadges.badges);
			//}
			return badges;
		}

		public static string ReadFile(string fileName)
		{
			using (var reader = new StreamReader(fileName))
			{
				return reader.ReadToEnd();
			}
		}

		public static List<Badge> GetAllBadges(List<Badge> badges)
		{
			//	Console.Write("How many badges do would you like to work with? ");
			//	var AllNumber = Console.ReadLine();
			//	var AllAnswer = int.Parse(AllNumber);

			var allBadges = new List<Badge>();
			badges.Sort(new RecentBadge());
			int counter = 0;
			foreach (var badge in badges)
			{
				allBadges.Add(badge);
				counter++;
				if (counter == (200))
					break;
			}
			return allBadges;
		}

		// Returns the number of most recent Badges Earned
		public static List<Badge> GetCustomImportBadges(List<Badge> badges)
		{
			Console.Write("How many badges do would you like to view?");
			var ImportNumber = Console.ReadLine();
			var ImportAnswer = int.Parse(ImportNumber);

			var customImportBadges = new List<Badge>();
			badges.Sort(new RecentBadge());
			int counter = 0;
			foreach (var badge in badges)
			{
				customImportBadges.Add(badge);
				counter++;
				if (counter == (ImportAnswer))
					break;
			}
			return customImportBadges;
		}

		public static List<Badge> GetCustomExportBadges(List<Badge> badges)
		{
			Console.Write("How many badges do you want to include in your export? ");
			var ExportNumber2 = Console.ReadLine();
			var ExportAnswer2 = int.Parse(ExportNumber2);

			var customExportBadges = new List<Badge>();
			badges.Sort(new RecentBadge());
			int counter = 0;
			foreach (var badge in badges)
			{
				customExportBadges.Add(badge);
				counter++;
				if (counter == (ExportAnswer2))
					break;
			}
			return customExportBadges;
		}

		public static void SerializeBadgeToFile(List<Badge> badges, string fileName)
		{

			var serializer = new JsonSerializer();
			using (var writer = new StreamWriter(fileName))
			using (var jsonWriter = new JsonTextWriter(writer))
			{
				serializer.Serialize(jsonWriter, badges);
			}


		}


	}
}
