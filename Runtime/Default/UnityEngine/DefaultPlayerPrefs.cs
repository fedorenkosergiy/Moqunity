using Moqunity.Abstract.UnityEngine;

namespace Moqunity.UnityEngine
{
	public class DefaultPlayerPrefs : PlayerPrefs
	{
		public void SetInt(string key, int value) => global::UnityEngine.PlayerPrefs.SetInt(key, value);

		public int GetInt(string key, int defaultValue) => global::UnityEngine.PlayerPrefs.GetInt(key, defaultValue);

		public int GetInt(string key) => global::UnityEngine.PlayerPrefs.GetInt(key);

		public void SetFloat(string key, float value) => global::UnityEngine.PlayerPrefs.SetFloat(key, value);

		public float GetFloat(string key, float defaultValue) =>
			global::UnityEngine.PlayerPrefs.GetFloat(key, defaultValue);

		public float GetFloat(string key) => global::UnityEngine.PlayerPrefs.GetFloat(key);

		public void SetString(string key, string value) => global::UnityEngine.PlayerPrefs.SetString(key, value);

		public string GetString(string key, string defaultValue) =>
			global::UnityEngine.PlayerPrefs.GetString(key, defaultValue);

		public string GetString(string key) => global::UnityEngine.PlayerPrefs.GetString(key);

		public bool HasKey(string key) => global::UnityEngine.PlayerPrefs.HasKey(key);

		public void DeleteKey(string key) => global::UnityEngine.PlayerPrefs.DeleteKey(key);

		public void DeleteAll() => global::UnityEngine.PlayerPrefs.DeleteAll();

		public void Save() => global::UnityEngine.PlayerPrefs.Save();
	}
}
