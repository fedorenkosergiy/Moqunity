namespace Moqunity.UnityEngine
{
	public partial class DefaultSystemInfo
	{
#if UNITY_5_5_OR_NEWER
		[global::System.Obsolete("supportsStencil always returns true, no need to call it")]
#endif
		public int supportsStencil => global::UnityEngine.SystemInfo.supportsStencil;
	}
}