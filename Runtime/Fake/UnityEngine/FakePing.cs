using Moqunity.Abstract.UnityEngine;

namespace Moqunity.Fake.UnityEngine
{
	public class FakePing : Ping
	{
		public virtual bool isDone  => throw new System.NotImplementedException();
		public virtual int time  => throw new System.NotImplementedException();
		public virtual string ip => throw new System.NotImplementedException();

		public FakePing(string address)
		{
		}

		public virtual void DestroyPing() => throw new System.NotImplementedException();
	}
}
