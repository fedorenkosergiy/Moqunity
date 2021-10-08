using System;
using Moqunity.Abstract.UnityEngine;

namespace Moqunity.UnityEngine
{
	public class DefaultApplication : Application
	{
		public string version => global::UnityEngine.Application.version;
		public string unityVersion => global::UnityEngine.Application.unityVersion;
		public string absoluteURL => global::UnityEngine.Application.absoluteURL;
		public string temporaryCachePath => global::UnityEngine.Application.temporaryCachePath;
		public string persistentDataPath => global::UnityEngine.Application.persistentDataPath;
		public string streamingAssetsPath => global::UnityEngine.Application.streamingAssetsPath;
		public string installerName => global::UnityEngine.Application.installerName;
		public string dataPath => global::UnityEngine.Application.dataPath;
		public string buildGUID => global::UnityEngine.Application.buildGUID;
		public bool isFocused => global::UnityEngine.Application.isFocused;
		public bool isPlaying => global::UnityEngine.Application.isPlaying;
		public bool isBatchMode => global::UnityEngine.Application.isBatchMode;
		public string identifier => global::UnityEngine.Application.identifier;
		public global::UnityEngine.ApplicationInstallMode installMode => global::UnityEngine.Application.installMode;
		public global::UnityEngine.ApplicationSandboxType sandboxType => global::UnityEngine.Application.sandboxType;

		public global::UnityEngine.NetworkReachability internetReachability =>
			global::UnityEngine.Application.internetReachability;

		public global::UnityEngine.SystemLanguage systemLanguage => global::UnityEngine.Application.systemLanguage;
		public bool isConsolePlatform => global::UnityEngine.Application.isConsolePlatform;
		public bool isMobilePlatform => global::UnityEngine.Application.isMobilePlatform;
		public global::UnityEngine.RuntimePlatform platform => global::UnityEngine.Application.platform;
		public bool genuineCheckAvailable => global::UnityEngine.Application.genuineCheckAvailable;
		public bool genuine => global::UnityEngine.Application.genuine;

		public global::UnityEngine.ThreadPriority backgroundLoadingPriority
		{
			get => global::UnityEngine.Application.backgroundLoadingPriority;
			set => value = global::UnityEngine.Application.backgroundLoadingPriority;
		}

		public string consoleLogPath => global::UnityEngine.Application.consoleLogPath;

		public int targetFrameRate
		{
			get => global::UnityEngine.Application.targetFrameRate;
			set => value = global::UnityEngine.Application.targetFrameRate;
		}

		public string cloudProjectId => global::UnityEngine.Application.cloudProjectId;
		public string companyName => global::UnityEngine.Application.companyName;
		public string productName => global::UnityEngine.Application.productName;

		public bool runInBackground
		{
			get => global::UnityEngine.Application.runInBackground;
			set => value = global::UnityEngine.Application.runInBackground;
		}

		public bool isEditor => global::UnityEngine.Application.isEditor;

		public event global::UnityEngine.Events.UnityAction onBeforeRender
		{
			add => global::UnityEngine.Application.onBeforeRender += value;
			remove => global::UnityEngine.Application.onBeforeRender -= value;
		}

		public event Action quitting
		{
			add => global::UnityEngine.Application.quitting += value;
			remove => global::UnityEngine.Application.quitting -= value;
		}

		public event Func<bool> wantsToQuit
		{
			add => global::UnityEngine.Application.wantsToQuit += value;
			remove => global::UnityEngine.Application.wantsToQuit -= value;
		}

		public event global::UnityEngine.Application.LowMemoryCallback lowMemory
		{
			add => global::UnityEngine.Application.lowMemory += value;
			remove => global::UnityEngine.Application.lowMemory -= value;
		}

		public event global::UnityEngine.Application.LogCallback logMessageReceived
		{
			add => global::UnityEngine.Application.logMessageReceived += value;
			remove => global::UnityEngine.Application.logMessageReceived -= value;
		}

		public event Action<string> deepLinkActivated
		{
			add => global::UnityEngine.Application.deepLinkActivated += value;
			remove => global::UnityEngine.Application.deepLinkActivated -= value;
		}

		public event global::UnityEngine.Application.LogCallback logMessageReceivedThreaded
		{
			add => global::UnityEngine.Application.logMessageReceivedThreaded += value;
			remove => global::UnityEngine.Application.logMessageReceivedThreaded -= value;
		}

		public event Action<bool> focusChanged
		{
			add => global::UnityEngine.Application.focusChanged += value;
			remove => global::UnityEngine.Application.focusChanged -= value;
		}

		public bool CanStreamedLevelBeLoaded(int levelIndex) =>
			global::UnityEngine.Application.CanStreamedLevelBeLoaded(levelIndex);

		public bool CanStreamedLevelBeLoaded(string levelName) =>
			global::UnityEngine.Application.CanStreamedLevelBeLoaded(levelName);


		public string[] GetBuildTags() => global::UnityEngine.Application.GetBuildTags();

		public global::UnityEngine.StackTraceLogType GetStackTraceLogType(global::UnityEngine.LogType logType) =>
			global::UnityEngine.Application.GetStackTraceLogType(logType);

		public bool HasProLicense() => global::UnityEngine.Application.HasProLicense();

		public bool HasUserAuthorization(global::UnityEngine.UserAuthorization mode) =>
			global::UnityEngine.Application.HasUserAuthorization(mode);

		public bool IsPlaying(global::UnityEngine.Object obj) => global::UnityEngine.Application.IsPlaying(obj);

		public void OpenURL(string url) => global::UnityEngine.Application.OpenURL(url);

		public void Quit(int exitCode) => global::UnityEngine.Application.Quit(exitCode);

		public void Quit() => global::UnityEngine.Application.Quit();

		public bool RequestAdvertisingIdentifierAsync(
			global::UnityEngine.Application.AdvertisingIdentifierCallback delegateMethod) =>
			global::UnityEngine.Application.RequestAdvertisingIdentifierAsync(delegateMethod);

		public global::UnityEngine.AsyncOperation
			RequestUserAuthorization(global::UnityEngine.UserAuthorization mode) =>
			global::UnityEngine.Application.RequestUserAuthorization(mode);

		public void SetBuildTags(string[] buildTags) => global::UnityEngine.Application.SetBuildTags(buildTags);

		public void SetStackTraceLogType(global::UnityEngine.LogType logType,
			global::UnityEngine.StackTraceLogType stackTraceType) =>
			global::UnityEngine.Application.SetStackTraceLogType(logType, stackTraceType);

		public void Unload() => global::UnityEngine.Application.Unload();
	}
}
