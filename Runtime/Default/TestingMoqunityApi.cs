using Moqunity.Abstract;

namespace Moqunity
{
	public class TestingMoqunityApi<T> : MoqunityApi where T : Provider, new()
	{
		public TestingMoqunityApi() : base(new T()) { }
	}

	public class TestingMoqunityApi : MoqunityApi
	{
		public TestingMoqunityApi(Provider provider) : base(provider) { }
	}
}
