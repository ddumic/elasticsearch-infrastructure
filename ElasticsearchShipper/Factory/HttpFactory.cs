using System.Net.Http;
using System.Net.Http.Headers;

namespace ElasticsearchShipper.Factory
{
	public class HttpFactory : IHttpFactory
	{
		public HttpClient CreateClient()
		{
			var client = new HttpClient();

			client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
			client.DefaultRequestHeaders.Add("AcceptCharset", "utf-8");
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			return client;
		}
	}
}
