#if UNITY_WSA
using File = Moqunity.Abstract.UnityEngine.Windows.File;

namespace Moqunity.Fake.UnityEngine.Windows
{
	public class FakeFile : File
	{
		public virtual byte[] ReadAllBytes(string path) => throw new System.NotImplementedException();
		public virtual void WriteAllBytes(string path, byte[] bytes) => throw new System.NotImplementedException();
		public virtual bool Exists(string path) => throw new System.NotImplementedException();
		public virtual void Delete(string path) => throw new System.NotImplementedException();
	}
}
#endif
