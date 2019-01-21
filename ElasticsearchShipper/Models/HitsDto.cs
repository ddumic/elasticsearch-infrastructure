using Newtonsoft.Json;
using System.Collections.Generic;

namespace ElasticsearchShipper.Models
{
	public class HitsDto
	{
		[JsonProperty(PropertyName = "total")]
		public int Total { get; set; }

		[JsonProperty(PropertyName = "max_score")]
		public double MaxScore { get; set; }

		[JsonProperty(PropertyName = "hits")]
		public IEnumerable<HitDto> Hits { get; set; }
	}
}
