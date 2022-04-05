namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
		/// <summary>
		///   <para>Is the stencil buffer supported? (Read Only)</para>
		/// </summary>
		#if UNITY_5_5_OR_NEWER
		[global::System.Obsolete("supportsStencil always returns true, no need to call it")]
		#endif
		public int supportsStencil { get; }
	}
}