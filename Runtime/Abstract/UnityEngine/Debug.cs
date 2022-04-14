using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Moqunity.Abstract.UnityEngine
{
	/// <summary>
	///   <para>Class containing methods to ease debugging while developing a game.</para>
	/// </summary>
	public partial interface Debug
	{
		/// <summary>
		///   <para>Get default debug logger.</para>
		/// </summary>
		ILogger unityLogger { get; }

		///   <para>Draws a line between specified start and end points.</para>
		/// </summary>
		/// <param name="start">Point in world space where the line should start.</param>
		/// <param name="end">Point in world space where the line should end.</param>
		/// <param name="color">Color of the line.</param>
		/// <param name="duration">How long the line should be visible for.</param>
		void DrawLine(Vector3 start, Vector3 end, Color color, float duration);

		/// <summary>
		///   <para>Draws a line between specified start and end points.</para>
		/// </summary>
		/// <param name="start">Point in world space where the line should start.</param>
		/// <param name="end">Point in world space where the line should end.</param>
		/// <param name="color">Color of the line.</param>
		void DrawLine(Vector3 start, Vector3 end, Color color);

		/// <summary>
		///   <para>Draws a line between specified start and end points.</para>
		/// </summary>
		/// <param name="start">Point in world space where the line should start.</param>
		/// <param name="end">Point in world space where the line should end.</param>
		void DrawLine(Vector3 start, Vector3 end);

		/// <summary>
		///   <para>Draws a line between specified start and end points.</para>
		/// </summary>
		/// <param name="start">Point in world space where the line should start.</param>
		/// <param name="end">Point in world space where the line should end.</param>
		/// <param name="color">Color of the line.</param>
		/// <param name="duration">How long the line should be visible for.</param>
		/// <param name="depthTest">Should the line be obscured by objects closer to the camera?</param>
		void DrawLine(
			Vector3 start,
			Vector3 end,
			Color color,
			float duration,
			bool depthTest);

		/// <summary>
		///   <para>Draws a line from start to start + dir in world coordinates.</para>
		/// </summary>
		/// <param name="start">Point in world space where the ray should start.</param>
		/// <param name="dir">Direction and length of the ray.</param>
		/// <param name="color">Color of the drawn line.</param>
		/// <param name="duration">How long the line will be visible for (in seconds).</param>
		void DrawRay(Vector3 start, Vector3 dir, Color color, float duration);

		/// <summary>
		///   <para>Draws a line from start to start + dir in world coordinates.</para>
		/// </summary>
		/// <param name="start">Point in world space where the ray should start.</param>
		/// <param name="dir">Direction and length of the ray.</param>
		/// <param name="color">Color of the drawn line.</param>
		void DrawRay(Vector3 start, Vector3 dir, Color color);

		/// <summary>
		///   <para>Draws a line from start to start + dir in world coordinates.</para>
		/// </summary>
		/// <param name="start">Point in world space where the ray should start.</param>
		/// <param name="dir">Direction and length of the ray.</param>
		void DrawRay(Vector3 start, Vector3 dir);

		/// <summary>
		///   <para>Draws a line from start to start + dir in world coordinates.</para>
		/// </summary>
		/// <param name="start">Point in world space where the ray should start.</param>
		/// <param name="dir">Direction and length of the ray.</param>
		/// <param name="color">Color of the drawn line.</param>
		/// <param name="duration">How long the line will be visible for (in seconds).</param>
		/// <param name="depthTest">Should the line be obscured by other objects closer to the camera?</param>
		void DrawRay(
			Vector3 start,
			Vector3 dir,
			Color color,
			float duration,
			bool depthTest);

		/// <summary>
		///   <para>Pauses the editor.</para>
		/// </summary>
		void Break();

		void DebugBreak();

		/// <summary>
		///   <para>Populate an unmanaged buffer with the current managed call stack as a sequence of UTF-8 bytes, without allocating GC memory. Returns the number of bytes written into the buffer.</para>
		/// </summary>
		/// <param name="buffer">Target buffer to receive the callstack text</param>
		/// <param name="bufferMax">Max number of bytes to write</param>
		/// <param name="projectFolder">Project folder path, to clean up path names</param>
		unsafe int ExtractStackTraceNoAlloc(
			byte* buffer,
			int bufferMax,
			string projectFolder);

		/// <summary>
		///   <para>Logs a message to the Unity Console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		void Log(object message);

		/// <summary>
		///   <para>Logs a message to the Unity Console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		void Log(object message, Object context);

		/// <summary>
		///   <para>Logs a formatted message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		void LogFormat(string format, params object[] args);

		/// <summary>
		///   <para>Logs a formatted message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		void LogFormat(Object context, string format, params object[] args);

		/// <summary>
		///   <para>Logs a formatted message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		/// <param name="logType">Type of message e.g. warn or error etc.</param>
		/// <param name="logOptions">Option flags to treat the log message special.</param>
		void LogFormat(
			LogType logType,
			LogOption logOptions,
			Object context,
			string format,
			params object[] args);

		/// <summary>
		///   <para>A variant of Debug.Log that logs an error message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		void LogError(object message);

		/// <summary>
		///   <para>A variant of Debug.Log that logs an error message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		void LogError(object message, Object context);

		/// <summary>
		///   <para>Logs a formatted error message to the Unity console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		void LogErrorFormat(string format, params object[] args);

		/// <summary>
		///   <para>Logs a formatted error message to the Unity console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		void LogErrorFormat(Object context, string format, params object[] args);

		/// <summary>
		///   <para>Clears errors from the developer console.</para>
		/// </summary>
		void ClearDeveloperConsole();

		/// <summary>
		///   <para>Reports whether the development console is visible. The development console cannot be made to appear using:</para>
		/// </summary>
		bool developerConsoleVisible { get; set; }

		/// <summary>
		///   <para>A variant of Debug.Log that logs an error message to the console.</para>
		/// </summary>
		/// <param name="exception">Runtime Exception.</param>
		void LogException(Exception exception);

		/// <summary>
		///   <para>A variant of Debug.Log that logs an error message to the console.</para>
		/// </summary>
		/// <param name="context">Object to which the message applies.</param>
		/// <param name="exception">Runtime Exception.</param>
		void LogException(Exception exception, Object context);

		/// <summary>
		///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		void LogWarning(object message);

		/// <summary>
		///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		void LogWarning(object message, Object context);

		/// <summary>
		///   <para>Logs a formatted warning message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		void LogWarningFormat(string format, params object[] args);

		/// <summary>
		///   <para>Logs a formatted warning message to the Unity Console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		void LogWarningFormat(Object context, string format, params object[] args);

		/// <summary>
		///   <para>Assert a condition and logs an error message to the Unity console on failure.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		void Assert(bool condition);

		/// <summary>
		///   <para>Assert a condition and logs an error message to the Unity console on failure.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		/// <param name="context">Object to which the message applies.</param>
		void Assert(bool condition, Object context);

		/// <summary>
		///   <para>Assert a condition and logs an error message to the Unity console on failure.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		void Assert(bool condition, object message);

		void Assert(bool condition, string message);

		/// <summary>
		///   <para>Assert a condition and logs an error message to the Unity console on failure.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		/// <param name="context">Object to which the message applies.</param>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		void Assert(bool condition, object message, Object context);

		void Assert(bool condition, string message, Object context);

		/// <summary>
		///   <para>Assert a condition and logs a formatted error message to the Unity console on failure.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		void AssertFormat(bool condition, string format, params object[] args);

		/// <summary>
		///   <para>Assert a condition and logs a formatted error message to the Unity console on failure.</para>
		/// </summary>
		/// <param name="condition">Condition you expect to be true.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		void AssertFormat(
			bool condition,
			Object context,
			string format,
			params object[] args);

		/// <summary>
		///   <para>A variant of Debug.Log that logs an assertion message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		void LogAssertion(object message);

		/// <summary>
		///   <para>A variant of Debug.Log that logs an assertion message to the console.</para>
		/// </summary>
		/// <param name="message">String or object to be converted to string representation for display.</param>
		/// <param name="context">Object to which the message applies.</param>
		void LogAssertion(object message, Object context);

		/// <summary>
		///   <para>Logs a formatted assertion message to the Unity console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		void LogAssertionFormat(string format, params object[] args);

		/// <summary>
		///   <para>Logs a formatted assertion message to the Unity console.</para>
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">Format arguments.</param>
		/// <param name="context">Object to which the message applies.</param>
		void LogAssertionFormat(Object context, string format, params object[] args);

		/// <summary>
		///   <para>In the Build Settings dialog there is a check box called "Development Build".</para>
		/// </summary>
		bool isDebugBuild { get; }
	}
}
