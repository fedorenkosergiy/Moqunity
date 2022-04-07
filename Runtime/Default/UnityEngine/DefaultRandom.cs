using UnityEngine;
namespace Moqunity.UnityEngine
{
	public partial class DefaultRandom : global::Moqunity.Abstract.UnityEngine.Random
	{
		public global::UnityEngine.Random.State state
		{
			get => Random.state;
			set => Random.state = value;
		}

		public float value => Random.value;

		public Vector3 insideUnitSphere => Random.insideUnitSphere;

		public Vector2 insideUnitCircle => Random.insideUnitCircle;

		public Vector3 onUnitSphere => Random.onUnitSphere;

		public Quaternion rotation => Random.rotation;

		public Quaternion rotationUniform => Random.rotationUniform;

		public Color ColorHSV() => Random.ColorHSV();

		public Color ColorHSV(float hueMin, float hueMax) => Random.ColorHSV(hueMin, hueMax);

		public Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax) => Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax);

		public Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax) => Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax);

		public Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) => Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, alphaMin, alphaMax);

		public void InitState(int seed) => Random.InitState(seed);

		public float Range(float minInclusive, float maxInclusive) => Random.Range(minInclusive, maxInclusive);

		public int Range(int minInclusive, int maxExclusive) => Random.Range(minInclusive, maxExclusive);
	}
}
