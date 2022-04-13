#if UNITY_WSA
using System;

namespace Moqunity.Fake.UnityEngine.WSA
{
	public class FakeCursor : global::Moqunity.Abstract.UnityEngine.WSA.Cursor
	{
        public virtual void SetCustomCursor(uint id) => throw new NotImplementedException();
    }
}
#endif