#if UNITY_WSA
using File = Moqunity.Abstract.UnityEngine.Windows.File;

namespace Moqunity.UnityEngine.Windows
{
	public class DefaultFile : File
	{
		public byte[] ReadAllBytes(string path) => global::UnityEngine.Windows.File.ReadAllBytes(path);
		public void WriteAllBytes(string path, byte[] bytes) => global::UnityEngine.Windows.File.WriteAllBytes(path, bytes);
		public bool Exists(string path) => global::UnityEngine.Windows.File.Exists(path);
		public void Delete(string path) => global::UnityEngine.Windows.File.Delete(path);
	}
}
#endif
