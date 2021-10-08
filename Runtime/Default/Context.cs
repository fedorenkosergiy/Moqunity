using Moqunity.Abstract;
using System;
using System.Collections.Generic;

namespace Moqunity
{
	public class Context : IDisposable
	{
		private readonly Factory selfFactory;
		private bool isDisposed;
		private static Stack<Factory> factories = new Stack<Factory>();
		private static Factory peek;

		public static Factory Factory => peek ?? (peek = factories.Peek());

		static Context()
		{
			_ = new DefaultContext();
		}

		protected Context(Factory factory)
		{
			selfFactory = factory;
			isDisposed = false;
			factories.Push(factory);
			peek = null;
		}

		public void Dispose()
		{
			if (isDisposed)
			{
				throw new ObjectDisposedException(GetType().Name);
			}

			peek = null;
			Factory factory = factories.Pop();
			if (factory != selfFactory)
			{
				throw new InvalidOperationException("Wrong context");
			}

			isDisposed = true;
		}
	}
}
