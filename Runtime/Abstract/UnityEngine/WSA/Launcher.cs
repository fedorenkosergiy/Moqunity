namespace Moqunity.Abstract.UnityEngine.WSA
{
	/// <summary>
	///   <para>Class which is capable of launching user's default app for file type or a protocol. See also PlayerSettings where you can specify file or URI associations.</para>
	/// </summary>
	public interface Launcher : StaticWrapper
	{
		/// <summary>
		///   <para>Launches the default app associated with specified file.</para>
		/// </summary>
		/// <param name="folder">Folder type where the file is located.</param>
		/// <param name="relativeFilePath">Relative file path inside the specified folder.</param>
		/// <param name="showWarning">Shows user a warning that application will be switched.</param>
		void LaunchFile(global::UnityEngine.WSA.Folder folder, string relativeFilePath, bool showWarning);

		/// <summary>
		///   <para>Opens a dialog for picking the file.</para>
		/// </summary>
		/// <param name="fileExtension">File extension.</param>
		void LaunchFileWithPicker(string fileExtension);

		/// <summary>
		///   <para>Starts the default app associated with the URI scheme name for the specified URI, using the specified options.</para>
		/// </summary>
		/// <param name="uri">The URI.</param>
		/// <param name="showWarning">Displays a warning that the URI is potentially unsafe.</param>
		void LaunchUri(string uri, bool showWarning);
	}
}
