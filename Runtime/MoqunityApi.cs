using Moqunity.Abstract;
using System;
using System.Collections.Generic;
using Moqunity;

public class MoqunityApi : IDisposable
{
	private readonly StaticProvider _selfStaticProvider;
	private readonly Factory _selfFactory;
	private bool _isDisposed;
	private static readonly Stack<StaticProvider> _providers = new Stack<StaticProvider>();
	private static readonly Stack<Factory> _factories = new Stack<Factory>();
	private static StaticProvider _provider;
	private static Factory _factory;

	public static StaticProvider Static => _provider ??= _providers.Peek();

	public static Factory Factory => _factory ??= _factories.Peek();

	static MoqunityApi()
	{
		_ = new DefaultMoqunityApi();
	}

	protected MoqunityApi(StaticProvider staticProvider, Factory factory)
	{
		_selfStaticProvider = staticProvider;
		_selfFactory = factory;
		_isDisposed = false;
		_providers.Push(staticProvider);
		_factories.Push(factory);
		_provider = null;
		_factory = null;
	}

	public void Dispose()
	{
		if (_isDisposed)
		{
			throw new ObjectDisposedException(GetType().Name);
		}

		PopProvider();
		PopFactory();

		_isDisposed = true;
	}

	private void PopProvider()
	{
		_provider = null;
		StaticProvider staticProvider = _providers.Pop();
		if (staticProvider != _selfStaticProvider)
		{
			throw new InvalidOperationException("Wrong context");
		}
	}

	private void PopFactory()
	{
		_factory = null;
		Factory factory = _factories.Pop();
		if (factory != _selfFactory)
		{
			throw new InvalidOperationException("Wrong context");
		}
	}
}
