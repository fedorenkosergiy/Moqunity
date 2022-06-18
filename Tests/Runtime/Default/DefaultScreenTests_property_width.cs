using NUnit.Framework;

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
#if !NET_STANDARD_2_0
			dynamic screen = global::System.Activator.CreateInstance("Unity.Moqunity", "Moqunity.UnityEngine.DefaultScreen");
			Assert.Throws<Microsoft.CSharp.RuntimeBinder.RuntimeBinderException>(() =>
			{
				screen.width = 100;
			});
#else
			Assert.Ignore(Constants.REQUIRES_NET_4_X);
#endif
		}
	}
}
