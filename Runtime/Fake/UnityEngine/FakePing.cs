using Moqunity.Abstract.UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace Moqunity.Fake.UnityEngine
{
	public class FakePing : Ping
	{
		public virtual bool isDone  => throw new NotImplementedException();
		public virtual int time  => throw new NotImplementedException();
		public virtual string ip => throw new NotImplementedException();

		public FakePing(string address)
		{
		}

		public virtual void DestroyPing() => throw new NotImplementedException();
	}
}
