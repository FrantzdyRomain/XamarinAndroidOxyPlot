using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Linq;
using System.Linq;

namespace NewsReader.Services
{
	public class NewsLoadingService: INewsLoadingService
	{
		public NewsLoadingService()
		{
			
		}

		public async Task<List<string>> LoadNews() {

			HttpClient client = new HttpClient();
			var data = await client.GetStringAsync("http://www.bbc.co.uk/sport/football/premier-league/rss.xml");

			var News = ParseResponse(data);
			return News;

		}

		private List<string> ParseResponse(string data)
		{
			var xml = XDocument.Parse(data);
			var items = xml.Descendants("item");

			var list = items.Select(x => x.Element("description").Value.ToString()).ToList();

			return list;
		}
	}
}

