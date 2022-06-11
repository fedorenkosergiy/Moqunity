using UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeRandom : global::Moqunity.Abstract.UnityEngine.Random
	{
		public virtual Random.State state { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual float value => throw new NotImplementedException();

		public virtual Vector3 insideUnitSphere => throw new NotImplementedException();

		public virtual Vector2 insideUnitCircle => throw new NotImplementedException();

		public virtual Vector3 onUnitSphere => throw new NotImplementedException();

		public virtual Quaternion rotation => throw new NotImplementedException();

		public virtual Quaternion rotationUniform => throw new NotImplementedException();

		public virtual Color ColorHSV() => throw new NotImplementedException();

		public virtual Color ColorHSV(float hueMin, float hueMax) => throw new NotImplementedException();

		public virtual Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax) => throw new NotImplementedException();

		public virtual Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax) => throw new NotImplementedException();

		public virtual Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) => throw new NotImplementedException();

		public virtual void InitState(int seed) => throw new NotImplementedException();

		public virtual float Range(float minInclusive, float maxInclusive) => throw new NotImplementedException();

		public virtual int Range(int minInclusive, int maxExclusive) => throw new NotImplementedException();

	}
}
