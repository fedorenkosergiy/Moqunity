using System;
using UnityEngine;
using Debug = Moqunity.Abstract.UnityEngine.Debug;
using Object = UnityEngine.Object;

namespace Moqunity.UnityEngine
{
	public partial class DefaultDebug : Debug
	{
		public ILogger unityLogger => global::UnityEngine.Debug.unityLogger;
		public void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			global::UnityEngine.Debug.DrawLine(start, end, color, duration);
		}

		public void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			global::UnityEngine.Debug.DrawLine(start, end, color);
		}

		public void DrawLine(Vector3 start, Vector3 end)
		{
			global::UnityEngine.Debug.DrawLine(start, end);
		}

		public void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
		{
			global::UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
		}

		public void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			global::UnityEngine.Debug.DrawRay(start, dir, color, duration);
		}

		public void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			global::UnityEngine.Debug.DrawRay(start, dir, color);
		}

		public void DrawRay(Vector3 start, Vector3 dir)
		{
			global::UnityEngine.Debug.DrawRay(start, dir);
		}

		public void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
		{
			global::UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
		}

		public void Break() => global::UnityEngine.Debug.Break();

		public void DebugBreak() => global::UnityEngine.Debug.DebugBreak();

		public unsafe int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			return global::UnityEngine.Debug.ExtractStackTraceNoAlloc(buffer, bufferMax, projectFolder);
		}

		public void Log(object message) => global::UnityEngine.Debug.Log(message);

		public void Log(object message, Object context) => global::UnityEngine.Debug.Log(message, context);

		public void LogFormat(string format, params object[] args)
		{
			global::UnityEngine.Debug.LogFormat(format, args);
		}

		public void LogFormat(Object context, string format, params object[] args)
		{
			global::UnityEngine.Debug.LogFormat(context, format, args);
		}

		public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
		{
			global::UnityEngine.Debug.LogFormat(logType, logOptions, context, format, args);
		}

		public void LogError(object message)
		{
			global::UnityEngine.Debug.LogError(message);
		}

		public void LogError(object message, Object context)
		{
			global::UnityEngine.Debug.LogError(message, context);
		}

		public void LogErrorFormat(string format, params object[] args)
		{
			global::UnityEngine.Debug.LogErrorFormat(format, args);
		}

		public void LogErrorFormat(Object context, string format, params object[] args)
		{
			global::UnityEngine.Debug.LogErrorFormat(context, format, args);
		}

		public void ClearDeveloperConsole() => global::UnityEngine.Debug.ClearDeveloperConsole();

		public bool developerConsoleVisible
		{
			get => global::UnityEngine.Debug.developerConsoleVisible;
			set => global::UnityEngine.Debug.developerConsoleVisible = value;
		}
		public void LogException(Exception exception)
		{
			global::UnityEngine.Debug.LogException(exception);
		}

		public void LogException(Exception exception, Object context)
		{
			global::UnityEngine.Debug.LogException(exception, context);
		}

		public void LogWarning(object message)
		{
			global::UnityEngine.Debug.LogWarning(message);
		}

		public void LogWarning(object message, Object context)
		{
			global::UnityEngine.Debug.LogWarning(message, context);
		}

		public void LogWarningFormat(string format, params object[] args)
		{
			global::UnityEngine.Debug.LogWarningFormat(format, args);
		}

		public void LogWarningFormat(Object context, string format, params object[] args)
		{
			global::UnityEngine.Debug.LogWarningFormat(context, format, args);
		}

		public void Assert(bool condition)
		{
			global::UnityEngine.Debug.Assert(condition);
		}

		public void Assert(bool condition, Object context)
		{
			global::UnityEngine.Debug.Assert(condition, context);
		}

		public void Assert(bool condition, object message)
		{
			global::UnityEngine.Debug.Assert(condition, message);
		}

		public void Assert(bool condition, string message)
		{
			global::UnityEngine.Debug.Assert(condition, message);
		}

		public void Assert(bool condition, object message, Object context)
		{
			global::UnityEngine.Debug.Assert(condition, message, context);
		}

		public void Assert(bool condition, string message, Object context)
		{
			global::UnityEngine.Debug.Assert(condition,message, context);
		}

		public void AssertFormat(bool condition, string format, params object[] args)
		{
			global::UnityEngine.Debug.AssertFormat(condition, format, args);
		}

		public void AssertFormat(bool condition, Object context, string format, params object[] args)
		{
			global::UnityEngine.Debug.AssertFormat(condition, context, format, args);
		}

		public void LogAssertion(object message)
		{
			global::UnityEngine.Debug.LogAssertion(message);
		}

		public void LogAssertion(object message, Object context)
		{
			global::UnityEngine.Debug.LogAssertion(message, context);
		}

		public void LogAssertionFormat(string format, params object[] args)
		{
			global::UnityEngine.Debug.LogAssertionFormat(format, args);
		}

		public void LogAssertionFormat(Object context, string format, params object[] args)
		{
			global::UnityEngine.Debug.LogAssertionFormat(context, format, args);
		}

		public bool isDebugBuild => global::UnityEngine.Debug.isDebugBuild;
	}
}
