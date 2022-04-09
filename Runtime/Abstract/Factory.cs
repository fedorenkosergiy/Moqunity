using Moqunity.Abstract.UnityEngine;

namespace Moqunity.Abstract
{
	public interface Factory
	{
		Application Application { get; }

		Screen Screen { get; }

		Input Input { get; }

		Time Time { get; }

		SystemInfo SystemInfo { get; }

		Random Random { get; }

		void Init();

		public T Get<T>() where T : StaticWrapper;
	}
}
