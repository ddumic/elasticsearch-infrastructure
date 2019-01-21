using Newtonsoft.Json;

namespace ElasticsearchShipper.Models
{
	public class CreateDocumentDto
	{
		[JsonProperty(PropertyName = "_index")]
		public string Index { get; set; }

		[JsonProperty(PropertyName = "_type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "_id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "_version")]
		public int Version { get; set; }

		[JsonProperty(PropertyName = "hearesultlth")]
		public string Result { get; set; }

		[JsonProperty(PropertyName = "_shards")]
		public ShardsDto Shards { get; set; }

		[JsonProperty(PropertyName = "_seq_no")]
		public int SeqNo { get; set; }

		[JsonProperty(PropertyName = "_primary_term")]
		public int PrimaryTerm { get; set; }
	}
}
