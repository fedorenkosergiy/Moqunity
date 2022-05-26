namespace Moqunity
{
	public class DefaultMoqunityApi : MoqunityApi
	{
		public DefaultMoqunityApi() : base(new DefaultStaticProvider(), new DefaultFactory()) { }
	}
}
