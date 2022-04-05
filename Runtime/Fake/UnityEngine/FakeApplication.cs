using System;
using UnityEngine;
using UnityEngine.Events;

namespace Moqunity.Fake.UnityEngine
{
	public class FakeApplication : global::Moqunity.Abstract.UnityEngine.Application
	{
		public virtual string version => throw new NotImplementedException();

		public virtual string unityVersion => throw new NotImplementedException();

		public virtual string absoluteURL => throw new NotImplementedException();

		public virtual string temporaryCachePath => throw new NotImplementedException();

		public virtual string persistentDataPath => throw new NotImplementedException();

		public virtual string streamingAssetsPath => throw new NotImplementedException();

		public virtual string installerName => throw new NotImplementedException();

		public virtual string dataPath => throw new NotImplementedException();

		public virtual string buildGUID => throw new NotImplementedException();

		public virtual bool isFocused => throw new NotImplementedException();

		public virtual bool isPlaying => throw new NotImplementedException();

		public virtual bool isBatchMode => throw new NotImplementedException();

		public virtual string identifier => throw new NotImplementedException();

		public virtual ApplicationInstallMode installMode => throw new NotImplementedException();

		public virtual ApplicationSandboxType sandboxType => throw new NotImplementedException();

		public virtual NetworkReachability internetReachability => throw new NotImplementedException();

		public virtual SystemLanguage systemLanguage => throw new NotImplementedException();

		public virtual bool isConsolePlatform => throw new NotImplementedException();

		public virtual bool isMobilePlatform => throw new NotImplementedException();

		public virtual RuntimePlatform platform => throw new NotImplementedException();

		public virtual bool genuineCheckAvailable => throw new NotImplementedException();

		public virtual bool genuine => throw new NotImplementedException();

		public virtual ThreadPriority backgroundLoadingPriority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual string consoleLogPath => throw new NotImplementedException();

		public virtual int targetFrameRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual string cloudProjectId => throw new NotImplementedException();

		public virtual string companyName => throw new NotImplementedException();

		public virtual string productName => throw new NotImplementedException();

		public virtual bool runInBackground { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual bool isEditor => throw new NotImplementedException();

		public virtual event UnityAction onBeforeRender;
		public virtual event Action quitting;
		public virtual event Func<bool> wantsToQuit;
		public virtual event Application.LowMemoryCallback lowMemory;
		public virtual event Application.LogCallback logMessageReceived;
		public virtual event Action<string> deepLinkActivated;
		public virtual event Application.LogCallback logMessageReceivedThreaded;
		public virtual event Action<bool> focusChanged;

		public virtual void InvokeOnBeforeRender() => onBeforeRender?.Invoke();

		public virtual void InvokeQuitting() => quitting?.Invoke();

		public virtual bool? InvokeWantsToQuit() => wantsToQuit?.Invoke();

		public virtual void InvokeLowMemory() => lowMemory?.Invoke();

		public virtual void InvokeLogMessageReceived(string condition, string stackTrace, LogType type) => logMessageReceived?.Invoke(condition, stackTrace, type);

		public virtual void InvokeDeepLinkActivated(string value) => deepLinkActivated?.Invoke(value);

		public virtual void InvokeLogMessageReceivedThreaded(string condition, string stackTrace, LogType type) => logMessageReceivedThreaded?.Invoke(condition, stackTrace, type);

		public virtual void InvokeFocusChanged(bool value) => focusChanged?.Invoke(value);

		public virtual bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			throw new NotImplementedException();
		}

		public virtual bool CanStreamedLevelBeLoaded(string levelName)
		{
			throw new NotImplementedException();
		}

		public virtual string[] GetBuildTags()
		{
			throw new NotImplementedException();
		}

		public virtual StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			throw new NotImplementedException();
		}

		public virtual bool HasProLicense()
		{
			throw new NotImplementedException();
		}

		public virtual bool HasUserAuthorization(UserAuthorization mode)
		{
			throw new NotImplementedException();
		}

		public virtual bool IsPlaying(global::UnityEngine.Object obj)
		{
			throw new NotImplementedException();
		}

		public virtual void OpenURL(string url)
		{
			throw new NotImplementedException();
		}

		public virtual void Quit(int exitCode)
		{
			throw new NotImplementedException();
		}

		public virtual void Quit()
		{
			throw new NotImplementedException();
		}

		public virtual bool RequestAdvertisingIdentifierAsync(Application.AdvertisingIdentifierCallback delegateMethod)
		{
			throw new NotImplementedException();
		}

		public virtual AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			throw new NotImplementedException();
		}

		public virtual void SetBuildTags(string[] buildTags)
		{
			throw new NotImplementedException();
		}

		public virtual void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			throw new NotImplementedException();
		}

		public virtual void Unload()
		{
			throw new NotImplementedException();
		}
	}
}