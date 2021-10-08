using System;
using UnityEngine;
using UnityEngine.Events;

namespace Moqunity.Abstract.UnityEngine
{
	/// <summary>
	/// Access to application run-time data.
	/// </summary>
	public interface Application
	{
		/// <summary>
		/// Returns application version number (Read Only).
		/// </summary>
		string version { get; }

		/// <summary>
		/// The version of the Unity runtime used to play the content.
		/// </summary>
		string unityVersion { get; }

		/// <summary>
		/// The URL of the document. For WebGL, this a web URL. For Android, iOS, or Universal Windows Platform (UWP) this is a deep link URL. (Read Only)
		/// </summary>
		string absoluteURL { get; }

		/// <summary>
		/// Contains the path to a temporary data / cache directory (Read Only).
		/// </summary>
		string temporaryCachePath { get; }

		/// <summary>
		/// Contains the path to a persistent data directory (Read Only).
		/// </summary>
		string persistentDataPath { get; }

		/// <summary>
		/// The path to the StreamingAssets folder (Read Only).
		/// </summary>
		string streamingAssetsPath { get; }

		/// <summary>
		/// Returns the name of the store or package that installed the application (Read Only).
		/// </summary>
		string installerName { get; }

		/// <summary>
		/// Contains the path to the game data folder on the target device (Read Only).
		/// </summary>
		string dataPath { get; }

		/// <summary>
		/// Returns a GUID for this build (Read Only).
		/// </summary>
		string buildGUID { get; }

		/// <summary>
		/// Whether the player currently has focus. Read-only.
		/// </summary>
		bool isFocused { get; }

		/// <summary>
		/// Returns true when called in any kind of built Player, or when called in the Editor in Play Mode (Read Only).
		/// </summary>
		bool isPlaying { get; }

		/// <summary>
		/// Returns true when Unity is launched with the -batchmode flag from the command line (Read Only).
		/// </summary>
		bool isBatchMode { get; }

		/// <summary>
		/// Returns application identifier at runtime. On Apple platforms this is the 'bundleIdentifier' saved in the info.plist file, on Android it's the 'package' from the AndroidManifest.xml.
		/// </summary>
		string identifier { get; }

		/// <summary>
		/// Returns application install mode (Read Only).
		/// </summary>
		ApplicationInstallMode installMode { get; }

		/// <summary>
		/// Returns application running in sandbox (Read Only).
		/// </summary>
		ApplicationSandboxType sandboxType { get; }

		/// <summary>
		/// Returns the type of Internet reachability currently possible on the device.
		/// </summary>
		NetworkReachability internetReachability { get; }

		/// <summary>
		/// The language the user's operating system is running in.
		/// </summary>
		SystemLanguage systemLanguage { get; }

		/// <summary>
		/// Is the current Runtime platform a known console platform.
		/// </summary>
		bool isConsolePlatform { get; }

		/// <summary>
		/// Is the current Runtime platform a known mobile platform.
		/// </summary>
		bool isMobilePlatform { get; }

		/// <summary>
		/// Returns the platform the game is running on (Read Only).
		/// </summary>
		RuntimePlatform platform { get; }

		/// <summary>
		/// Returns true if application integrity can be confirmed.
		/// </summary>
		bool genuineCheckAvailable { get; }

		/// <summary>
		/// Returns false if application is altered in any way after it was built.
		/// </summary>
		bool genuine { get; }

		/// <summary>
		/// Priority of background loading thread.
		/// </summary>
		ThreadPriority backgroundLoadingPriority { get; set; }

		/// <summary>
		/// Returns the path to the console log file, or an empty string if the current platform does not support log files.
		/// </summary>
		string consoleLogPath { get; }

		/// <summary>
		/// Instructs the game to try to render at a specified frame rate.
		/// </summary>
		int targetFrameRate { get; set; }

		/// <summary>
		/// A unique cloud project identifier. It is unique for every project (Read Only).
		/// </summary>
		string cloudProjectId { get; }

