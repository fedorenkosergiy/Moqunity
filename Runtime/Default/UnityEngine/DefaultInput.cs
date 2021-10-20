using UnityEngine;
using Input = Moqunity.Abstract.UnityEngine.Input;

namespace Moqunity.UnityEngine
{
	public partial class DefaultInput : Input
	{
		public float GetAxis(string axisName) => global::UnityEngine.Input.GetAxis(axisName);

		public float GetAxisRaw(string axisName) => global::UnityEngine.Input.GetAxisRaw(axisName);

		public bool GetButton(string buttonName) => global::UnityEngine.Input.GetButton(buttonName);

		public bool GetButtonDown(string buttonName) => global::UnityEngine.Input.GetButtonDown(buttonName);

		public bool GetButtonUp(string buttonName) => global::UnityEngine.Input.GetButtonUp(buttonName);

		public bool GetMouseButton(int button) => global::UnityEngine.Input.GetMouseButton(button);

		public bool GetMouseButtonDown(int button) => global::UnityEngine.Input.GetMouseButtonDown(button);

		public bool GetMouseButtonUp(int button) => global::UnityEngine.Input.GetMouseButtonUp(button);

		public void ResetInputAxes() => global::UnityEngine.Input.ResetInputAxes();

		public string[] GetJoystickNames() => global::UnityEngine.Input.GetJoystickNames();

		public Touch GetTouch(int index) => global::UnityEngine.Input.GetTouch(index);

		public AccelerationEvent GetAccelerationEvent(int index) => global::UnityEngine.Input.GetAccelerationEvent(index);

		public bool GetKey(KeyCode key) => global::UnityEngine.Input.GetKey(key);

		public bool GetKey(string name) => global::UnityEngine.Input.GetKey(name);

		public bool GetKeyUp(KeyCode key) => global::UnityEngine.Input.GetKeyUp(key);

		public bool GetKeyUp(string name) => global::UnityEngine.Input.GetKeyUp(name);

		public bool GetKeyDown(KeyCode key) => global::UnityEngine.Input.GetKeyDown(key);

		public bool GetKeyDown(string name) => global::UnityEngine.Input.GetKeyDown(name);

		public bool simulateMouseWithTouches
		{
			get => global::UnityEngine.Input.simulateMouseWithTouches;
			set => global::UnityEngine.Input.simulateMouseWithTouches = value;
		}
		public bool anyKey => global::UnityEngine.Input.anyKey;
		public bool anyKeyDown => global::UnityEngine.Input.anyKeyDown;
		public string inputString => global::UnityEngine.Input.inputString;
		public Vector3 mousePosition => global::UnityEngine.Input.mousePosition;
		public Vector2 mouseScrollDelta => global::UnityEngine.Input.mouseScrollDelta;

		public IMECompositionMode imeCompositionMode
		{
			get => global::UnityEngine.Input.imeCompositionMode;
			set => global::UnityEngine.Input.imeCompositionMode = value;
		}
		public string compositionString => global::UnityEngine.Input.compositionString;
		public bool imeIsSelected => global::UnityEngine.Input.imeIsSelected;

		public Vector2 compositionCursorPos
		{
			get => global::UnityEngine.Input.compositionCursorPos;
			set => global::UnityEngine.Input.compositionCursorPos = value;
		}
		public bool mousePresent => global::UnityEngine.Input.mousePresent;
		public int touchCount => global::UnityEngine.Input.touchCount;
		public bool touchPressureSupported => global::UnityEngine.Input.touchPressureSupported;
		public bool stylusTouchSupported => global::UnityEngine.Input.stylusTouchSupported;
		public bool touchSupported => global::UnityEngine.Input.touchSupported;
		public bool multiTouchEnabled
		{
			get => global::UnityEngine.Input.multiTouchEnabled;
			set => global::UnityEngine.Input.multiTouchEnabled = value;
		}
		public DeviceOrientation deviceOrientation => global::UnityEngine.Input.deviceOrientation;
		public Vector3 acceleration => global::UnityEngine.Input.acceleration;

		public bool compensateSensors
		{
			get => global::UnityEngine.Input.compensateSensors;
			set => global::UnityEngine.Input.compensateSensors = value;
		}
		public int accelerationEventCount => global::UnityEngine.Input.accelerationEventCount;
		public bool backButtonLeavesApp
		{
			get => global::UnityEngine.Input.backButtonLeavesApp;
			set => global::UnityEngine.Input.backButtonLeavesApp = value;
		}
		public LocationService location => global::UnityEngine.Input.location;
		public Compass compass => global::UnityEngine.Input.compass;
		public Gyroscope gyro => global::UnityEngine.Input.gyro;
		public Touch[] touches => global::UnityEngine.Input.touches;
		public AccelerationEvent[] accelerationEvents => global::UnityEngine.Input.accelerationEvents;
	}
}
