namespace Moqunity.UnityEngine
{
	public class DefaultTime : Abstract.UnityEngine.Time
	{
		public float time => global::UnityEngine.Time.time;

		public double timeAsDouble => global::UnityEngine.Time.timeAsDouble;

		public float timeSinceLevelLoad => global::UnityEngine.Time.timeSinceLevelLoad;

		public double timeSinceLevelLoadAsDouble => global::UnityEngine.Time.timeSinceLevelLoadAsDouble;

		public float deltaTime => global::UnityEngine.Time.deltaTime;

		public float fixedTime => global::UnityEngine.Time.fixedTime;

		public double fixedTimeAsDouble => global::UnityEngine.Time.fixedTimeAsDouble;

		public float unscaledTime => global::UnityEngine.Time.unscaledTime;

		public double unscaledTimeAsDouble => global::UnityEngine.Time.unscaledTimeAsDouble;

		public float fixedUnscaledTime => global::UnityEngine.Time.fixedUnscaledTime;

		public double fixedUnscaledTimeAsDouble => global::UnityEngine.Time.fixedUnscaledTimeAsDouble;

		public float unscaledDeltaTime => global::UnityEngine.Time.unscaledDeltaTime;

		public float fixedUnscaledDeltaTime => global::UnityEngine.Time.fixedUnscaledDeltaTime;

		public float fixedDeltaTime
		{
			get => global::UnityEngine.Time.fixedDeltaTime;
			set => global::UnityEngine.Time.fixedDeltaTime = value;
		}

		public float maximumDeltaTime
		{
			get => global::UnityEngine.Time.maximumDeltaTime;
			set => global::UnityEngine.Time.maximumDeltaTime = value;
		}

		public float smoothDeltaTime => global::UnityEngine.Time.smoothDeltaTime;

		public float maximumParticleDeltaTime
		{
			get => global::UnityEngine.Time.maximumParticleDeltaTime;
			set => global::UnityEngine.Time.maximumParticleDeltaTime = value;
		}

		public float timeScale
		{
			get => global::UnityEngine.Time.timeScale;
			set => global::UnityEngine.Time.timeScale = value;
		}

		public int frameCount => global::UnityEngine.Time.frameCount;

		public int renderedFrameCount => global::UnityEngine.Time.renderedFrameCount;

		public float realtimeSinceStartup => global::UnityEngine.Time.realtimeSinceStartup;

		public double realtimeSinceStartupAsDouble => global::UnityEngine.Time.realtimeSinceStartupAsDouble;

		public float captureDeltaTime
		{
			get => global::UnityEngine.Time.captureDeltaTime;
			set => global::UnityEngine.Time.captureDeltaTime = value;
		}
		public int captureFramerate
		{
			get => global::UnityEngine.Time.captureFramerate;
			set => global::UnityEngine.Time.captureFramerate = value;
		}

		public bool inFixedTimeStep => global::UnityEngine.Time.inFixedTimeStep;
	}
}
