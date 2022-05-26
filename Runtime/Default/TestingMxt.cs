using Moqunity.Abstract;

namespace Moqunity
{
	public class TestingMxt<T> : Mxt where T : Provider, new()
	{
		public TestingMxt() : base(new T()) { }
	}

	public class TestingMxt : Mxt
	{
		public TestingMxt(Provider provider) : base(provider) { }
	}
}
