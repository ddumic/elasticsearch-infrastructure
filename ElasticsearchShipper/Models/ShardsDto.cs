using Newtonsoft.Json;

namespace ElasticsearchShipper.Models
{
	public class ShardsDto
	{
		[JsonProperty(PropertyName = "total")]
		public int Total { get; set; }

		[JsonProperty(PropertyName = "successful")]
		public int Successful { get; set; }

		[JsonProperty(PropertyName = "failed")]
		public int Failed { get; set; }

		[JsonProperty(PropertyName = "skipped ")]
		public int Skipped { get; set; }
	}
}
