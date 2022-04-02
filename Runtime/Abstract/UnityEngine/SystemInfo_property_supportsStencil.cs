namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
		/// <summary>
		///   <para>Is the stencil buffer supported? (Read Only)</para>
		/// </summary>
		[global::System.Obsolete("supportsStencil always returns true, no need to call it")]
		public int supportsStencil { get; }
	}
}