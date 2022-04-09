namespace Moqunity.Abstract.UnityEngine.WSA
{
	/// <summary>
	///   <para>Cursor API for Windows Store Apps.</para>
	/// </summary>
	public interface Cursor : StaticWrapper
	{
		/// <summary>
		///   <para>Set a custom cursor.</para>
		/// </summary>
		/// <param name="id">The cursor resource id.</param>
		void SetCustomCursor(uint id);
	}
}
