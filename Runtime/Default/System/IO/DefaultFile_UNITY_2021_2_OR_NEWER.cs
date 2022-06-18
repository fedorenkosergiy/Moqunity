#if UNITY_2021_2_OR_NEWER
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Moqunity.System.IO
{
	public partial class DefaultFile
	{
		public async Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);
		}

		public async Task AppendAllLinesAsync(string path, IEnumerable<string> contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.AppendAllLinesAsync(path, contents, cancellationToken);
		}

		public async Task AppendAllTextAsync(string path, string contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
		}

		public async Task AppendAllTextAsync(string path, string contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.AppendAllTextAsync(path, contents, cancellationToken);
		}

		public async Task<byte[]> ReadAllBytesAsync(string path,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await global::System.IO.File.ReadAllBytesAsync(path, cancellationToken);
		}

		public async Task<string[]> ReadAllLinesAsync(string path, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await global::System.IO.File.ReadAllLinesAsync(path, encoding, cancellationToken);
		}

		public async Task<string[]> ReadAllLinesAsync(string path,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await global::System.IO.File.ReadAllLinesAsync(path, cancellationToken);
		}

		public async Task<string> ReadAllTextAsync(string path, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await global::System.IO.File.ReadAllTextAsync(path, encoding, cancellationToken);
		}

		public async Task<string> ReadAllTextAsync(string path,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await global::System.IO.File.ReadAllTextAsync(path, cancellationToken);
		}

		public async Task WriteAllBytesAsync(string path, byte[] bytes,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.WriteAllBytesAsync(path, bytes, cancellationToken);
		}

		public async Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
		}

		public async Task WriteAllLinesAsync(string path, IEnumerable<string> contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.WriteAllLinesAsync(path, contents, cancellationToken);
		}

		public async Task WriteAllTextAsync(string path, string contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
		}

		public async Task WriteAllTextAsync(string path, string contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await global::System.IO.File.WriteAllTextAsync(path, contents, cancellationToken);
		}
	}
}
#endif
