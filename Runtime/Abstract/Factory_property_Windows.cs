#if UNITY_WSA
using Moqunity.Abstract.UnityEngine.WSA;

namespace Moqunity.Abstract
{
    public partial interface Factory
    {
        public interface WindowsFactory
        {
            File NewFile();
        }
    }
}
#endif
