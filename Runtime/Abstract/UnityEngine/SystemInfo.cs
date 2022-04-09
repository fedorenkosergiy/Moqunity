using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo : StaticWrapper
	{
		/// <summary>
		///   <para>Value returned by SystemInfo string properties which are not supported on the current platform.</para>
		/// </summary>
		public string unsupportedIdentifier {get;}

		/// <summary>
		///   <para>The current battery level (Read Only).</para>
		/// </summary>
		public  float batteryLevel { get; }

		/// <summary>
		///   <para>Returns the current status of the device's battery (Read Only).</para>
		/// </summary>
		public  BatteryStatus batteryStatus { get; }

		/// <summary>
		///   <para>Operating system name with version (Read Only).</para>
		/// </summary>
		public  string operatingSystem { get; }

		/// <summary>
		///   <para>Returns the operating system family the game is running on (Read Only).</para>
		/// </summary>
		public  OperatingSystemFamily operatingSystemFamily { get; }

		/// <summary>
		///   <para>Processor name (Read Only).</para>
		/// </summary>
		public  string processorType { get; }

		/// <summary>
		///   <para>Processor frequency in MHz (Read Only).</para>
		/// </summary>
		public  int processorFrequency { get; }

		/// <summary>
		///   <para>Number of processors present (Read Only).</para>
		/// </summary>
		public  int processorCount { get; }

		/// <summary>
		///   <para>Amount of system memory present (Read Only).</para>
		/// </summary>
		public  int systemMemorySize { get; }

		/// <summary>
		///   <para>A unique device identifier. It is guaranteed to be unique for every device (Read Only).</para>
		/// </summary>
		public  string deviceUniqueIdentifier { get; }

		/// <summary>
		///   <para>The user defined name of the device (Read Only).</para>
		/// </summary>
		public  string deviceName { get; }

		/// <summary>
		///   <para>The model of the device (Read Only).</para>
		/// </summary>
		public  string deviceModel { get; }

		/// <summary>
		///   <para>Is an accelerometer available on the device?</para>
		/// </summary>
		public  bool supportsAccelerometer { get; }

		/// <summary>
		///   <para>Is a gyroscope available on the device?</para>
		/// </summary>
		public  bool supportsGyroscope { get; }

		/// <summary>
		///   <para>Is the device capable of reporting its location?</para>
		/// </summary>
		public  bool supportsLocationService { get; }

		/// <summary>
		///   <para>Is the device capable of providing the user haptic feedback by vibration?</para>
		/// </summary>
		public  bool supportsVibration { get; }

		/// <summary>
		///   <para>Is there an Audio device available for playback? (Read Only)</para>
		/// </summary>
		public  bool supportsAudio { get; }

		/// <summary>
		///   <para>Returns the kind of device the application is running on (Read Only).</para>
		/// </summary>
		public  DeviceType deviceType { get; }

		/// <summary>
		///   <para>Amount of video memory present (Read Only).</para>
		/// </summary>
		public  int graphicsMemorySize { get; }

		/// <summary>
		///   <para>The name of the graphics device (Read Only).</para>
		/// </summary>
		public  string graphicsDeviceName { get; }

		/// <summary>
		///   <para>The vendor of the graphics device (Read Only).</para>
		/// </summary>
		public  string graphicsDeviceVendor { get; }

		/// <summary>
		///   <para>The identifier code of the graphics device (Read Only).</para>
		/// </summary>
		public  int graphicsDeviceID { get; }

		/// <summary>
		///   <para>The identifier code of the graphics device vendor (Read Only).</para>
		/// </summary>
		public  int graphicsDeviceVendorID { get; }

		/// <summary>
		///   <para>The graphics API type used by the graphics device (Read Only).</para>
		/// </summary>
		public  GraphicsDeviceType graphicsDeviceType { get; }

		/// <summary>
		///   <para>Returns true if the texture UV coordinate convention for this platform has Y starting at the top of the image.</para>
		/// </summary>
		public  bool graphicsUVStartsAtTop { get; }

		/// <summary>
		///   <para>The graphics API type and driver version used by the graphics device (Read Only).</para>
		/// </summary>
		public  string graphicsDeviceVersion { get; }

		/// <summary>
		///   <para>Graphics device shader capability level (Read Only).</para>
		/// </summary>
		public  int graphicsShaderLevel { get; }

		/// <summary>
		///   <para>Is graphics device using multi-threaded rendering (Read Only)?</para>
		/// </summary>
		public  bool graphicsMultiThreaded { get; }

		/// <summary>
		///   <para>Application's actual rendering threading mode (Read Only).</para>
		/// </summary>
		public  RenderingThreadingMode renderingThreadingMode { get; }

		/// <summary>
		///   <para>True if the GPU supports hidden surface removal.</para>
		/// </summary>
		public  bool hasHiddenSurfaceRemovalOnGPU { get; }

		/// <summary>
		///   <para>Returns true when the GPU has native support for indexing uniform arrays in fragment shaders without restrictions.</para>
		/// </summary>
		public  bool hasDynamicUniformArrayIndexingInFragmentShaders { get; }

		/// <summary>
		///   <para>Are built-in shadows supported? (Read Only)</para>
		/// </summary>
		public  bool supportsShadows { get; }

		/// <summary>
		///   <para>Is sampling raw depth from shadowmaps supported? (Read Only)</para>
		/// </summary>
		public  bool supportsRawShadowDepthSampling { get; }

		/// <summary>
		///   <para>Whether motion vectors are supported on this platform.</para>
		/// </summary>
		public  bool supportsMotionVectors { get; }

		/// <summary>
		///   <para>Are 3D (volume) textures supported? (Read Only)</para>
		/// </summary>
		public  bool supports3DTextures { get; }

		/// <summary>
		///   <para>Are compressed formats for 3D (volume) textures supported? (Read Only).</para>
		/// </summary>
		public  bool supportsCompressed3DTextures { get; }

		/// <summary>
		///   <para>Are 2D Array textures supported? (Read Only)</para>
		/// </summary>
		public  bool supports2DArrayTextures { get; }

		/// <summary>
		///   <para>Are 3D (volume) RenderTextures supported? (Read Only)</para>
		/// </summary>
		public  bool supports3DRenderTextures { get; }

		/// <summary>
		///   <para>Are Cubemap Array textures supported? (Read Only)</para>
		/// </summary>
		public  bool supportsCubemapArrayTextures { get; }

		/// <summary>
		///   <para>Support for various Graphics.CopyTexture cases (Read Only).</para>
		/// </summary>
		public  CopyTextureSupport copyTextureSupport { get; }

		/// <summary>
		///   <para>Are compute shaders supported? (Read Only)</para>
		/// </summary>
		public  bool supportsComputeShaders { get; }

		/// <summary>
		///   <para>Is conservative rasterization supported? (Read Only)</para>
		/// </summary>
		public  bool supportsConservativeRaster { get; }

		/// <summary>
		///   <para>Boolean that indicates whether Multiview is supported (true if supported, false if not supported). (Read Only)</para>
		/// </summary>
		public  bool supportsMultiview { get; }

		/// <summary>
		///   <para>Are geometry shaders supported? (Read Only)</para>
		/// </summary>
		public  bool supportsGeometryShaders { get; }

		/// <summary>
		///   <para>Are tessellation shaders supported? (Read Only)</para>
		/// </summary>
		public  bool supportsTessellationShaders { get; }

		/// <summary>
		///   <para>Boolean that indicates if SV_RenderTargetArrayIndex can be used in a vertex shader (true if it can be used, false if not).</para>
		/// </summary>
		public  bool supportsRenderTargetArrayIndexFromVertexShader { get; }

		/// <summary>
		///   <para>Is GPU draw call instancing supported? (Read Only)</para>
		/// </summary>
		public  bool supportsInstancing { get; }

		/// <summary>
		///   <para>Does the hardware support quad topology? (Read Only)</para>
		/// </summary>
		public  bool supportsHardwareQuadTopology { get; }

		/// <summary>
		///   <para>Are 32-bit index buffers supported? (Read Only)</para>
		/// </summary>
		public  bool supports32bitsIndexBuffer { get; }

		/// <summary>
		///   <para>Are sparse textures supported? (Read Only)</para>
		/// </summary>
		public  bool supportsSparseTextures { get; }

		/// <summary>
		///   <para>How many simultaneous render targets (MRTs) are supported? (Read Only)</para>
		/// </summary>
		public  int supportedRenderTargetCount { get; }

		/// <summary>
		///   <para>Returns true when the platform supports different blend modes when rendering to multiple render targets, or false otherwise.</para>
		/// </summary>
		public  bool supportsSeparatedRenderTargetsBlend { get; }

		/// <summary>
		///   <para>The maximum number of random write targets (UAV) that Unity supports simultaneously. (Read Only)</para>
		/// </summary>
		public  int supportedRandomWriteTargetCount { get; }

		/// <summary>
		///   <para>Are multisampled textures supported? (Read Only)</para>
		/// </summary>
		public  int supportsMultisampledTextures { get; }

		/// <summary>
		///   <para>Boolean that indicates whether multisampled texture arrays are supported (true if supported, false if not supported).</para>
		/// </summary>
		public  bool supportsMultisampled2DArrayTextures { get; }

		/// <summary>
		///   <para>Returns true if multisampled textures are resolved automatically</para>
		/// </summary>
		public  bool supportsMultisampleAutoResolve { get; }

		/// <summary>
		///   <para>Returns true if the 'Mirror Once' texture wrap mode is supported. (Read Only)</para>
		/// </summary>
		public  int supportsTextureWrapMirrorOnce { get; }

		/// <summary>
		///   <para>This property is true if the current platform uses a reversed depth buffer (where values range from 1 at the near plane and 0 at far plane), and false if the depth buffer is normal (0 is near, 1 is far). (Read Only)</para>
		/// </summary>
		public  bool usesReversedZBuffer { get; }

		/// <summary>
		///   <para>What NPOT (non-power of two size) texture support does the GPU provide? (Read Only)</para>
		/// </summary>
		public  NPOTSupport npotSupport { get; }

		/// <summary>
		///   <para>Maximum texture size (Read Only).</para>
		/// </summary>
		public  int maxTextureSize { get; }

		/// <summary>
		///   <para>Maximum Cubemap texture size (Read Only).</para>
		/// </summary>
		public  int maxCubemapSize { get; }

		/// <summary>
		///   <para>Determines how many compute buffers Unity supports simultaneously in a vertex shader for reading. (Read Only)</para>
		/// </summary>
		public  int maxComputeBufferInputsVertex { get; }

		/// <summary>
		///   <para>Determines how many compute buffers Unity supports simultaneously in a fragment shader for reading. (Read Only)</para>
		/// </summary>
		public  int maxComputeBufferInputsFragment { get; }

		/// <summary>
		///   <para>Determines how many compute buffers Unity supports simultaneously in a geometry shader for reading. (Read Only)</para>
		/// </summary>
		public  int maxComputeBufferInputsGeometry { get; }

		/// <summary>
		///   <para>Determines how many compute buffers Unity supports simultaneously in a domain shader for reading. (Read Only)</para>
		/// </summary>
		public  int maxComputeBufferInputsDomain { get; }

		/// <summary>
		///   <para>Determines how many compute buffers Unity supports simultaneously in a hull shader for reading. (Read Only)</para>
		/// </summary>
		public  int maxComputeBufferInputsHull { get; }

		/// <summary>
		///   <para>Determines how many compute buffers Unity supports simultaneously in a compute shader for reading. (Read Only)</para>
		/// </summary>
		public  int maxComputeBufferInputsCompute { get; }

		/// <summary>
		///   <para>The largest total number of invocations in a single local work group that can be dispatched to a compute shader (Read Only).</para>
		/// </summary>
		public  int maxComputeWorkGroupSize { get; }

		/// <summary>
		///   <para>The maximum number of work groups that a compute shader can use in X dimension (Read Only).</para>
		/// </summary>
		public  int maxComputeWorkGroupSizeX { get; }

		/// <summary>
		///   <para>The maximum number of work groups that a compute shader can use in Y dimension (Read Only).</para>
		/// </summary>
		public  int maxComputeWorkGroupSizeY { get; }

		/// <summary>
		///   <para>The maximum number of work groups that a compute shader can use in Z dimension (Read Only).</para>
		/// </summary>
		public  int maxComputeWorkGroupSizeZ { get; }

		/// <summary>
		///   <para>Returns true when the platform supports asynchronous compute queues and false if otherwise.</para>
		/// </summary>
		public  bool supportsAsyncCompute { get; }

		/// <summary>
		///   <para>Specifies whether the current platform supports the GPU Recorder or not. (Read Only).</para>
		/// </summary>
		public  bool supportsGpuRecorder { get; }

		/// <summary>
		///   <para>Returns true when the platform supports GraphicsFences, and false if otherwise.</para>
		/// </summary>
		public  bool supportsGraphicsFence { get; }

		/// <summary>
		///   <para>Returns true if asynchronous readback of GPU data is available for this device and false otherwise.</para>
		/// </summary>
		public  bool supportsAsyncGPUReadback { get; }

		/// <summary>
		///   <para>Checks if ray tracing is supported by the current configuration.</para>
		/// </summary>
		public  bool supportsRayTracing { get; }

		/// <summary>
		///   <para>Does the current renderer support binding constant buffers directly? (Read Only)</para>
		/// </summary>
		public  bool supportsSetConstantBuffer { get; }

		/// <summary>
		///   <para>Minimum buffer offset (in bytes) when binding a constant buffer using Shader.SetConstantBuffer or Material.SetConstantBuffer.</para>
		/// </summary>
		public  int constantBufferOffsetAlignment { get; }

		/// <summary>
		///   <para>Returns true if the GPU supports partial mipmap chains (Read Only).</para>
		/// </summary>
		public  bool hasMipMaxLevel { get; }

		/// <summary>
		///   <para>Is streaming of texture mip maps supported? (Read Only)</para>
		/// </summary>
		public  bool supportsMipStreaming { get; }

		/// <summary>
		///   <para>True if the Graphics API takes RenderBufferLoadAction and RenderBufferStoreAction into account, false if otherwise.</para>
		/// </summary>
		public  bool usesLoadStoreActions { get; }

		/// <summary>
		///   <para>Returns a bitwise combination of HDRDisplaySupportFlags describing the support for HDR displays on the system.</para>
		/// </summary>
		public  HDRDisplaySupportFlags hdrDisplaySupportFlags { get; }

		/// <summary>
		///   <para>This property is true if the graphics API of the target build platform takes RenderBufferStoreAction.StoreAndResolve into account, false if otherwise.</para>
		/// </summary>
		public  bool supportsStoreAndResolveAction { get; }

		/// <summary>
		///   <para>Is render texture format supported?</para>
		/// </summary>
		/// <param name="format">The format to look up.</param>
		/// <returns>
		///   <para>True if the format is supported.</para>
		/// </returns>
		public  bool SupportsRenderTextureFormat(RenderTextureFormat format);

		/// <summary>
		///   <para>Is blending supported on render texture format?</para>
		/// </summary>
		/// <param name="format">The format to look up.</param>
		/// <returns>
		///   <para>True if blending is supported on the given format.</para>
		/// </returns>
		public  bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format);

		/// <summary>
		///   <para>Is texture format supported on this device?</para>
		/// </summary>
		/// <param name="format">The TextureFormat format to look up.</param>
		/// <returns>
		///   <para>True if the format is supported.</para>
		/// </returns>
		public  bool SupportsTextureFormat(TextureFormat format);

		/// <summary>
		///   <para>Indicates whether the given combination of a vertex attribute format and dimension is supported on this device.</para>
		/// </summary>
		/// <param name="format">The VertexAttributeFormat format to look up.</param>
		/// <param name="dimension">The dimension of vertex data to check for.</param>
		/// <returns>
		///   <para>True if the format with the given dimension is supported.</para>
		/// </returns>
		public  bool SupportsVertexAttributeFormat(VertexAttributeFormat format, int dimension);

		public  bool IsFormatSupported(GraphicsFormat format, FormatUsage usage);

		public  GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage);

		/// <summary>
		///   <para>Returns the platform-specific GraphicsFormat that is associated with the DefaultFormat.</para>
		/// </summary>
		/// <param name="format">The DefaultFormat format to look up.</param>
		public GraphicsFormat GetGraphicsFormat(DefaultFormat format);

		/// <summary>
		///   <para>Checks if the target platform supports the MSAA samples count in the RenderTextureDescriptor argument.</para>
		/// </summary>
		/// <param name="desc">The RenderTextureDescriptor to check.</param>
		/// <returns>
		///   <para>If the target platform supports the given MSAA samples count of RenderTextureDescriptor, returns the given MSAA samples count. Otherwise returns a lower fallback MSAA samples count value that the target platform supports.</para>
		/// </returns>
		public int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc);
	}
}