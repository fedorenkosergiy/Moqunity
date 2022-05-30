#if UNITY_WSA
using Moqunity.Abstract.UnityEngine.Windows;

namespace Moqunity.Abstract
{
    public partial interface Factory
    {
        public interface WindowsFactory
        {
            File NewFile();
        }

        WindowsFactory Windows { get; }
    }
}
#endif
