using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;
using Random = Moqunity.Abstract.UnityEngine.Random;
using System;
using System.Collections.Generic;

namespace Moqunity
{
	public class DefaultFactory : Factory
	{
		private bool needsInitialization = true;

		private IDictionary<Type, StaticWrapper> staticWrappers = new Dictionary<Type, StaticWrapper>();
		public Application Application { get; private set; }
		public Screen Screen { get; private set; }
		public Input Input { get; private set; }
		public Time Time { get; private set; }
		public SystemInfo SystemInfo { get; private set; }
		public Random Random { get; private set; }
		public void Init()
		{
			lock (this)
			{
				if (needsInitialization)
				{
					InstantianteStaticWrappersForUnityEngine();
					InstantianteStaticWrappersForUnityEngineRendering();
					needsInitialization = false;
				}
				else
				{
					global::UnityEngine.Debug.LogWarning("factory already initialized");
				}
			}
		}

		private void InstantianteStaticWrappersForUnityEngine()
		{
			Application = new DefaultApplication();
			staticWrappers.Add(typeof(Application), Application);

			Screen = new DefaultScreen();
			staticWrappers.Add(typeof(Screen), Screen);

			Input = new DefaultInput();
			staticWrappers.Add(typeof(Input), Input);
	
			Time = new DefaultTime();
			staticWrappers.Add(typeof(Time), Time);
	
			SystemInfo = new DefaultSystemInfo();
			staticWrappers.Add(typeof(SystemInfo), SystemInfo);
	
			Random = new DefaultRandom();
			staticWrappers.Add(typeof(Random), Random);
		}

		private void InstantianteStaticWrappersForUnityEngineRendering()
		{

		}

		public T Get<T>() where T : StaticWrapper => (T)staticWrappers[typeof(T)];
	}
}
