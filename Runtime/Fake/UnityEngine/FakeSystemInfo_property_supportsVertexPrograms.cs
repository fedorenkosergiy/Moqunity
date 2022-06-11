namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeSystemInfo
	{
#if UNITY_5_3_OR_NEWER
		[global::System.Obsolete("Vertex program support is required in Unity 5.0+")]
#endif
		public virtual bool supportsVertexPrograms => throw new global::System.NotImplementedException();
	}
}
