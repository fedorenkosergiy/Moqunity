namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeDebug
	{
		[global::System.Obsolete(
			"Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)",
			true)]
		public virtual void Assert(bool condition, string format, params object[] args)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
