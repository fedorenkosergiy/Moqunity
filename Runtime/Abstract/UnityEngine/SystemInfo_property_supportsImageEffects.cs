namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
		/// <summary>
		///   <para>Are image effects supported? (Read Only)</para>
		/// </summary>
#if UNITY_2019_1_OR_NEWER
		[global::System.Obsolete("supportsImageEffects always returns true, no need to call it")]
#endif
		public bool supportsImageEffects { get; }

	}
}