using Moqunity.Abstract;

namespace Moqunity
{
	public class TestingMoqunityApi<TStaticProvider, TFactory> : MoqunityApi
		where TStaticProvider : class, StaticProvider, new()
		where TFactory : class, Factory, new()
	{
		public TestingMoqunityApi() : base(new TStaticProvider(), new TFactory())
		{
		}
	}

	public class TestingMoqunityApi : MoqunityApi
	{
		public TestingMoqunityApi(StaticProvider staticProvider, Factory factory)
			: base(staticProvider, factory)
		{
		}
	}
}
