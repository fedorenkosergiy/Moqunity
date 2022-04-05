namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
		#if UNITY_5_3_OR_NEWER
		[global::System.Obsolete("Vertex program support is required in Unity 5.0+")]
		#endif
		public bool supportsVertexPrograms { get; }

	}
}