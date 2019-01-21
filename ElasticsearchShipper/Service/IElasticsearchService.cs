using ElasticsearchShipper.Common;
using ElasticsearchShipper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElasticsearchShipper.Service
{
	public interface IElasticsearchService
	{
		Task<IEnumerable<IndiceDto>> GetAllIndices(string elasticsearchUrl);
		Task<IndiceDto> GetIndice(string elasticsearchUrl, string indice);
		Task<bool> IncideExist(string elasticsearchUrl, string indice);
		Task<bool> AddDocument<TEntity>(TEntity entity, string elasticsearchUrl, string indice, int? id = null) where TEntity : ElasticsearchEntityBase;
		Task<bool> DeleteDocument(string elasticsearchUrl, string indice);
		Task<IndiceDocumentDto> GetIndiceDocument(string elasticsearchUrl, string indice);
	}
}
