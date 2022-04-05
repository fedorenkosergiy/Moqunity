namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeSystemInfo
	{
#if UNITY_5_6_OR_NEWER
		[global::System.Obsolete("supportsRenderTextures always returns true, no need to call it")]
#endif
		public virtual bool supportsRenderTextures => throw new System.NotImplementedException();
	}
}