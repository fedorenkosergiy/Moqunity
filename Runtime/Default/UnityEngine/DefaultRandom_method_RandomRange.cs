namespace Moqunity.UnityEngine
{
	public partial class DefaultRandom : global::Moqunity.Abstract.UnityEngine.Random
	{
		[global::System.Obsolete("Use Random.Range instead")]
		public float RandomRange(float min, float max) => global::UnityEngine.Random.RandomRange(min, max);

		[global::System.Obsolete("Use Random.Range instead")]
		public int RandomRange(int min, int max) => global::UnityEngine.Random.RandomRange(min, max);
	}
}