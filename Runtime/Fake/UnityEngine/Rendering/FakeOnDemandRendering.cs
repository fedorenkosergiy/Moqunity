using System;

namespace Moqunity.Fake.UnityEngine.Rendering
{
	public class FakeOnDemandRendering : global::Moqunity.Abstract.UnityEngine.Rendering.OnDemandRendering
	{
		public virtual bool willCurrentFrameRender => throw new NotImplementedException();

		public virtual int renderFrameInterval
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}

		public virtual int effectiveRenderFrameRate => throw new NotImplementedException();
	}
}