		/// <summary>
		/// Return application company name (Read Only).
		/// </summary>
		string companyName { get; }

		/// <summary>
		/// Returns application product name (Read Only).
		/// </summary>
		string productName { get; }

		/// <summary>
		/// Should the player be running when the application is in the background?
		/// </summary>
		bool runInBackground { get; set; }

		/// <summary>
		/// Are we running inside the Unity editor? (Read Only)
		/// </summary>
		bool isEditor { get; }

		event UnityAction onBeforeRender;
		event Action quitting;
		event Func<bool> wantsToQuit;
		event global::UnityEngine.Application.LowMemoryCallback lowMemory;
		event global::UnityEngine.Application.LogCallback logMessageReceived;
		event Action<string> deepLinkActivated;
		event global::UnityEngine.Application.LogCallback logMessageReceivedThreaded;
		event Action<bool> focusChanged;

		/// <summary>
		/// Can the streamed level be loaded?
		/// </summary>
		/// <param name="levelIndex"></param>
		/// <returns></returns>
		bool CanStreamedLevelBeLoaded(int levelIndex);

		/// <summary>
		/// Can the streamed level be loaded?
		/// </summary>
		/// <param name="levelName"></param>
		/// <returns></returns>
		bool CanStreamedLevelBeLoaded(string levelName);

		/// <summary>
		/// Returns an array of feature tags in use for this build.
		/// </summary>
		/// <returns></returns>
		string[] GetBuildTags();

		/// <summary>
		/// Get stack trace logging options. The default value is StackTraceLogType.ScriptOnly.
		/// </summary>
		/// <param name="logType"></param>
		/// <returns></returns>
		StackTraceLogType GetStackTraceLogType(LogType logType);

		/// <summary>
		/// Is Unity activated with the Pro license?
		/// </summary>
		/// <returns></returns>
		bool HasProLicense();

		/// <summary>
		/// Check if the user has authorized use of the webcam or microphone in the Web Player.
		/// </summary>
		/// <param name="mode"></param>
		/// <returns></returns>
		bool HasUserAuthorization(UserAuthorization mode);

		/// <summary>
		/// Returns true if the given object is part of the playing world either in any kind of built Player or in Play Mode.
		/// </summary>
		/// <param name="obj">The object to test.</param>
		/// <returns>True if the object is part of the playing world.</returns>
		bool IsPlaying(global::UnityEngine.Object obj);

		/// <summary>
		/// Opens the URL specified, subject to the permissions and limitations of your app’s current platform and environment. This is handled in different ways depending on the nature of the URL, and with different security restrictions, depending on the runtime platform.
		/// </summary>
		/// <param name="url">The URL to open.</param>
		void OpenURL(string url);

		/// <summary>
		/// Quits the player application.
		/// </summary>
		/// <param name="exitCode">An optional exit code to return when the player application terminates on Windows, macOS, and Linux. Defaults to 0.</param>
		void Quit(int exitCode);

		/// <summary>
		/// Quits the player application.
		/// </summary>
		void Quit();

		bool RequestAdvertisingIdentifierAsync(global::UnityEngine.Application.AdvertisingIdentifierCallback delegateMethod);

		/// <summary>
		/// Request authorization to use the webcam or microphone on iOS.
		/// </summary>
		/// <param name="mode"></param>
		/// <returns></returns>
		AsyncOperation RequestUserAuthorization(UserAuthorization mode);

		/// <summary>
		/// Set an array of feature tags for this build.
		/// </summary>
		/// <param name="buildTags"></param>
		void SetBuildTags(string[] buildTags);

		/// <summary>
		/// Set stack trace logging options. The default value is StackTraceLogType.ScriptOnly.
		/// </summary>
		/// <param name="logType"></param>
		/// <param name="stackTraceType"></param>
		void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType);

		/// <summary>
		/// Unloads release memory acquired by the Unity Player and keeps current process alive.
		/// </summary>
		void Unload();
	}
}
