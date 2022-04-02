namespace Moqunity.UnityEngine
{
	public partial class DefaultSystemInfo
	{
#if UNITY_5_3_OR_NEWER
		[global::System.Obsolete("graphicsPixelFillrate is no longer supported in Unity 5.0+.")]
#endif
		public int graphicsPixelFillrate => global::UnityEngine.SystemInfo.graphicsPixelFillrate;
	}
}