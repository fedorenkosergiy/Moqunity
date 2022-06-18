using System;
using Object = UnityEngine.Object;

namespace Moqunity.UnityEngine
{
	public sealed partial class DefaultResources
	{
#if UNITY_5_2 || UNITY_5_3_OR_NEWER
	[global::System.Obsolete(
		"Use AssetDatabase.LoadAssetAtPath instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath(*)",
		true)]
#endif
		public Object LoadAssetAtPath(string assetPath, Type type)
		{
#if UNITY_5_2 || UNITY_5_3_OR_NEWER
			throw new global::System.NotImplementedException();
#else
			return global::UnityEngine.Resources.LoadAssetAtPath(assetPath, type);
#endif
		}

#if UNITY_5_2 || UNITY_5_3_OR_NEWER
		[global::System.Obsolete(
			"Use AssetDatabase.LoadAssetAtPath<T>() instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath<T>(*)",
			true)]
#endif
		public T LoadAssetAtPath<T>(string assetPath) where T : Object
		{
#if UNITY_5_2 || UNITY_5_3_OR_NEWER
			throw new global::System.NotImplementedException();
#else
			return global::UnityEngine.Resources.LoadAssetAtPath<T>(assetPath);
#endif
		}
	}
}
