using System;
using Object = UnityEngine.Object;

namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeResources
	{
#if UNITY_5_2_OR_NEWER
	[global::System.Obsolete(
		"Use AssetDatabase.LoadAssetAtPath instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath(*)",
		true)]
#endif
		public virtual Object LoadAssetAtPath(string assetPath, Type type)
		{
			throw new NotImplementedException();
		}

#if UNITY_5_2_OR_NEWER
		[global::System.Obsolete(
			"Use AssetDatabase.LoadAssetAtPath<T>() instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath<T>(*)",
			true)]
#endif
		public virtual T LoadAssetAtPath<T>(string assetPath) where T : Object
		{
			throw new NotImplementedException();
		}
	}
}
