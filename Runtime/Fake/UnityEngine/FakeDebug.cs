using System;
using UnityEngine;
using Debug = Moqunity.Abstract.UnityEngine.Debug;
using Object = UnityEngine.Object;

namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeDebug : Debug
	{
		public virtual ILogger unityLogger => throw new NotImplementedException();
		public virtual void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			throw new NotImplementedException();
		}

		public virtual void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			throw new NotImplementedException();
		}

		public virtual void DrawLine(Vector3 start, Vector3 end)
		{
			throw new NotImplementedException();
		}

		public virtual void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
		{
			throw new NotImplementedException();
		}

		public virtual void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			throw new NotImplementedException();
		}

		public virtual void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			throw new NotImplementedException();
		}

		public virtual void DrawRay(Vector3 start, Vector3 dir)
		{
			throw new NotImplementedException();
		}

		public virtual void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
		{
			throw new NotImplementedException();
		}

		public virtual void Break()
		{
			throw new NotImplementedException();
		}

		public virtual void DebugBreak()
		{
			throw new NotImplementedException();
		}

		public virtual unsafe int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			throw new NotImplementedException();
		}

		public virtual void Log(object message)
		{
			throw new NotImplementedException();
		}

		public virtual void Log(object message, Object context)
		{
			throw new NotImplementedException();
		}

		public virtual void LogFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void LogFormat(Object context, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void LogError(object message)
		{
			throw new NotImplementedException();
		}

		public virtual void LogError(object message, Object context)
		{
			throw new NotImplementedException();
		}

		public virtual void LogErrorFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void LogErrorFormat(Object context, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void ClearDeveloperConsole()
		{
			throw new NotImplementedException();
		}

		public virtual bool developerConsoleVisible
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}
		public virtual void LogException(Exception exception)
		{
			throw new NotImplementedException();
		}

		public virtual void LogException(Exception exception, Object context)
		{
			throw new NotImplementedException();
		}

		public virtual void LogWarning(object message)
		{
			throw new NotImplementedException();
		}

		public virtual void LogWarning(object message, Object context)
		{
			throw new NotImplementedException();
		}

		public virtual void LogWarningFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void LogWarningFormat(Object context, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void Assert(bool condition)
		{
			throw new NotImplementedException();
		}

		public virtual void Assert(bool condition, Object context)
		{
			throw new NotImplementedException();
		}

		public virtual void Assert(bool condition, object message)
		{
			throw new NotImplementedException();
		}

		public virtual void Assert(bool condition, string message)
		{
			throw new NotImplementedException();
		}

		public virtual void Assert(bool condition, object message, Object context)
		{
			throw new NotImplementedException();
		}

		public virtual void Assert(bool condition, string message, Object context)
		{
			throw new NotImplementedException();
		}

		public virtual void AssertFormat(bool condition, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void AssertFormat(bool condition, Object context, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void LogAssertion(object message)
		{
			throw new NotImplementedException();
		}

		public virtual void LogAssertion(object message, Object context)
		{
			throw new NotImplementedException();
		}

		public virtual void LogAssertionFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual void LogAssertionFormat(Object context, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public virtual bool isDebugBuild => throw new NotImplementedException();
	}
}
