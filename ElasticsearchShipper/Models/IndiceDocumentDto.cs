using Newtonsoft.Json;

namespace ElasticsearchShipper.Models
{
	public class IndiceDocumentDto
	{
		[JsonProperty(PropertyName = "took")]
		public int Took { get; set; }

		[JsonProperty(PropertyName = "timed_out")]
		public bool TimedOut { get; set; }

		[JsonProperty(PropertyName = "_shards")]
		public ShardsDto Shards { get; set; }

		[JsonProperty(PropertyName = "hits")]
		public HitsDto Hits { get; set; }
	}
}
