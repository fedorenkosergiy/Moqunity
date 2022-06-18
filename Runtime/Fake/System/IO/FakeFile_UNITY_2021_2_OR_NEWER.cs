#if UNITY_2021_2_OR_NEWER
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Moqunity.Fake.System.IO
{
	public partial class FakeFile
	{
		public virtual async Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task AppendAllLinesAsync(string path, IEnumerable<string> contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task AppendAllTextAsync(string path, string contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task<string[]> ReadAllLinesAsync(string path, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task WriteAllLinesAsync(string path, IEnumerable<string> contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task WriteAllTextAsync(string path, string contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

		public virtual async Task WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken))
		{
			await Task.Yield();
			throw new NotImplementedException();
		}

	}
}
#endif
