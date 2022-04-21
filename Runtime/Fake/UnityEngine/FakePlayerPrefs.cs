using Moqunity.Abstract.UnityEngine;

namespace Moqunity.Fake.UnityEngine
{
	public class FakePlayerPrefs : PlayerPrefs
	{
		public virtual void SetInt(string key, int value) => throw new System.NotImplementedException();

		public virtual int GetInt(string key, int defaultValue) => throw new System.NotImplementedException();

		public virtual int GetInt(string key) => throw new System.NotImplementedException();

		public virtual void SetFloat(string key, float value) => throw new System.NotImplementedException();

		public virtual float GetFloat(string key, float defaultValue) => throw new System.NotImplementedException();

		public virtual float GetFloat(string key) => throw new System.NotImplementedException();

		public virtual void SetString(string key, string value) => throw new System.NotImplementedException();

		public virtual string GetString(string key, string defaultValue) => throw new System.NotImplementedException();

		public virtual string GetString(string key) => throw new System.NotImplementedException();

		public virtual bool HasKey(string key) => throw new System.NotImplementedException();

		public virtual void DeleteKey(string key) => throw new System.NotImplementedException();

		public virtual void DeleteAll() => throw new System.NotImplementedException();

		public virtual void Save() => throw new System.NotImplementedException();
	}
}
