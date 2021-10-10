using UnityEngine;
using Screen = Moqunity.Abstract.UnityEngine.Screen;

namespace Moqunity.UnityEngine
{
	public class DefaultScreen : Screen
	{
		public int width => global::UnityEngine.Screen.width;
		public int height => global::UnityEngine.Screen.height;
		public float dpi => global::UnityEngine.Screen.dpi;
		public Resolution currentResolution => global::UnityEngine.Screen.currentResolution;
		public Resolution[] resolutions => global::UnityEngine.Screen.resolutions;

		public void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
		{
			global::UnityEngine.Screen.SetResolution(width, height, fullscreenMode, preferredRefreshRate);
		}

		public void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			global::UnityEngine.Screen.SetResolution(width, height, fullscreenMode);
		}

		public void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
		{
			global::UnityEngine.Screen.SetResolution(width, height, fullScreen, preferredRefreshRate);
		}

		public void SetResolution(int width, int height, bool fullscreen)
		{
			global::UnityEngine.Screen.SetResolution(width, height, fullscreen);
		}

		public bool fullScreen
		{
			get => global::UnityEngine.Screen.fullScreen;
			set => global::UnityEngine.Screen.fullScreen = value;
		}

		public FullScreenMode fullScreenMode
		{
			get => global::UnityEngine.Screen.fullScreenMode;
			set => global::UnityEngine.Screen.fullScreenMode = value;
		}

		public Rect safeArea => global::UnityEngine.Screen.safeArea;
		public Rect[] cutouts => global::UnityEngine.Screen.cutouts;

		public bool autorotateToPortrait
		{
			get => global::UnityEngine.Screen.autorotateToPortrait;
			set => global::UnityEngine.Screen.autorotateToPortrait = value;
		}

		public bool autorotateToPortraitUpsideDown
		{
			get => global::UnityEngine.Screen.autorotateToPortraitUpsideDown;
			set => global::UnityEngine.Screen.autorotateToPortraitUpsideDown = value;
		}

		public bool autorotateToLandscapeLeft
		{
			get => global::UnityEngine.Screen.autorotateToLandscapeLeft;
			set => global::UnityEngine.Screen.autorotateToLandscapeLeft = value;
		}

		public bool autorotateToLandscapeRight
		{
			get => global::UnityEngine.Screen.autorotateToLandscapeRight;
			set => global::UnityEngine.Screen.autorotateToLandscapeRight = value;
		}

		public ScreenOrientation orientation
		{
			get => global::UnityEngine.Screen.orientation;
			set => global::UnityEngine.Screen.orientation = value;
		}

		public int sleepTimeout
		{
			get => global::UnityEngine.Screen.sleepTimeout;
			set => global::UnityEngine.Screen.sleepTimeout = value;
		}

		public float brightness
		{
			get => global::UnityEngine.Screen.brightness;
			set => global::UnityEngine.Screen.brightness = value;
		}
	}
}
