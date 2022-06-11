namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeSystemInfo
	{
#if UNITY_2019_4_OR_NEWER
		[global::System.Obsolete("SystemInfo.supportsGPUFence has been deprecated, use SystemInfo.supportsGraphicsFence instead (UnityUpgradable) ->  supportsGraphicsFence", true)]
#elif UNITY_2019_1_OR_NEWER
		[global::System.Obsolete("SystemInfo.supportsGPUFence has been deprecated, use SystemInfo.supportsGraphicsFence instead (UnityUpgradable) ->  supportsGraphicsFence", false)]
#endif
		public virtual bool supportsGPUFence => throw new global::System.NotImplementedException();
	}
}
