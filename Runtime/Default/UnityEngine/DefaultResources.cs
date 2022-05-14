using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Moqunity.UnityEngine
{
	public sealed partial class DefaultResources : global::Moqunity.Abstract.UnityEngine.Resources
	{
		public Object[] FindObjectsOfTypeAll(Type type)
		{
			return Resources.FindObjectsOfTypeAll(type);
		}

		public T[] FindObjectsOfTypeAll<T>() where T : Object
		{
			return Resources.FindObjectsOfTypeAll<T>();
		}

		public Object Load(string path)
		{
			return Resources.Load(path);
		}

		public T Load<T>(string path) where T : Object
		{
			return Resources.Load<T>(path);
		}

		public Object Load(string path, Type systemTypeInstance)
		{
			return Resources.Load(path, systemTypeInstance);
		}

		public ResourceRequest LoadAsync(string path)
		{
			return Resources.LoadAsync(path);
		}

		public ResourceRequest LoadAsync<T>(string path) where T : Object
		{
			return Resources.LoadAsync<T>(path);
		}

		public ResourceRequest LoadAsync(string path, Type type)
		{
			return Resources.LoadAsync(path, type);
		}

		public Object[] LoadAll(string path, Type systemTypeInstance)
		{
			return Resources.LoadAll(path, systemTypeInstance);
		}

		public Object[] LoadAll(string path)
		{
			return Resources.LoadAll(path);
		}

		public T[] LoadAll<T>(string path) where T : Object
		{
			return Resources.LoadAll<T>(path);
		}

		public Object GetBuiltinResource(Type type, string path)
		{
			return Resources.GetBuiltinResource(type, path);
		}

		public T GetBuiltinResource<T>(string path) where T : Object
		{
			return Resources.GetBuiltinResource<T>(path);
		}

		public void UnloadAsset(Object assetToUnload)
		{
			Resources.UnloadAsset(assetToUnload);
		}

		public AsyncOperation UnloadUnusedAssets()
		{
			return Resources.UnloadUnusedAssets();
		}

		public Object InstanceIDToObject(int instanceID)
		{
			return Resources.InstanceIDToObject(instanceID);
		}

		public void InstanceIDToObjectList(NativeArray<int> instanceIDs, List<Object> objects)
		{
			Resources.InstanceIDToObjectList(instanceIDs, objects);
		}
	}
}
