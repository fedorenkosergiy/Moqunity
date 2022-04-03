using Moqunity.Abstract;

namespace Moqunity
{
	public class TestingContext<T> : Context where T : Factory, new()
	{
		public TestingContext() : base(new T()) { }
	}
}
