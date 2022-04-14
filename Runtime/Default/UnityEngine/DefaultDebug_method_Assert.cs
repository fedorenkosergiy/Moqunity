namespace Moqunity.UnityEngine
{
	public partial class DefaultDebug
	{
		[global::System.Obsolete(
			"Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)",
			true)]
		public void Assert(bool condition, string format, params object[] args)
		{
			global::UnityEngine.Debug.Assert(condition, format, args);
		}
	}
}
