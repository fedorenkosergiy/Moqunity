using System;

namespace Moqunity.Abstract.UnityEngine
{
	public partial interface Debug
	{
		[Obsolete(
			"Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)",
			true)]
		void Assert(bool condition, string format, params object[] args);
	}
}
