using System;

namespace Moqunity.Fake.UnityEngine
{
	public class FakeTime : global::Moqunity.Abstract.UnityEngine.Time
	{
		public virtual float time => throw new NotImplementedException();

		public virtual double timeAsDouble => throw new NotImplementedException();

		public virtual float timeSinceLevelLoad => throw new NotImplementedException();

		public virtual double timeSinceLevelLoadAsDouble => throw new NotImplementedException();

		public virtual float deltaTime => throw new NotImplementedException();

		public virtual float fixedTime => throw new NotImplementedException();

		public virtual double fixedTimeAsDouble => throw new NotImplementedException();

		public virtual float unscaledTime => throw new NotImplementedException();

		public virtual double unscaledTimeAsDouble => throw new NotImplementedException();

		public virtual float fixedUnscaledTime => throw new NotImplementedException();

		public virtual double fixedUnscaledTimeAsDouble => throw new NotImplementedException();

		public virtual float unscaledDeltaTime => throw new NotImplementedException();

		public virtual float fixedUnscaledDeltaTime => throw new NotImplementedException();

		public virtual float fixedDeltaTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual float maximumDeltaTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual float smoothDeltaTime => throw new NotImplementedException();

		public virtual float maximumParticleDeltaTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual float timeScale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual int frameCount => throw new NotImplementedException();

		public virtual int renderedFrameCount => throw new NotImplementedException();

		public virtual float realtimeSinceStartup => throw new NotImplementedException();

		public virtual double realtimeSinceStartupAsDouble => throw new NotImplementedException();

		public virtual float captureDeltaTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual int captureFramerate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual bool inFixedTimeStep => throw new NotImplementedException();
	}
}
