using System.Net.Http;

namespace ElasticsearchShipper.Factory
{
	public interface IHttpFactory
	{
		HttpClient CreateClient();
	}
}
