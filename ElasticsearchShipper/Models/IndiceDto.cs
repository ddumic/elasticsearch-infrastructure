using Newtonsoft.Json;

namespace ElasticsearchShipper.Models
{
	public class IndiceDto
	{
		[JsonProperty(PropertyName = "health")]
		public string Health { get; set; }

		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }

		[JsonProperty(PropertyName = "index")]
		public string Index { get; set; }

		[JsonProperty(PropertyName = "uuid")]
		public string Uuid { get; set; }

		[JsonProperty(PropertyName = "docs.count")]
		public int DocsCount { get; set; }

		[JsonProperty(PropertyName = "docs.deleted")]
		public int DocsDeleted { get; set; }

		[JsonProperty(PropertyName = "store.size")]
		public string StoreSize { get; set; }
	}
}
