namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
#if UNITY_5_3_OR_NEWER
		[global::System.Obsolete("graphicsPixelFillrate is no longer supported in Unity 5.0+.")]
#endif
		public int graphicsPixelFillrate { get; }
	}
}