namespace Moqunity.Abstract.UnityEngine
{
	public partial interface Random : StaticWrapper
	{
		/// <summary>
		///   <para>Gets or sets the full internal state of the random number generator.</para>
		/// </summary>
		global::UnityEngine.Random.State state { get; set; }

		/// <summary>
		///   <para>Returns a random float within [0.0..1.0] (range is inclusive) (Read Only).</para>
		/// </summary>
		float value { get; }

		/// <summary>
		///   <para>Returns a random point inside or on a sphere with radius 1.0 (Read Only).</para>
		/// </summary>
		global::UnityEngine.Vector3 insideUnitSphere { get; }

		/// <summary>
		///   <para>Returns a random point inside or on a circle with radius 1.0 (Read Only).</para>
		/// </summary>
		global::UnityEngine.Vector2 insideUnitCircle { get; }

		/// <summary>
		///   <para>Returns a random point on the surface of a sphere with radius 1.0 (Read Only).</para>
		/// </summary>
		global::UnityEngine.Vector3 onUnitSphere { get; }

		/// <summary>
		///   <para>Returns a random rotation (Read Only).</para>
		/// </summary>
		global::UnityEngine.Quaternion rotation { get; }

		/// <summary>
		///   <para>Returns a random rotation with uniform distribution (Read Only).</para>
		/// </summary>
		global::UnityEngine.Quaternion rotationUniform { get; }

		/// <summary>
		///   <para>Initializes the random number generator state with a seed.</para>
		/// </summary>
		/// <param name="seed">Seed used to initialize the random number generator.</param>

		void InitState(int seed);

		/// <summary>
		///   <para>Returns a random float within [minInclusive..maxInclusive] (range is inclusive).</para>
		/// </summary>
		/// <param name="minInclusive"></param>
		/// <param name="maxInclusive"></param>
		float Range(float minInclusive, float maxInclusive);

		/// <summary>
		///   <para>Return a random int within [minInclusive..maxExclusive) (Read Only).</para>
		/// </summary>
		/// <param name="minInclusive"></param>
		/// <param name="maxExclusive"></param>
		int Range(int minInclusive, int maxExclusive);

		/// <summary>
		///   <para>Generates a random color from HSV and alpha ranges.</para>
		/// </summary>
		/// <param name="hueMin">Minimum hue [0..1].</param>
		/// <param name="hueMax">Maximum hue [0..1].</param>
		/// <param name="saturationMin">Minimum saturation [0..1].</param>
		/// <param name="saturationMax">Maximum saturation [0..1].</param>
		/// <param name="valueMin">Minimum value [0..1].</param>
		/// <param name="valueMax">Maximum value [0..1].</param>
		/// <param name="alphaMin">Minimum alpha [0..1].</param>
		/// <param name="alphaMax">Maximum alpha [0..1].</param>
		/// <returns>
		///   <para>A random color with HSV and alpha values in the (inclusive) input ranges. Values for each component are derived via linear interpolation of value.</para>
		/// </returns>
		global::UnityEngine.Color ColorHSV();

		/// <summary>
		///   <para>Generates a random color from HSV and alpha ranges.</para>
		/// </summary>
		/// <param name="hueMin">Minimum hue [0..1].</param>
		/// <param name="hueMax">Maximum hue [0..1].</param>
		/// <param name="saturationMin">Minimum saturation [0..1].</param>
		/// <param name="saturationMax">Maximum saturation [0..1].</param>
		/// <param name="valueMin">Minimum value [0..1].</param>
		/// <param name="valueMax">Maximum value [0..1].</param>
		/// <param name="alphaMin">Minimum alpha [0..1].</param>
		/// <param name="alphaMax">Maximum alpha [0..1].</param>
		/// <returns>
		///   <para>A random color with HSV and alpha values in the (inclusive) input ranges. Values for each component are derived via linear interpolation of value.</para>
		/// </returns>
		global::UnityEngine.Color ColorHSV(float hueMin, float hueMax);

		/// <summary>
		///   <para>Generates a random color from HSV and alpha ranges.</para>
		/// </summary>
		/// <param name="hueMin">Minimum hue [0..1].</param>
		/// <param name="hueMax">Maximum hue [0..1].</param>
		/// <param name="saturationMin">Minimum saturation [0..1].</param>
		/// <param name="saturationMax">Maximum saturation [0..1].</param>
		/// <param name="valueMin">Minimum value [0..1].</param>
		/// <param name="valueMax">Maximum value [0..1].</param>
		/// <param name="alphaMin">Minimum alpha [0..1].</param>
		/// <param name="alphaMax">Maximum alpha [0..1].</param>
		/// <returns>
		///   <para>A random color with HSV and alpha values in the (inclusive) input ranges. Values for each component are derived via linear interpolation of value.</para>
		/// </returns>
		global::UnityEngine.Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax);

		/// <summary>
		///   <para>Generates a random color from HSV and alpha ranges.</para>
		/// </summary>
		/// <param name="hueMin">Minimum hue [0..1].</param>
		/// <param name="hueMax">Maximum hue [0..1].</param>
		/// <param name="saturationMin">Minimum saturation [0..1].</param>
		/// <param name="saturationMax">Maximum saturation [0..1].</param>
		/// <param name="valueMin">Minimum value [0..1].</param>
		/// <param name="valueMax">Maximum value [0..1].</param>
		/// <param name="alphaMin">Minimum alpha [0..1].</param>
		/// <param name="alphaMax">Maximum alpha [0..1].</param>
		/// <returns>
		///   <para>A random color with HSV and alpha values in the (inclusive) input ranges. Values for each component are derived via linear interpolation of value.</para>
		/// </returns>
		global::UnityEngine.Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax);

		/// <summary>
		///   <para>Generates a random color from HSV and alpha ranges.</para>
		/// </summary>
		/// <param name="hueMin">Minimum hue [0..1].</param>
		/// <param name="hueMax">Maximum hue [0..1].</param>
		/// <param name="saturationMin">Minimum saturation [0..1].</param>
		/// <param name="saturationMax">Maximum saturation [0..1].</param>
		/// <param name="valueMin">Minimum value [0..1].</param>
		/// <param name="valueMax">Maximum value [0..1].</param>
		/// <param name="alphaMin">Minimum alpha [0..1].</param>
		/// <param name="alphaMax">Maximum alpha [0..1].</param>
		/// <returns>
		///   <para>A random color with HSV and alpha values in the (inclusive) input ranges. Values for each component are derived via linear interpolation of value.</para>
		/// </returns>
		global::UnityEngine.Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax);
	}
}