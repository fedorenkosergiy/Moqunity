using UnityEngine;
using UnityEngine.Internal;

namespace Moqunity.Abstract.UnityEngine
{
	public interface Screen : StaticWrapper
	{
		/// <summary>
		///   <para>The current width of the screen window in pixels (Read Only).</para>
		/// </summary>
		int width { get; }

		/// <summary>
		///   <para>The current height of the screen window in pixels (Read Only).</para>
		/// </summary>
		int height { get; }

		/// <summary>
		///   <para>The current DPI of the screen / device (Read Only).</para>
		/// </summary>
		float dpi { get; }

		/// <summary>
		///   <para>The current screen resolution (Read Only).</para>
		/// </summary>
		Resolution currentResolution { get; }

		/// <summary>
		///   <para>All full-screen resolutions supported by the monitor (Read Only).</para>
		/// </summary>
		Resolution[] resolutions { get; }

		/// <summary>
		///   <para>Switches the screen resolution.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="fullscreen"></param>
		/// <param name="preferredRefreshRate"></param>
		/// <param name="fullscreenMode"></param>
		void SetResolution(
			int width,
			int height,
			FullScreenMode fullscreenMode,
			[DefaultValue("0")] int preferredRefreshRate);

		void SetResolution(int width, int height, FullScreenMode fullscreenMode);

		/// <summary>
		///   <para>Switches the screen resolution.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="fullscreen"></param>
		/// <param name="preferredRefreshRate"></param>
		/// <param name="fullscreenMode"></param>
		void SetResolution(
			int width,
			int height,
			bool fullscreen,
			[DefaultValue("0")] int preferredRefreshRate);

		/// <summary>
		///   <para>Switches the screen resolution.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="fullscreen"></param>
		/// <param name="preferredRefreshRate"></param>
		/// <param name="fullscreenMode"></param>
		void SetResolution(int width, int height, bool fullscreen);

		/// <summary>
		///   <para>Is the game running full-screen?</para>
		/// </summary>
		bool fullScreen { get; set; }

		/// <summary>
		///   <para>Set this property to one of the values in FullScreenMode to change the display mode of your application.</para>
		/// </summary>
		FullScreenMode fullScreenMode { get; set; }

		/// <summary>
		///   <para>Returns the safe area of the screen in pixels (Read Only).</para>
		/// </summary>
		Rect safeArea { get; }

		/// <summary>
		///   <para>Returns a list of screen areas that are not functional for displaying content (Read Only).</para>
		/// </summary>
		Rect[] cutouts { get; }

		/// <summary>
		///   <para>Allow auto-rotation to portrait?</para>
		/// </summary>
		bool autorotateToPortrait { get; set; }

		/// <summary>
		///   <para>Allow auto-rotation to portrait, upside down?</para>
		/// </summary>
		bool autorotateToPortraitUpsideDown { get; set; }

		/// <summary>
		///   <para>Allow auto-rotation to landscape left?</para>
		/// </summary>
		bool autorotateToLandscapeLeft { get; set; }

		/// <summary>
		///   <para>Allow auto-rotation to landscape right?</para>
		/// </summary>
		bool autorotateToLandscapeRight { get; set; }

		/// <summary>
		///   <para>Specifies logical orientation of the screen.</para>
		/// </summary>
		ScreenOrientation orientation { get; set; }

		/// <summary>
		///   <para>A power saving setting, allowing the screen to dim some time after the last active user interaction.</para>
		/// </summary>
		int sleepTimeout { get; set; }

		/// <summary>
		///   <para>The current brightness of the screen.</para>
		/// </summary>
		float brightness { get; set; }
	}
}
