namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeSystemInfo
	{
#if UNITY_2019_1_OR_NEWER
		[global::System.Obsolete("supportsImageEffects always returns true, no need to call it")]
#endif
		public virtual bool supportsImageEffects => throw new System.NotImplementedException();
	}
}