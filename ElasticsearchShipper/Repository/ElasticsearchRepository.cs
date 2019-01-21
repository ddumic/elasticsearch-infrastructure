using ElasticsearchShipper.Factory;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace ElasticsearchShipper.Repository
{
	public class ElasticsearchRepository : IElasticsearchRepository
	{
		private readonly IHttpFactory _httpFactory;

		public ElasticsearchRepository(IHttpFactory httpFactory)
		{
			_httpFactory = httpFactory;
		}

		#region Get

		public T Get<T>(string elasticsearchUrl) where T : class, new()
		{
			T retVal = null;

			var response = Get(elasticsearchUrl);
			if (response != null)
			{
				var responseResult = response.Content.ReadAsStringAsync().Result;
				if (response.IsSuccessStatusCode || !string.IsNullOrEmpty(responseResult))
				{
					retVal = JsonConvert.DeserializeObject<T>(responseResult);
				}
			}

			return retVal;
		}

		private HttpResponseMessage Get(string elasticsearchUrl)
		{
			using (var client = _httpFactory.CreateClient())
			{
				var response = client.GetAsync(elasticsearchUrl).Result;

				return response;
			}
		}

		#endregion

		#region Post

		public T Post<T>(string elasticsearchUrl, StringContent payload) where T : class, new()
		{
			T retVal = null;

			var response = Post(elasticsearchUrl, payload);
			if (response != null)
			{
				var responseResult = response.Content.ReadAsStringAsync().Result;
				if (response.IsSuccessStatusCode || !string.IsNullOrEmpty(responseResult))
				{
					retVal = JsonConvert.DeserializeObject<T>(responseResult);
				}
			}

			return retVal;
		}

		private HttpResponseMessage Post(string elasticsearchUrl, StringContent payload)
		{
			using (var client = _httpFactory.CreateClient())
			{
				var response = client.PostAsync(elasticsearchUrl, new StringContent(payload.ReadAsStringAsync().Result, Encoding.UTF8, "application/json")).Result;

				return response;
			}
		}

		#endregion

		#region Delete

		public T Delete<T>(string elasticsearchUrl, StringContent payload) where T : class, new()
		{
			T retVal = null;

			var response = Delete(elasticsearchUrl, payload);
			if (response != null)
			{
				var responseResult = response.Content.ReadAsStringAsync().Result;
				if (response.IsSuccessStatusCode || !string.IsNullOrEmpty(responseResult))
				{
					retVal = JsonConvert.DeserializeObject<T>(responseResult);
				}
			}

			return retVal;
		}

		public HttpResponseMessage Delete(string elasticsearchUrl, StringContent payload)
		{
			HttpRequestMessage request = new HttpRequestMessage
			{
				Content = payload,
				Method = HttpMethod.Delete,
				RequestUri = new Uri(elasticsearchUrl)
			};

			using (var client = _httpFactory.CreateClient())
			{
				var response = client.SendAsync(request).Result;
				return response;
			}
		}


		#endregion

		#region Head

		public bool Head(string elasticsearchUrl)
		{
			HttpRequestMessage request = new HttpRequestMessage
			{
				Method = HttpMethod.Head,
				RequestUri = new Uri(elasticsearchUrl)
			};

			using (var client = _httpFactory.CreateClient())
			{
				var response = client.SendAsync(request).Result;
				return response.IsSuccessStatusCode;
			}
		}

		#endregion

	}
}
