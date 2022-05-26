using Moqunity.Abstract;
using System;
using System.Collections.Generic;

namespace Moqunity
{
	public class Mxt : IDisposable
	{
		private readonly Provider _selfProvider;
		private bool isDisposed;
		private static readonly Stack<Provider> factories = new Stack<Provider>();
		private static Provider peek;

		public static Provider Provider => peek ??= factories.Peek();

		static Mxt()
		{
			_ = new DefaultMxt();
		}

		protected Mxt(Provider provider)
		{
			_selfProvider = provider;
			isDisposed = false;
			factories.Push(provider);
			peek = null;
		}

		public void Dispose()
		{
			if (isDisposed)
			{
				throw new ObjectDisposedException(GetType().Name);
			}

			peek = null;
			Provider provider = factories.Pop();
			if (provider != _selfProvider)
			{
				throw new InvalidOperationException("Wrong context");
			}

			isDisposed = true;
		}
	}
}
