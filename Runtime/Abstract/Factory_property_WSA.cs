#if UNITY_WSA
using Moqunity.Abstract.UnityEngine.WSA;

namespace Moqunity.Abstract
{
    public partial interface Factory
    {
        public interface WSAFactory
        {
            Application NewApplication();
            Cursor NewCursor();
            Launcher NewLauncher();
        }


        WSAFactory WSA { get; }
    }
}
#endif
