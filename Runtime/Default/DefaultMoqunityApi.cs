namespace Moqunity
{
	public class DefaultMoqunityApi : MoqunityApi
	{
		public DefaultMoqunityApi() : base(new DefaultProvider()) { }
	}
}
