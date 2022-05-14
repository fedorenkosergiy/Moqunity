namespace Moqunity.Abstract.UnityEngine
{
	public partial interface Resources
	{
		/// <summary>
		///   <para>Returns a resource at an asset path (Editor Only).</para>
		/// </summary>
		/// <param name="assetPath">Pathname of the target asset.</param>
		/// <param name="type">Type filter for objects returned.</param>
#if UNITY_5_2 || UNITY_5_3_OR_NEWER
		[global::System.Obsolete(
			"Use AssetDatabase.LoadAssetAtPath instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath(*)",
			true)]
#endif
		global::UnityEngine.Object LoadAssetAtPath(string assetPath, global::System.Type type);

#if UNITY_5_2 || UNITY_5_3_OR_NEWER
		[global::System.Obsolete(
			"Use AssetDatabase.LoadAssetAtPath<T>() instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath<T>(*)",
			true)]
#endif
		T LoadAssetAtPath<T>(string assetPath) where T : global::UnityEngine.Object;
	}
}
