namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeRandom
	{
		[global::System.Obsolete("Use Random.Range instead")]
		public float RandomRange(float min, float max) => throw new global::System.NotImplementedException();

		[global::System.Obsolete("Use Random.Range instead")]
		public int RandomRange(int min, int max) => throw new global::System.NotImplementedException();
	}
}
