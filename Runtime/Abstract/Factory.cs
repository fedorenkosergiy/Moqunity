using Moqunity.Abstract.UnityEngine;
namespace Moqunity.Abstract
{
	public interface Factory
	{
		Application Application { get; }

		Screen Screen { get; }

		Input Input { get; }

		void Init();
	}
}
