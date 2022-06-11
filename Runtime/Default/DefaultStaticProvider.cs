using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;
using Random = Moqunity.Abstract.UnityEngine.Random;
using System;
using System.Collections.Generic;
using Moqunity.Abstract.System.IO;

namespace Moqunity
{
	public partial class DefaultStaticProvider : StaticProvider
	{
		private bool needsInitialization = true;

		private IDictionary<Type, StaticWrapper> staticWrappers = new Dictionary<Type, StaticWrapper>();
		public Application Application { get; private set; }
		public Screen Screen { get; private set; }
		public Input Input { get; private set; }
		public Time Time { get; private set; }
		public SystemInfo SystemInfo { get; private set; }
		public Random Random { get; private set; }
		public Debug Debug { get; private set; }
		public PlayerPrefs PlayerPrefs { get; private set; }
		public Resources Resources { get; private set; }
		public void Init(Factory factory)
		{
			lock (this)
			{
				if (needsInitialization)
				{
					InstantiateStaticWrappersForSystem(factory);
					InstantiateStaticWrappersForUnityEngine(factory);
					InstantiateStaticWrappersForUnityEngineRendering(factory);
					InstantiateStaticWrappersForUnityEngineWsa(factory);
					needsInitialization = false;
				}
				else
				{
					global::UnityEngine.Debug.LogWarning("Static already initialized");
				}
			}
		}

		private void InstantiateStaticWrappersForSystem(Factory factory)
		{
			staticWrappers.Add(typeof(File), factory.System.IO.NewFile());
		}

		private void InstantiateStaticWrappersForUnityEngine(Factory factory)
		{
			Application = factory.NewApplication();
			staticWrappers.Add(typeof(Application), Application);

			Screen = factory.NewScreen();
			staticWrappers.Add(typeof(Screen), Screen);

			Input = factory.NewInput();
			staticWrappers.Add(typeof(Input), Input);

			Time = factory.NewTime();
			staticWrappers.Add(typeof(Time), Time);

			SystemInfo = factory.NewSystemInfo();
			staticWrappers.Add(typeof(SystemInfo), SystemInfo);

			Random = factory.NewRandom();
			staticWrappers.Add(typeof(Random), Random);

			Debug = factory.NewDebug();
			staticWrappers.Add(typeof(Debug), Debug);

			PlayerPrefs = factory.NewPlayerPrefs();
			staticWrappers.Add(typeof(PlayerPrefs), PlayerPrefs);

			Resources = factory.NewResources();
			staticWrappers.Add(typeof(Resources), Resources);
		}

		private void InstantiateStaticWrappersForUnityEngineRendering(Factory factory)
		{
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.Rendering.AsyncGPUReadback), factory.Rendering.NewAsyncGPUReadback());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.Rendering.OnDemandRendering), factory.Rendering.NewOnDemandRendering());
		}

		partial void InstantiateStaticWrappersForUnityEngineWsa(Factory factory);

		public T Get<T>() where T : StaticWrapper => (T)staticWrappers[typeof(T)];
	}
}
