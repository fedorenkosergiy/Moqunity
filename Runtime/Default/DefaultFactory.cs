using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;

namespace Moqunity
{
	public class DefaultFactory : Factory
	{
		public Application Application { get; private set; }
		public void Init()
		{
			Application = new DefaultApplication();
		}
	}
}
