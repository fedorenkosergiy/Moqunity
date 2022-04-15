#if UNITY_WSA
namespace Moqunity.Abstract.UnityEngine.Windows
{
	/// <summary>
	///   <para>Provides static methods for file operations.</para>
	/// </summary>
	public interface File : StaticWrapper
	{
		/// <summary>
		///   <para>Opens a binary file, reads the contents of the file into a byte array, and then closes the file.</para>
		/// </summary>
		/// <param name="path">The file to open for reading.</param>
		byte[] ReadAllBytes(string path);

		/// <summary>
		///   <para>Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.</para>
		/// </summary>
		/// <param name="path">The file to write to.</param>
		/// <param name="bytes">The bytes to write to the file.</param>
		void WriteAllBytes(string path, byte[] bytes);

		/// <summary>
		///   <para>Determines whether the specified file exists.</para>
		/// </summary>
		/// <param name="path">The file to check.</param>
		bool Exists(string path);

		/// <summary>
		///   <para>Deletes the specified file.</para>
		/// </summary>
		/// <param name="path">The name of the file to be deleted.</param>
		void Delete(string path);
	}
}
#endif
