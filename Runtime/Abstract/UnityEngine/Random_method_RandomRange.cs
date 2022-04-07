namespace Moqunity.Abstract.UnityEngine
{
	public partial interface Random
	{
		[global::System.Obsolete("Use Random.Range instead")]
		float RandomRange(float min, float max);

		[global::System.Obsolete("Use Random.Range instead")]
		int RandomRange(int min, int max);
	}
}