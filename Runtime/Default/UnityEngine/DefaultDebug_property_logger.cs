namespace Moqunity.UnityEngine
{
	public partial class DefaultDebug
	{
		[global::System.Obsolete("Debug.logger is obsolete. Please use Debug.unityLogger instead (UnityUpgradable) -> unityLogger")]
		public global::UnityEngine.ILogger logger => global::UnityEngine.Debug.logger;
	}
}
