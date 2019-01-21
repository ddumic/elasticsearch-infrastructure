using ElasticsearchShipper.Common;
using ElasticsearchShipper.Models;
using ElasticsearchShipper.Repository;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchShipper.Service
{
	public class ElasticsearchService : IElasticsearchService
	{
		private readonly IElasticsearchRepository _elasticsearchRepository;

		public ElasticsearchService(IElasticsearchRepository elasticsearchRepository)
		{
			_elasticsearchRepository = elasticsearchRepository;
		}

		#region IEleasticsearch service

		public async Task<bool> AddDocument<TEntity>(TEntity entity, string elasticsearchUrl, string indice, int? id = null) where TEntity : ElasticsearchEntityBase
		{
			var result = _elasticsearchRepository.Post<CreateDocumentDto>($"{elasticsearchUrl}/{indice}/_doc", new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json"));

			return result.Shards.Failed == 0;
		}

		public async Task<bool> DeleteDocument(string elasticsearchUrl, string indice)
		{
			var result = _elasticsearchRepository.Delete<DeleteDocumentDto>($"{elasticsearchUrl}/{indice}", new StringContent(string.Empty, Encoding.UTF8, "application/json"));

			return result.Acknowledged;
		}

		public async Task<IEnumerable<IndiceDto>> GetAllIndices(string elasticsearchUrl)
		{
			return _elasticsearchRepository.Get<List<IndiceDto>>($"{elasticsearchUrl}/_cat/indices?format=json");
		}

		public async Task<IndiceDto> GetIndice(string elasticsearchUrl, string indice)
		{
			return _elasticsearchRepository.Get<IndiceDto>($"{elasticsearchUrl}/_cat/indices/{indice}");
		}

		public async Task<bool> IncideExist(string elasticsearchUrl, string indice)
		{
			return _elasticsearchRepository.Head($"{elasticsearchUrl}/{indice}");
		}

		public async Task<IndiceDocumentDto> GetIndiceDocument(string elasticsearchUrl, string indice)
		{
			return _elasticsearchRepository.Get<IndiceDocumentDto>($"{elasticsearchUrl}/{indice}/_search?pretty=true&q=*:*");
		}

		#endregion
	}
}
