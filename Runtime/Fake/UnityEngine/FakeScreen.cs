using System;
using UnityEngine;
using UnityEngine.Internal;

namespace Moqunity.Fake.UnityEngine
{
	public class FakeScreen : global::Moqunity.Abstract.UnityEngine.Screen
	{
		public virtual int width => throw new NotImplementedException();

		public virtual int height => throw new NotImplementedException();

		public virtual float dpi => throw new NotImplementedException();

		public virtual Resolution currentResolution => throw new NotImplementedException();

		public virtual Resolution[] resolutions => throw new NotImplementedException();

		public virtual bool fullScreen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual FullScreenMode fullScreenMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual Rect safeArea => throw new NotImplementedException();

		public virtual Rect[] cutouts => throw new NotImplementedException();

		public virtual bool autorotateToPortrait { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual bool autorotateToPortraitUpsideDown { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual bool autorotateToLandscapeLeft { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual bool autorotateToLandscapeRight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual ScreenOrientation orientation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual int sleepTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual float brightness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual void SetResolution(int width, int height, FullScreenMode fullscreenMode, [DefaultValue("0")] int preferredRefreshRate)
		{
			throw new NotImplementedException();
		}

		public virtual void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			throw new NotImplementedException();
		}

		public virtual void SetResolution(int width, int height, bool fullscreen, [DefaultValue("0")] int preferredRefreshRate)
		{
			throw new NotImplementedException();
		}

		public virtual void SetResolution(int width, int height, bool fullscreen)
		{
			throw new NotImplementedException();
		}
	}
}