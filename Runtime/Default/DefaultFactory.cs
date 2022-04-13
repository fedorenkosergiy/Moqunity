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
					InstantiateStaticWrappersForUnityEngine();
					InstantiateStaticWrappersForUnityEngineRendering();
					InstantiateStaticWrappersForUnityEngineWsa();
					needsInitialization = false;
				}
				else
				{
					global::UnityEngine.Debug.LogWarning("factory already initialized");
				}
			}
		}

		private void InstantiateStaticWrappersForUnityEngine()
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

		private void InstantiateStaticWrappersForUnityEngineRendering()
		{
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.Rendering.AsyncGPUReadback), new Moqunity.UnityEngine.Rendering.DefaultAsyncGPUReadback());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.Rendering.OnDemandRendering), new Moqunity.UnityEngine.Rendering.DefaultOnDemandRendering());
		}

		private void InstantiateStaticWrappersForUnityEngineWsa()
		{
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Application), new Moqunity.UnityEngine.WSA.DefaultApplication());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Cursor), new Moqunity.UnityEngine.WSA.DefaultCursor());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Launcher), new Moqunity.UnityEngine.WSA.DefaultLauncher());
		}

		public T Get<T>() where T : StaticWrapper => (T)staticWrappers[typeof(T)];
	}
}
