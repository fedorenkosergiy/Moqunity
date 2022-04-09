using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Moqunity.UnityEngine.Rendering
{
	/// <summary>
	/// <para>Allows the asynchronous read back of GPU resources.</para>
	/// </summary>
	public class DefaultAsyncGPUReadback : global::Moqunity.Abstract.UnityEngine.Rendering.AsyncGPUReadback
	{
		/// <summary>
		///   <para>Waits until the completion of every request.</para>
		/// </summary>
		public void WaitAllRequests() => global::UnityEngine.Rendering.AsyncGPUReadback.WaitAllRequests();

		public AsyncGPUReadbackRequest Request(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, callback);

		public AsyncGPUReadbackRequest Request(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, size, offset, callback);

		public AsyncGPUReadbackRequest Request(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, callback);

		public AsyncGPUReadbackRequest Request(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, size, offset, callback);

		public AsyncGPUReadbackRequest Request(Texture src, int mipIndex = 0, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, mipIndex, callback);

		public AsyncGPUReadbackRequest Request(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, mipIndex, dstFormat, callback);

		public AsyncGPUReadbackRequest Request(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, mipIndex, dstFormat, callback);

		public AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, callback);

		public AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);

		public AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) => global::UnityEngine.Rendering.AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, size, offset, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, size, offset, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex = 0, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, dstFormat, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, dstFormat, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, size, offset, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, size, offset, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex = 0, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, dstFormat, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, dstFormat, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);

		public AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) where T : struct => global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, callback);
	}
}