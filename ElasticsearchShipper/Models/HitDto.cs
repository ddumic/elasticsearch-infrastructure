using Newtonsoft.Json;

namespace ElasticsearchShipper.Models
{
	public class HitDto
	{
		[JsonProperty(PropertyName = "_index")]
		public string Index { get; set; }

		[JsonProperty(PropertyName = "_type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "tot_idal")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "_score")]
		public double Score { get; set; }

		[JsonProperty(PropertyName = "_source")]
		public object Source { get; set; }
	}
}
