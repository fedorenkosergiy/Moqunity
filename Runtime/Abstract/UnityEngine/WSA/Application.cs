#if UNITY_WSA
using UnityEngine.WSA;

namespace Moqunity.Abstract.UnityEngine.WSA
{
	/// <summary>
	/// Provides essential methods related to Window Store application.
	/// </summary>
	public interface Application : StaticWrapper
	{
		/// <summary>
		///   <para>Arguments passed to application.</para>
		/// </summary>
		string arguments { get; }

		/// <summary>
		///   <para>Advertising ID.</para>
		/// </summary>
		string advertisingIdentifier{get;}

		event WindowSizeChanged windowSizeChanged;

		event WindowActivated windowActivated;

		/// <summary>
		///   <para>Executes callback item on application thread.</para>
		/// </summary>
		/// <param name="item">Item to execute.</param>
		/// <param name="waitUntilDone">Wait until item is executed.</param>
		void InvokeOnAppThread(AppCallbackItem item, bool waitUntilDone);

		/// <summary>
		///   <para>Executes callback item on UI thread.</para>
		/// </summary>
		/// <param name="item">Item to execute.</param>
		/// <param name="waitUntilDone">Wait until item is executed.</param>
		void InvokeOnUIThread(AppCallbackItem item, bool waitUntilDone);

		/// <summary>
		///   <para>Returns true if you're running on application thread.</para>
		/// </summary>
		bool RunningOnAppThread();

		/// <summary>
		///   <para>Returns true if you're running on UI thread.</para>
		/// </summary>
		bool RunningOnUIThread();

	}
}
#endif