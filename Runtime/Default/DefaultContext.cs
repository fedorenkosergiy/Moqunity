namespace Moqunity
{
	public class DefaultContext : Context
	{
		public DefaultContext() : base(new DefaultFactory()) { }
	}
}
