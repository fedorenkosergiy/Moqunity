namespace Moqunity.UnityEngine
{
	public partial class DefaultRandom : global::Moqunity.Abstract.UnityEngine.Random
	{
#if UNITY_5_4_OR_NEWER
		[global::System.Obsolete("Deprecated. Use InitState() function or Random.state property instead.")]
#endif
		public int seed
		{
			get => global::UnityEngine.Random.seed;
			set => global::UnityEngine.Random.seed = value;
		}
	}
}