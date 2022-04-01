namespace Moqunity.UnityEngine
{
	public partial class DefaultSystemInfo
	{
#if UNITY_2019_4_OR_NEWER
		[global::System.Obsolete("SystemInfo.supportsGPUFence has been deprecated, use SystemInfo.supportsGraphicsFence instead (UnityUpgradable) ->  supportsGraphicsFence", true)]
#elif UNITY_2019_1_OR_NEWER
		[global::System.Obsolete("SystemInfo.supportsGPUFence has been deprecated, use SystemInfo.supportsGraphicsFence instead (UnityUpgradable) ->  supportsGraphicsFence", false)]
#endif
		public bool supportsGPUFence => global::UnityEngine.SystemInfo.supportsGPUFence;
	}
}