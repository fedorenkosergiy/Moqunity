using Moqunity.Abstract.UnityEngine;

namespace Moqunity.Abstract
{
	public interface Factory
	{
		/// <summary>
		/// Perform a ping to the supplied target IP address.
		/// </summary>
		/// <param name="address">address</param>
		Ping NewPing(string address);
	}
}
