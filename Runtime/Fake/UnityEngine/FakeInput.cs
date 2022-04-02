using System;

namespace Moqunity.Fake.UnityEngine
{
	public class FakeInput : global::Moqunity.Abstract.UnityEngine.Input
	{
		public virtual bool simulateMouseWithTouches { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
			   
		public virtual bool anyKey => throw new NotImplementedException();
			   
		public virtual bool anyKeyDown => throw new NotImplementedException();
			   
		public virtual string inputString => throw new NotImplementedException();
			   
		public virtual global::UnityEngine.Vector3 mousePosition => throw new NotImplementedException();

		public virtual global::UnityEngine.Vector2 mouseScrollDelta => throw new NotImplementedException();

		public virtual global::UnityEngine.IMECompositionMode imeCompositionMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual string compositionString => throw new NotImplementedException();

		public virtual bool imeIsSelected => throw new NotImplementedException();

		public virtual global::UnityEngine.Vector2 compositionCursorPos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual bool mousePresent => throw new NotImplementedException();

		public virtual int touchCount => throw new NotImplementedException();

		public virtual bool touchPressureSupported => throw new NotImplementedException();

		public virtual bool stylusTouchSupported => throw new NotImplementedException();

		public virtual bool touchSupported => throw new NotImplementedException();

		public virtual bool multiTouchEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual global::UnityEngine.DeviceOrientation deviceOrientation => throw new NotImplementedException();

		public virtual global::UnityEngine.Vector3 acceleration => throw new NotImplementedException();

		public virtual bool compensateSensors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual int accelerationEventCount => throw new NotImplementedException();

		public virtual bool backButtonLeavesApp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public virtual global::UnityEngine.LocationService location => throw new NotImplementedException();

		public virtual global::UnityEngine.Compass compass => throw new NotImplementedException();

		public virtual global::UnityEngine.Gyroscope gyro => throw new NotImplementedException();

		public virtual global::UnityEngine.Touch[] touches => throw new NotImplementedException();

		public virtual global::UnityEngine.AccelerationEvent[] accelerationEvents => throw new NotImplementedException();

		public virtual global::UnityEngine.AccelerationEvent GetAccelerationEvent(int index) => throw new NotImplementedException();

		public virtual float GetAxis(string axisName) => throw new NotImplementedException();

		public virtual float GetAxisRaw(string axisName) => throw new NotImplementedException();

		public virtual bool GetButton(string buttonName) => throw new NotImplementedException();

		public virtual bool GetButtonDown(string buttonName) => throw new NotImplementedException();

		public virtual bool GetButtonUp(string buttonName) => throw new NotImplementedException();

		public virtual string[] GetJoystickNames() => throw new NotImplementedException();

		public virtual bool GetKey(global::UnityEngine.KeyCode key) => throw new NotImplementedException();

		public virtual bool GetKey(string name) => throw new NotImplementedException();

		public virtual bool GetKeyDown(global::UnityEngine.KeyCode key) => throw new NotImplementedException();

		public virtual bool GetKeyDown(string name) => throw new NotImplementedException();

		public virtual bool GetKeyUp(global::UnityEngine.KeyCode key) => throw new NotImplementedException();

		public virtual bool GetKeyUp(string name) => throw new NotImplementedException();

		public virtual bool GetMouseButton(int button) => throw new NotImplementedException();

		public virtual bool GetMouseButtonDown(int button) => throw new NotImplementedException();

		public virtual bool GetMouseButtonUp(int button) => throw new NotImplementedException();

		public virtual global::UnityEngine.Touch GetTouch(int index) => throw new NotImplementedException();

		public virtual void ResetInputAxes() => throw new NotImplementedException();
	}
}