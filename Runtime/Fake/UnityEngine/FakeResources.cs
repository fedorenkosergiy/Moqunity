using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeResources : global::Moqunity.Abstract.UnityEngine.Resources
	{
		public virtual Object[] FindObjectsOfTypeAll(Type type)
		{
			throw new NotImplementedException();
		}

		public virtual T[] FindObjectsOfTypeAll<T>() where T : Object
		{
			throw new NotImplementedException();
		}

		public virtual Object Load(string path)
		{
			throw new NotImplementedException();
		}

		public virtual T Load<T>(string path) where T : Object
		{
			throw new NotImplementedException();
		}

		public virtual Object Load(string path, Type systemTypeInstance)
		{
			throw new NotImplementedException();
		}

		public virtual ResourceRequest LoadAsync(string path)
		{
			throw new NotImplementedException();
		}

		public virtual ResourceRequest LoadAsync<T>(string path) where T : Object
		{
			throw new NotImplementedException();
		}

		public virtual ResourceRequest LoadAsync(string path, Type type)
		{
			throw new NotImplementedException();
		}

		public virtual Object[] LoadAll(string path, Type systemTypeInstance)
		{
			throw new NotImplementedException();
		}

		public virtual Object[] LoadAll(string path)
		{
			throw new NotImplementedException();
		}

		public virtual T[] LoadAll<T>(string path) where T : Object
		{
			throw new NotImplementedException();
		}

		public virtual Object GetBuiltinResource(Type type, string path)
		{
			throw new NotImplementedException();
		}

		public virtual T GetBuiltinResource<T>(string path) where T : Object
		{
			throw new NotImplementedException();
		}

		public virtual void UnloadAsset(Object assetToUnload)
		{
			throw new NotImplementedException();
		}

		public virtual AsyncOperation UnloadUnusedAssets()
		{
			throw new NotImplementedException();
		}

		public virtual Object InstanceIDToObject(int instanceID)
		{
			throw new NotImplementedException();
		}

		public virtual void InstanceIDToObjectList(NativeArray<int> instanceIDs, List<Object> objects)
		{
			throw new NotImplementedException();
		}
	}
}
