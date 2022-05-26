using Moqunity.Abstract;
using System;
using System.Collections.Generic;
using Moqunity;

public class MoqunityApi : IDisposable
{
	private readonly Provider _selfProvider;
	private bool isDisposed;
	private static readonly Stack<Provider> providers = new Stack<Provider>();
	private static Provider peek;

	public static Provider Provider => peek ??= providers.Peek();

	static MoqunityApi()
	{
		_ = new DefaultMoqunityApi();
	}

	protected MoqunityApi(Provider provider)
	{
		_selfProvider = provider;
		isDisposed = false;
		providers.Push(provider);
		peek = null;
	}

	public void Dispose()
	{
		if (isDisposed)
		{
			throw new ObjectDisposedException(GetType().Name);
		}

		peek = null;
		Provider provider = providers.Pop();
		if (provider != _selfProvider)
		{
			throw new InvalidOperationException("Wrong context");
		}

		isDisposed = true;
	}
}
