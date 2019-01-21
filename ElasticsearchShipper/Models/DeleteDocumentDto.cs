using Newtonsoft.Json;

namespace ElasticsearchShipper.Models
{
	public class DeleteDocumentDto
	{
		[JsonProperty(PropertyName = "acknowledged")]
		public bool Acknowledged { get; set; }
	}
}
