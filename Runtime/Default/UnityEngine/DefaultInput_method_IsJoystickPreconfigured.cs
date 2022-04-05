
namespace Moqunity.UnityEngine
{
	public partial class DefaultInput
	{
#if UNITY_LINUX
		/// <summary>
		///   <para>Determine whether a particular joystick model has been preconfigured by Unity. (Linux-only).</para>
		/// </summary>
		/// <param name="joystickName">The name of the joystick to check (returned by Input.GetJoystickNames).</param>
		/// <returns>
		///   <para>True if the joystick layout has been preconfigured; false otherwise.</para>
		/// </returns>
		public bool IsJoystickPreconfigured(string joystickName) => global::UnityEngine.Input.IsJoystickPreconfigured(joystickName);
#endif
	}
}
