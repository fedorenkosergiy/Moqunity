namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
		/// <summary>
		///   <para>Are render textures supported? (Read Only)</para>
		/// </summary>
#if UNITY_5_6_OR_NEWER
		[global::System.Obsolete("supportsRenderTextures always returns true, no need to call it")]
#endif
		public bool supportsRenderTextures { get; }
	}
}