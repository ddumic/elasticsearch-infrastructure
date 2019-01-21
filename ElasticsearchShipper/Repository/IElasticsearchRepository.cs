using System.Net.Http;

namespace ElasticsearchShipper.Repository
{
	public interface IElasticsearchRepository
	{
		T Get<T>(string elasticsearchUrl) where T : class, new();

		T Post<T>(string elasticsearchUrl, StringContent payload) where T : class, new();

		T Delete<T>(string elasticsearchUrl, StringContent payload) where T : class, new();

		bool Head(string elasticsearchUrl);
	}
}
