namespace Moqunity.UnityEngine
{
	public partial class DefaultSystemInfo
	{
#if UNITY_5_6_OR_NEWER
		[global::System.Obsolete("supportsRenderTextures always returns true, no need to call it")]
#endif
		public bool supportsRenderTextures => global::UnityEngine.SystemInfo.supportsRenderTextures;
	}
}