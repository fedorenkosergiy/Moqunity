namespace Moqunity.Abstract.UnityEngine.Rendering
{
	/// <summary>
	///   <para>Use the OnDemandRendering class to control and query information about your application's rendering speed independent from all other subsystems (such as physics, input, or animation).
	/// </para>
	/// </summary>
	public interface OnDemandRendering : StaticWrapper
    {
		/// <summary>
		///   <para>True if the current frame will be rendered.</para>
		/// </summary>
		bool willCurrentFrameRender { get; }

		/// <summary>
		///   <para>Get or set the current frame rate interval. To restore rendering back to the value of Application.targetFrameRate or QualitySettings.vSyncCount set this to 0 or 1.</para>
		/// </summary>
		int renderFrameInterval
		{
			get;
			set;
		}

		/// <summary>
		///   <para>The current estimated rate of rendering in frames per second rounded to the nearest integer.</para>
		/// </summary>
		int effectiveRenderFrameRate
		{
			get;
		}
	}

}
