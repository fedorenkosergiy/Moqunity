using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Moqunity.Fake.System.IO
{
	[PublicAPI]
	public partial class FakeFile : Moqunity.Abstract.System.IO.File
	{
		public virtual void AppendAllLines(string path, IEnumerable<string> contents)
		{
			throw new NotImplementedException();
		}

		public virtual void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			throw new NotImplementedException();
		}

		public virtual void AppendAllText(string path, string contents)
		{
			throw new NotImplementedException();
		}

		public virtual void AppendAllText(string path, string contents, Encoding encoding)
		{
			throw new NotImplementedException();
		}

		public virtual StreamWriter AppendText(string path)
		{
			throw new NotImplementedException();
		}

		public virtual void Copy(string sourceFileName, string destFileName)
		{
			throw new NotImplementedException();
		}

		public virtual void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
			throw new NotImplementedException();
		}

		public virtual FileStream Create(string path)
		{
			throw new NotImplementedException();
		}

		public virtual FileStream Create(string path, int bufferSize)
		{
			throw new NotImplementedException();
		}

		public virtual FileStream Create(string path, int bufferSize, FileOptions options)
		{
			throw new NotImplementedException();
		}

		public virtual StreamWriter CreateText(string path)
		{
			throw new NotImplementedException();
		}

		public virtual void Decrypt(string path)
		{
			throw new NotImplementedException();
		}

		public virtual void Delete(string path)
		{
			throw new NotImplementedException();
		}

		public virtual void Encrypt(string path)
		{
			throw new NotImplementedException();
		}

		public virtual bool Exists(string path)
		{
			throw new NotImplementedException();
		}

		public virtual FileAttributes GetAttributes(string path)
		{
			throw new NotImplementedException();
		}

		public virtual DateTime GetCreationTime(string path)
		{
			throw new NotImplementedException();
		}

		public virtual DateTime GetCreationTimeUtc(string path)
		{
			throw new NotImplementedException();
		}

		public virtual DateTime GetLastAccessTime(string path)
		{
			throw new NotImplementedException();
		}

		public virtual DateTime GetLastAccessTimeUtc(string path)
		{
			throw new NotImplementedException();
		}

		public virtual DateTime GetLastWriteTime(string path)
		{
			throw new NotImplementedException();
		}

		public virtual DateTime GetLastWriteTimeUtc(string path)
		{
			throw new NotImplementedException();
		}

		public virtual void Move(string sourceFileName, string destFileName)
		{
			throw new NotImplementedException();
		}

		public virtual FileStream Open(string path, FileMode mode)
		{
			throw new NotImplementedException();
		}

		public virtual FileStream Open(string path, FileMode mode, FileAccess access)
		{
			throw new NotImplementedException();
		}

		public virtual FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			throw new NotImplementedException();
		}

		public virtual FileStream OpenRead(string path)
		{
			throw new NotImplementedException();
		}

		public virtual StreamReader OpenText(string path)
		{
			throw new NotImplementedException();
		}

		public virtual FileStream OpenWrite(string path)
		{
			throw new NotImplementedException();
		}

		public virtual byte[] ReadAllBytes(string path)
		{
			throw new NotImplementedException();
		}

		public virtual string[] ReadAllLines(string path)
		{
			throw new NotImplementedException();
		}

		public virtual string[] ReadAllLines(string path, Encoding encoding)
		{
			throw new NotImplementedException();
		}

		public virtual string ReadAllText(string path)
		{
			throw new NotImplementedException();
		}

		public virtual string ReadAllText(string path, Encoding encoding)
		{
			throw new NotImplementedException();
		}

		public virtual IEnumerable<string> ReadLines(string path)
		{
			throw new NotImplementedException();
		}

		public virtual IEnumerable<string> ReadLines(string path, Encoding encoding)
		{
			throw new NotImplementedException();
		}

		public virtual void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
		{
			throw new NotImplementedException();
		}

		public virtual void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName,
			bool ignoreMetadataErrors)
		{
			throw new NotImplementedException();
		}

		public virtual void SetAttributes(string path, FileAttributes fileAttributes)
		{
			throw new NotImplementedException();
		}

		public virtual void SetCreationTime(string path, DateTime creationTime)
		{
			throw new NotImplementedException();
		}

		public virtual void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
		{
			throw new NotImplementedException();
		}

		public virtual void SetLastAccessTime(string path, DateTime lastAccessTime)
		{
			throw new NotImplementedException();
		}

		public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
		{
			throw new NotImplementedException();
		}

		public virtual void SetLastWriteTime(string path, DateTime lastWriteTime)
		{
			throw new NotImplementedException();
		}

		public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
		{
			throw new NotImplementedException();
		}

		public virtual void WriteAllBytes(string path, byte[] bytes)
		{
			throw new NotImplementedException();
		}

		public virtual void WriteAllLines(string path, IEnumerable<string> contents)
		{
			throw new NotImplementedException();
		}

		public virtual void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
		{
			throw new NotImplementedException();
		}

		public virtual void WriteAllLines(string path, string[] contents)
		{
			throw new NotImplementedException();
		}

		public virtual void WriteAllLines(string path, string[] contents, Encoding encoding)
		{
			throw new NotImplementedException();
		}

		public virtual void WriteAllText(string path, string contents)
		{
			throw new NotImplementedException();
		}

		public virtual void WriteAllText(string path, string contents, Encoding encoding)
		{
			throw new NotImplementedException();
		}
	}
}
