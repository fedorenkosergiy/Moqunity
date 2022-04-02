namespace Moqunity.UnityEngine
{
	public partial class DefaultSystemInfo
	{
#if UNITY_5_3_OR_NEWER
		[global::System.Obsolete("Vertex program support is required in Unity 5.0+")]
#endif
		public bool supportsVertexPrograms => global::UnityEngine.SystemInfo.supportsVertexPrograms;
	}
}