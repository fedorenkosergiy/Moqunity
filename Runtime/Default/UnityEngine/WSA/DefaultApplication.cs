#if UNITY_WSA
using System;
using UnityEngine.WSA;

namespace Moqunity.UnityEngine.WSA
{
	public class DefaultApplication : global::Moqunity.Abstract.UnityEngine.WSA.Application
	{
		public string arguments => global::UnityEngine.WSA.Application.arguments;
		public string advertisingIdentifier => global::UnityEngine.WSA.Application.advertisingIdentifier;

		public event WindowSizeChanged windowSizeChanged
        {
            add => global::UnityEngine.WSA.Application.windowSizeChanged += value;
            remove => global::UnityEngine.WSA.Application.windowSizeChanged -= value;
        }
		public event WindowActivated windowActivated
        {
            add => global::UnityEngine.WSA.Application.windowActivated += value;
            remove => global::UnityEngine.WSA.Application.windowActivated -= value;
        }

		public void InvokeOnAppThread(AppCallbackItem item, bool waitUntilDone) => global::UnityEngine.WSA.Application.InvokeOnAppThread(item, waitUntilDone);
		public void InvokeOnUIThread(AppCallbackItem item, bool waitUntilDone) => global::UnityEngine.WSA.Application.InvokeOnUIThread(item, waitUntilDone);
		public bool RunningOnAppThread() => global::UnityEngine.WSA.Application.RunningOnAppThread();
		public bool RunningOnUIThread() => global::UnityEngine.WSA.Application.RunningOnUIThread();
	}
}
#endif