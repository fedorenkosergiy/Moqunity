namespace Moqunity.Abstract.UnityEngine
{
	public partial interface Random
	{
#if UNITY_5_4_OR_NEWER
		[global::System.Obsolete("Deprecated. Use InitState() function or Random.state property instead.")]
#endif
		int seed { get; set; }
	}
}