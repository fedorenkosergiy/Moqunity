using Moqunity.Abstract.UnityEngine;

namespace Moqunity.UnityEngine
{
	public class DefaultPing : Ping
	{
		private global::UnityEngine.Ping ping;

		public bool isDone => ping.isDone;

		public int time => ping.time;

		public string ip => ping.ip;

		public DefaultPing(string address) => ping = new global::UnityEngine.Ping(address);

		public void DestroyPing() => ping.DestroyPing();
	}
}
