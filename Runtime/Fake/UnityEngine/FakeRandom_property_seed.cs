namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeRandom
	{
#if UNITY_5_4_OR_NEWER
		[global::System.Obsolete("Deprecated. Use InitState() function or Random.state property instead.")]
#endif
		public virtual int seed
		{
			get => throw new System.NotImplementedException();
			set => throw new System.NotImplementedException();
		}
	}
}