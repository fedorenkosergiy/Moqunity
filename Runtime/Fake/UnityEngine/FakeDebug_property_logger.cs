namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeDebug
	{
		[global::System.Obsolete("Debug.logger is obsolete. Please use Debug.unityLogger instead (UnityUpgradable) -> unityLogger")]
		public virtual global::UnityEngine.ILogger logger => throw new global::System.NotImplementedException();
	}
}
