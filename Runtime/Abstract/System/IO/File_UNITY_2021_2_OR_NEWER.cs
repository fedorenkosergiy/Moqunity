#if UNITY_2021_2_OR_NEWER
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Moqunity.Abstract.System.IO
{
	public partial interface File
	{
		Task AppendAllLinesAsync(
			string path,
			IEnumerable<string> contents,
			Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken));

		Task AppendAllLinesAsync(
			string path,
			IEnumerable<string> contents,
			CancellationToken cancellationToken = default(CancellationToken));

		Task AppendAllTextAsync(
			string path,
			string contents,
			Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken));

		Task AppendAllTextAsync(
			string path,
			string contents,
			CancellationToken cancellationToken = default(CancellationToken));

		Task<byte[]> ReadAllBytesAsync(
			string path,
			CancellationToken cancellationToken = default(CancellationToken));

		Task<string[]> ReadAllLinesAsync(
			string path,
			Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken));

		Task<string[]> ReadAllLinesAsync(
			string path,
			CancellationToken cancellationToken = default(CancellationToken));

		Task<string> ReadAllTextAsync(
			string path,
			Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken));

		Task<string> ReadAllTextAsync(
			string path,
			CancellationToken cancellationToken = default(CancellationToken));

		Task WriteAllBytesAsync(
			string path,
			byte[] bytes,
			CancellationToken cancellationToken = default(CancellationToken));

		Task WriteAllLinesAsync(
			string path,
			IEnumerable<string> contents,
			Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken));

		Task WriteAllLinesAsync(
			string path,
			IEnumerable<string> contents,
			CancellationToken cancellationToken = default(CancellationToken));

		Task WriteAllTextAsync(
			string path,
			string contents,
			Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken));

		Task WriteAllTextAsync(
			string path,
			string contents,
			CancellationToken cancellationToken = default(CancellationToken));
	}
}
#endif
