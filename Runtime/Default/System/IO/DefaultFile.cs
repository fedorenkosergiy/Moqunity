using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Moqunity.System.IO
{
	public class DefaultFile : Moqunity.Abstract.System.IO.File
	{
		public void AppendAllLines(string path, IEnumerable<string> contents)
		{
			File.AppendAllLines(path, contents);
		}

		public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			File.AppendAllLines(path, contents, encoding);
		}

		public void AppendAllText(string path, string contents)
		{
			File.AppendAllText(path, contents);
		}

		public void AppendAllText(string path, string contents, Encoding encoding)
		{
			File.AppendAllText(path, contents, encoding);
		}

		public StreamWriter AppendText(string path)
		{
			return File.AppendText(path);
		}

		public void Copy(string sourceFileName, string destFileName)
		{
			File.Copy(sourceFileName, destFileName);
		}

		public void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
			File.Copy(sourceFileName, destFileName, overwrite);
		}

		public FileStream Create(string path)
		{
			return File.Create(path);
		}

		public FileStream Create(string path, int bufferSize)
		{
			return File.Create(path, bufferSize);
		}

		public FileStream Create(string path, int bufferSize, FileOptions options)
		{
			return File.Create(path, bufferSize, options);
		}

		public StreamWriter CreateText(string path)
		{
			return File.CreateText(path);
		}

		public void Decrypt(string path)
		{
			File.Decrypt(path);
		}

		public void Delete(string path)
		{
			File.Delete(path);
		}

		public void Encrypt(string path)
		{
			File.Encrypt(path);
		}

		public bool Exists(string path)
		{
			return File.Exists(path);
		}

		public FileAttributes GetAttributes(string path)
		{
			return File.GetAttributes(path);
		}

		public DateTime GetCreationTime(string path)
		{
			return File.GetCreationTime(path);
		}

		public DateTime GetCreationTimeUtc(string path)
		{
			return File.GetCreationTimeUtc(path);
		}

		public DateTime GetLastAccessTime(string path)
		{
			return File.GetLastAccessTime(path);
		}

		public DateTime GetLastAccessTimeUtc(string path)
		{
			return File.GetLastAccessTimeUtc(path);
		}

		public DateTime GetLastWriteTime(string path)
		{
			return File.GetLastWriteTime(path);
		}

		public DateTime GetLastWriteTimeUtc(string path)
		{
			return File.GetLastWriteTime(path);
		}

		public void Move(string sourceFileName, string destFileName)
		{
			File.Move(sourceFileName, destFileName);
		}

		public FileStream Open(string path, FileMode mode)
		{
			return File.Open(path, mode);
		}

		public FileStream Open(string path, FileMode mode, FileAccess access)
		{
			return File.Open(path, mode, access);
		}

		public FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return File.Open(path, mode, access, share);
		}

		public FileStream OpenRead(string path)
		{
			return File.OpenRead(path);
		}

		public StreamReader OpenText(string path)
		{
			return File.OpenText(path);
		}

		public FileStream OpenWrite(string path)
		{
			return File.OpenWrite(path);
		}

		public byte[] ReadAllBytes(string path)
		{
			return File.ReadAllBytes(path);
		}

		public string[] ReadAllLines(string path)
		{
			return File.ReadAllLines(path);
		}

		public string[] ReadAllLines(string path, Encoding encoding)
		{
			return File.ReadAllLines(path, encoding);
		}

		public string ReadAllText(string path)
		{
			return File.ReadAllText(path);
		}

		public string ReadAllText(string path, Encoding encoding)
		{
			return File.ReadAllText(path, encoding);
		}

		public IEnumerable<string> ReadLines(string path)
		{
			return File.ReadLines(path);
		}

		public IEnumerable<string> ReadLines(string path, Encoding encoding)
		{
			return File.ReadLines(path, encoding);
		}

		public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
		{
			File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
		}

		public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName,
			bool ignoreMetadataErrors)
		{
			File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
		}

		public void SetAttributes(string path, FileAttributes fileAttributes)
		{
			File.SetAttributes(path, fileAttributes);
		}

		public void SetCreationTime(string path, DateTime creationTime)
		{
			File.SetCreationTime(path, creationTime);
		}

		public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
		{
			File.SetCreationTimeUtc(path, creationTimeUtc);
		}

		public void SetLastAccessTime(string path, DateTime lastAccessTime)
		{
			File.SetLastAccessTime(path, lastAccessTime);
		}

		public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
		{
			File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
		}

		public void SetLastWriteTime(string path, DateTime lastWriteTime)
		{
			File.SetLastWriteTime(path, lastWriteTime);
		}

		public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
		{
			File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
		}

		public void WriteAllBytes(string path, byte[] bytes)
		{
			File.WriteAllBytes(path, bytes);
		}

		public void WriteAllLines(string path, IEnumerable<string> contents)
		{
			File.WriteAllLines(path, contents);
		}

		public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			File.WriteAllLines(path, contents, encoding);
		}

		public void WriteAllLines(string path, string[] contents)
		{
			File.WriteAllLines(path, contents);
		}

		public void WriteAllLines(string path, string[] contents, Encoding encoding)
		{
			File.WriteAllLines(path, contents, encoding);
		}

		public void WriteAllText(string path, string contents)
		{
			File.WriteAllText(path, contents);
		}

		public void WriteAllText(string path, string contents, Encoding encoding)
		{
			File.WriteAllText(path, contents, encoding);
		}

		public async Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);
		}

		public async Task AppendAllLinesAsync(string path, IEnumerable<string> contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.AppendAllLinesAsync(path, contents, cancellationToken);
		}

		public async Task AppendAllTextAsync(string path, string contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
		}

		public async Task AppendAllTextAsync(string path, string contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.AppendAllTextAsync(path, contents, cancellationToken);
		}

		public async Task<byte[]> ReadAllBytesAsync(string path,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await File.ReadAllBytesAsync(path, cancellationToken);
		}

		public async Task<string[]> ReadAllLinesAsync(string path, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await File.ReadAllLinesAsync(path, encoding, cancellationToken);
		}

		public async Task<string[]> ReadAllLinesAsync(string path,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await File.ReadAllLinesAsync(path, cancellationToken);
		}

		public async Task<string> ReadAllTextAsync(string path, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await File.ReadAllTextAsync(path, encoding, cancellationToken);
		}

		public async Task<string> ReadAllTextAsync(string path,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return await File.ReadAllTextAsync(path, cancellationToken);
		}

		public async Task WriteAllBytesAsync(string path, byte[] bytes,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.WriteAllBytesAsync(path, bytes, cancellationToken);
		}

		public async Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
		}

		public async Task WriteAllLinesAsync(string path, IEnumerable<string> contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.WriteAllLinesAsync(path, contents, cancellationToken);
		}

		public async Task WriteAllTextAsync(string path, string contents, Encoding encoding,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
		}

		public async Task WriteAllTextAsync(string path, string contents,
			CancellationToken cancellationToken = default(CancellationToken))
		{
			await File.WriteAllTextAsync(path, contents, cancellationToken);
		}
	}
}
