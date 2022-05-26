using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;

namespace Moqunity
{
	public class TestingProvider : Provider
	{
		private Provider _innerProvider = new DefaultProvider();
		public virtual Application Application => _innerProvider.Application;
		public virtual Screen Screen => _innerProvider.Screen;
		public virtual Input Input => _innerProvider.Input;
		public virtual Time Time => _innerProvider.Time;
		public virtual SystemInfo SystemInfo => _innerProvider.SystemInfo;
		public virtual Random Random => _innerProvider.Random;
		public virtual Debug Debug => _innerProvider.Debug;
		public virtual PlayerPrefs PlayerPrefs => _innerProvider.PlayerPrefs;
		public virtual Resources Resources => _innerProvider.Resources;
		public virtual void Init() => _innerProvider.Init();
		public virtual T Get<T>() where T : StaticWrapper => _innerProvider.Get<T>();
	}
}
