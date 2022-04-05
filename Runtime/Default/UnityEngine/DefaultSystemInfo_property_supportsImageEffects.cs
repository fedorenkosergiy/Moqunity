namespace Moqunity.UnityEngine
{
	public partial class DefaultSystemInfo
	{
#if UNITY_2019_1_OR_NEWER
		[global::System.Obsolete("supportsImageEffects always returns true, no need to call it")]
#endif
		public bool supportsImageEffects => global::UnityEngine.SystemInfo.supportsImageEffects;
	}
}