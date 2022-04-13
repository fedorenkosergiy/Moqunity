namespace Moqunity.UnityEngine.Rendering
{
	public class DefaultOnDemandRendering : global::Moqunity.Abstract.UnityEngine.Rendering.OnDemandRendering
	{
		public bool willCurrentFrameRender => global::UnityEngine.Rendering.OnDemandRendering.willCurrentFrameRender;

		public int renderFrameInterval
		{
			get => global::UnityEngine.Rendering.OnDemandRendering.renderFrameInterval;
			set => global::UnityEngine.Rendering.OnDemandRendering.renderFrameInterval = value;
		}

		public int effectiveRenderFrameRate => global::UnityEngine.Rendering.OnDemandRendering.effectiveRenderFrameRate;
	}
}
