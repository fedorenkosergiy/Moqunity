using System;

namespace Moqunity.UnityEngine.WSA
{
	public class DefaultCursor : global::Moqunity.Abstract.UnityEngine.WSA.Cursor
	{
        public virtual void SetCustomCursor(uint id) => global::UnityEngine.WSA.Cursor.SetCustomCursor(id);
    }
}