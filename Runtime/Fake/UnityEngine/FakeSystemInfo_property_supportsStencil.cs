namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeSystemInfo
	{
#if UNITY_5_5_OR_NEWER
		[global::System.Obsolete("supportsStencil always returns true, no need to call it")]
#endif
		public virtual int supportsStencil => throw new global::System.NotImplementedException();
	}
}
