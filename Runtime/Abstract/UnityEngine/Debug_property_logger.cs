using System;
using UnityEngine;

namespace Moqunity.Abstract.UnityEngine
{
	public partial interface Debug
	{
		[Obsolete("Debug.logger is obsolete. Please use Debug.unityLogger instead (UnityUpgradable) -> unityLogger")]
		ILogger logger { get; }
	}
}
