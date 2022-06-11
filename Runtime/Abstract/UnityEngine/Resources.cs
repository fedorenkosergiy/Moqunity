namespace Moqunity.Abstract.UnityEngine
{
	/// <summary>
	///   <para>The Resources class allows you to find and access Objects including assets.</para>
	/// </summary>
	public partial interface Resources : StaticWrapper
	{
		/// <summary>
		///   <para>Returns a list of all objects of Type type.</para>
		/// </summary>
		/// <param name="type"></param>
		global::UnityEngine.Object[] FindObjectsOfTypeAll(global::System.Type type);

		T[] FindObjectsOfTypeAll<T>() where T : global::UnityEngine.Object;

		/// <summary>
		///   <para>Loads an asset stored at path in a Resources folder using an optional systemTypeInstance filter.</para>
		/// </summary>
		/// <param name="path">Path to the target resource to load.</param>
		/// <param name="systemTypeInstance">Type filter for objects returned.</param>
		/// <returns>
		///   <para>The requested asset returned as an Object.</para>
		/// </returns>
		global::UnityEngine.Object Load(string path);

		T Load<T>(string path) where T : global::UnityEngine.Object;

		/// <summary>
		///   <para>Loads an asset stored at path in a Resources folder using an optional systemTypeInstance filter.</para>
		/// </summary>
		/// <param name="path">Path to the target resource to load.</param>
		/// <param name="systemTypeInstance">Type filter for objects returned.</param>
		/// <returns>
		///   <para>The requested asset returned as an Object.</para>
		/// </returns>
		global::UnityEngine.Object Load(string path, global::System.Type systemTypeInstance);

		/// <summary>
		///   <para>Asynchronously loads an asset stored at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder. When using the empty string (i.e., ""), the function will load the entire contents of the Resources folder.</param>
		global::UnityEngine.ResourceRequest LoadAsync(string path);

		global::UnityEngine.ResourceRequest LoadAsync<T>(string path) where T : global::UnityEngine.Object;

		/// <summary>
		///   <para>Asynchronously loads an asset stored at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder. When using the empty string (i.e., ""), the function will load the entire contents of the Resources folder.</param>
		/// <param name="systemTypeInstance">Type filter for objects returned.</param>
		/// <param name="type"></param>
		global::UnityEngine.ResourceRequest LoadAsync(string path, global::System.Type type);

		/// <summary>
		///   <para>Loads all assets in a folder or file at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder. When using the empty string (i.e., ""), the function will load the entire contents of the Resources folder.</param>
		/// <param name="systemTypeInstance">Type filter for objects returned.</param>
		global::UnityEngine.Object[] LoadAll(string path, global::System.Type systemTypeInstance);

		/// <summary>
		///   <para>Loads all assets in a folder or file at path in a Resources folder.</para>
		/// </summary>
		/// <param name="path">Pathname of the target folder. When using the empty string (i.e., ""), the function will load the entire contents of the Resources folder.</param>
		/// <param name="systemTypeInstance">Type filter for objects returned.</param>
		global::UnityEngine.Object[] LoadAll(string path);

		T[] LoadAll<T>(string path) where T : global::UnityEngine.Object;

		global::UnityEngine.Object GetBuiltinResource(global::System.Type type, string path);

		T GetBuiltinResource<T>(string path) where T : global::UnityEngine.Object;

		/// <summary>
		///   <para>Unloads assetToUnload from memory.</para>
		/// </summary>
		/// <param name="assetToUnload"></param>
		void UnloadAsset(global::UnityEngine.Object assetToUnload);

		/// <summary>
		///   <para>Unloads assets that are not used.</para>
		/// </summary>
		/// <returns>
		///   <para>Object on which you can yield to wait until the operation completes.</para>
		/// </returns>
		global::UnityEngine.AsyncOperation UnloadUnusedAssets();

		/// <summary>
		///   <para>Translates an instance ID to an object reference.</para>
		/// </summary>
		/// <param name="instanceID">Instance ID of an Object.</param>
		/// <returns>
		///   <para>Resolved reference or null if the instance ID didn't match anything.</para>
		/// </returns>
		global::UnityEngine.Object InstanceIDToObject(int instanceID);

		void InstanceIDToObjectList(
			global::Unity.Collections.NativeArray<int> instanceIDs,
			global::System.Collections.Generic.List<global::UnityEngine.Object> objects);
	}
}
