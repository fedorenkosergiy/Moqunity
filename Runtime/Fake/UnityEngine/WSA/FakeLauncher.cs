#if UNITY_WSA
using System;
using UnityEngine.WSA;

namespace Moqunity.Fake.UnityEngine.WSA
{
	public class FakeLauncher : global::Moqunity.Abstract.UnityEngine.WSA.Launcher
	{
		public virtual void LaunchFile(Folder folder, string relativeFilePath, bool showWarning) => throw new NotImplementedException();
		public virtual void LaunchFileWithPicker(string fileExtension) => throw new NotImplementedException();
		public virtual void LaunchUri(string uri, bool showWarning) => throw new NotImplementedException();
	}
}
#endif