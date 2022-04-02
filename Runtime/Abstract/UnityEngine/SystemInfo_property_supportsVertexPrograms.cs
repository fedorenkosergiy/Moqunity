namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
		[global::System.Obsolete("Vertex program support is required in Unity 5.0+")]
		public bool supportsVertexPrograms { get; }

	}
}