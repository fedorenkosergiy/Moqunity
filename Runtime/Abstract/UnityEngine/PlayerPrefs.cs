namespace Moqunity.Abstract.UnityEngine
{
	/// <summary>
	///   <para>`PlayerPrefs` is a class that stores Player preferences between game sessions. It can store string, float and integer values into the user’s platform registry.</para>
	/// </summary>
	public interface PlayerPrefs : StaticWrapper
	{
		/// <summary>
		///   <para>Sets a single integer value for the preference identified by the given key. You can use PlayerPrefs.GetInt to retrieve this value.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		void SetInt(string key, int value);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		int GetInt(string key, int defaultValue);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		int GetInt(string key);

		/// <summary>
		///   <para>Sets the float value of the preference identified by the given key. You can use PlayerPrefs.GetFloat to retrieve this value.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		void SetFloat(string key, float value);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		float GetFloat(string key, float defaultValue);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		float GetFloat(string key);

		/// <summary>
		///   <para>Sets a single string value for the preference identified by the given key. You can use PlayerPrefs.GetString to retrieve this value.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		void SetString(string key, string value);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		/// <param name="defaultValue"></param>
		string GetString(string key, string defaultValue);

		/// <summary>
		///   <para>Returns the value corresponding to key in the preference file if it exists.</para>
		/// </summary>
		/// <param name="key"></param>
		string GetString(string key);

		/// <summary>
		///   <para>Returns true if the given key exists in PlayerPrefs, otherwise returns false.</para>
		/// </summary>
		/// <param name="key"></param>
		bool HasKey(string key);

		/// <summary>
		///   <para>Removes the given key from the PlayerPrefs. If the key does not exist, DeleteKey has no impact.</para>
		/// </summary>
		/// <param name="key"></param>
		void DeleteKey(string key);

		/// <summary>
		///   <para>Removes all keys and values from the preferences. Use with caution.</para>
		/// </summary>
		void DeleteAll();

		/// <summary>
		///   <para>Writes all modified preferences to disk.</para>
		/// </summary>
		void Save();
	}
}
