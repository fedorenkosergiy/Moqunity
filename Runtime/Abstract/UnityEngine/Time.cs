namespace Moqunity.Abstract.UnityEngine
{
	/// <summary>
	///   <para>Provides an interface to get time information from Unity.</para>
	/// </summary>
	public interface Time
	{
		/// <summary>
		///   <para>The time at the beginning of this frame (Read Only).</para>
		/// </summary>
		public float time {get;}

		/// <summary>
		///   <para>The double precision time at the beginning of this frame (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		public double timeAsDouble { get; }

		/// <summary>
		///   <para>The time since this frame started (Read Only). This is the time in seconds since the last non-additive scene has finished loading.</para>
		/// </summary>
		public float timeSinceLevelLoad { get; }

		/// <summary>
		///   <para>The double precision time since this frame started (Read Only). This is the time in seconds since the last non-additive scene has finished loading.</para>
		/// </summary>
		public double timeSinceLevelLoadAsDouble { get; }

		/// <summary>
		///   <para>The interval in seconds from the last frame to the current one (Read Only).</para>
		/// </summary>
		public  float deltaTime { get; }

		/// <summary>
		///   <para>The time since the last MonoBehaviour.FixedUpdate started (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		public  float fixedTime { get; }

		/// <summary>
		///   <para>The double precision time since the last MonoBehaviour.FixedUpdate started (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		public  double fixedTimeAsDouble { get; }

		/// <summary>
		///   <para>The timeScale-independent time for this frame (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		public  float unscaledTime { get; }

		/// <summary>
		///   <para>The double precision timeScale-independent time for this frame (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		public  double unscaledTimeAsDouble { get; }

		/// <summary>
		///   <para>The timeScale-independent time at the beginning of the last MonoBehaviour.FixedUpdate phase (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		public  float fixedUnscaledTime { get; }

		/// <summary>
		///   <para>The double precision timeScale-independent time at the beginning of the last MonoBehaviour.FixedUpdate (Read Only). This is the time in seconds since the start of the game.</para>
		/// </summary>
		public  double fixedUnscaledTimeAsDouble { get; }

		/// <summary>
		///   <para>The timeScale-independent interval in seconds from the last frame to the current one (Read Only).</para>
		/// </summary>
		public  float unscaledDeltaTime { get; }

		/// <summary>
		///   <para>The timeScale-independent interval in seconds from the last MonoBehaviour.FixedUpdate phase to the current one (Read Only).</para>
		/// </summary>
		public  float fixedUnscaledDeltaTime { get; }

		/// <summary>
		///   <para>The interval in seconds at which physics and other fixed frame rate updates (like MonoBehaviour's MonoBehaviour.FixedUpdate) are performed.</para>
		/// </summary>
		public  float fixedDeltaTime { get; set; }

		/// <summary>
		///   <para>The maximum value of Time.deltaTime in any given frame. This is a time in seconds that limits the increase of Time.time between two frames.</para>
		/// </summary>
		public  float maximumDeltaTime { get; set; }

		/// <summary>
		///   <para>A smoothed out Time.deltaTime (Read Only).</para>
		/// </summary>
		public  float smoothDeltaTime { get; }

		/// <summary>
		///   <para>The maximum time a frame can spend on particle updates. If the frame takes longer than this, then updates are split into multiple smaller updates.</para>
		/// </summary>
		public  float maximumParticleDeltaTime { get; set; }

		/// <summary>
		///   <para>The scale at which time passes.</para>
		/// </summary>
		public  float timeScale { get; set; }

		/// <summary>
		///   <para>The total number of frames since the start of the game (Read Only).</para>
		/// </summary>
		public  int frameCount { get; }


		public  int renderedFrameCount { get; }

		/// <summary>
		///   <para>The real time in seconds since the game started (Read Only).</para>
		/// </summary>
		public  float realtimeSinceStartup { get; }

		/// <summary>
		///   <para>The real time in seconds since the game started (Read Only). Double precision version of Time.realtimeSinceStartup. </para>
		/// </summary>
		public  double realtimeSinceStartupAsDouble { get; }

		/// <summary>
		///   <para>Slows your application’s playback time to allow Unity to save screenshots in between frames.</para>
		/// </summary>
		public  float captureDeltaTime { get; set; }

		/// <summary>
		///   <para>The reciprocal of Time.captureDeltaTime.</para>
		/// </summary>
		public  int captureFramerate {get;set;}

		/// <summary>
		///   <para>Returns true if called inside a fixed time step callback (like MonoBehaviour's MonoBehaviour.FixedUpdate), otherwise returns false.</para>
		/// </summary>
		public  bool inFixedTimeStep { get; }
	}

}