using UnityEngine;

namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeRandom : global::Moqunity.Abstract.UnityEngine.Random
	{
		public virtual Random.State state { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public virtual float value => throw new System.NotImplementedException();

		public virtual Vector3 insideUnitSphere => throw new System.NotImplementedException();

		public virtual Vector2 insideUnitCircle => throw new System.NotImplementedException();

		public virtual Vector3 onUnitSphere => throw new System.NotImplementedException();

		public virtual Quaternion rotation => throw new System.NotImplementedException();

		public virtual Quaternion rotationUniform => throw new System.NotImplementedException();

		public virtual Color ColorHSV() => throw new System.NotImplementedException();

		public virtual Color ColorHSV(float hueMin, float hueMax) => throw new System.NotImplementedException();

		public virtual Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax) => throw new System.NotImplementedException();

		public virtual Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax) => throw new System.NotImplementedException();

		public virtual Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) => throw new System.NotImplementedException();

		public virtual void InitState(int seed) => throw new System.NotImplementedException();

		public virtual float Range(float minInclusive, float maxInclusive) => throw new System.NotImplementedException();

		public virtual int Range(int minInclusive, int maxExclusive) => throw new System.NotImplementedException();

	}
}