#if UNITY_WSA
using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine.Windows;
using Moqunity.UnityEngine.Windows;

namespace Moqunity
{
    public partial class DefaultFactory
    {
	    private class DefaultWindowsFactory : Factory.WindowsFactory
	    {
		    public File NewFile() => new DefaultFile();
	    }

	    public Factory.WindowsFactory Windows { get; } = new DefaultWindowsFactory();
    }
}
#endif
