using StructureMap;

namespace ElasticsearchShipper.Infrastructure
{
	public class ElasticsearchRegistry : Registry
	{
		public ElasticsearchRegistry()
		{
			Scan(_ =>
			{
				_.WithDefaultConventions();
				_.Assembly("ElasticsearchShipper");
				_.IncludeNamespace("ElasticsearchShipper.Factory");
				_.IncludeNamespace("ElasticsearchShipper.Service");
				_.IncludeNamespace("ElasticsearchShipper.Repository");
			});
		}
	}
}
