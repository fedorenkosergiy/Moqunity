using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;

namespace Moqunity
{
	public class DefaultFactory : Factory
	{
		private Application application;

		public Application Application => application ?? (application = new DefaultApplication());
	}
}
