using UnityEngine.WSA;

namespace Moqunity.UnityEngine.WSA
{
	public class DefaultLauncher : global::Moqunity.Abstract.UnityEngine.WSA.Launcher
	{
		public virtual void LaunchFile(Folder folder, string relativeFilePath, bool showWarning) => global::UnityEngine.WSA.Launcher.LaunchFile(folder, relativeFilePath, showWarning);
		public virtual void LaunchFileWithPicker(string fileExtension) => global::UnityEngine.WSA.Launcher.LaunchFileWithPicker(fileExtension);
		public virtual void LaunchUri(string uri, bool showWarning) => global::UnityEngine.WSA.Launcher.LaunchUri(uri, showWarning);
	}
}