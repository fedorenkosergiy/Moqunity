using Microsoft.CSharp.RuntimeBinder;
using NUnit.Framework;
using System;

namespace Moqunity.UnityEngine
{
	public partial class DefaultScreenTests
	{
		[Test]
		public void CheckWidth()
		{
			DefaultScreen screen = new DefaultScreen();
			Assert.AreEqual(global::UnityEngine.Screen.width, screen.width);
		}

		[Test]
		public void CheckWidthSetter()
		{
			dynamic screen = Activator.CreateInstance("Unity.Moqunity", "Moqunity.UnityEngine.DefaultScreen");
			Assert.Throws<RuntimeBinderException>(() =>
			{
				screen.width = 100;
			});
		}
	}
}
