namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeSystemInfo
	{
#if UNITY_5_3_OR_NEWER
		[global::System.Obsolete("graphicsPixelFillrate is no longer supported in Unity 5.0+.")]
#endif
		public virtual int graphicsPixelFillrate => throw new System.NotImplementedException();
	}
}