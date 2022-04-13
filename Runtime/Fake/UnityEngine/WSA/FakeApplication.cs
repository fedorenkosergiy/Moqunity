#if UNITY_WSA
using System;
using UnityEngine.WSA;

namespace Moqunity.Fake.UnityEngine.WSA
{
	public class FakeApplication : global::Moqunity.Abstract.UnityEngine.WSA.Application
	{
		public virtual string arguments => throw new NotImplementedException();
		public virtual string advertisingIdentifier => throw new NotImplementedException();

		public virtual event WindowSizeChanged windowSizeChanged;
		public virtual event WindowActivated windowActivated;

		public virtual void InvokeOnAppThread(AppCallbackItem item, bool waitUntilDone) => throw new NotImplementedException();
		public virtual void InvokeOnUIThread(AppCallbackItem item, bool waitUntilDone) => throw new NotImplementedException();
		public virtual bool RunningOnAppThread() => throw new NotImplementedException();
		public virtual bool RunningOnUIThread() => throw new NotImplementedException();

        public void InvokeWindowSizeChanged(int width, int height) => windowSizeChanged(width, height);
        public void InvokeWindowActivated(WindowActivationState state) => windowActivated(state);
	}
}
#endif