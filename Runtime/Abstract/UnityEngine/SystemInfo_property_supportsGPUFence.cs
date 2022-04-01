namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
		/// <summary>
		///   <para>This functionality is deprecated, and should no longer be used. Please use SystemInfo.supportsGraphicsFence.</para>
		/// </summary>
#if UNITY_2019_4_OR_NEWER
		[global::System.Obsolete("SystemInfo.supportsGPUFence has been deprecated, use SystemInfo.supportsGraphicsFence instead (UnityUpgradable) ->  supportsGraphicsFence", true)]
#elif UNITY_2019_1_OR_NEWER
		[global::System.Obsolete("SystemInfo.supportsGPUFence has been deprecated, use SystemInfo.supportsGraphicsFence instead (UnityUpgradable) ->  supportsGraphicsFence", false)]
#endif
		public bool supportsGPUFence { get; }
	}
}