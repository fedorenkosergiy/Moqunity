using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Moqunity.Fake.UnityEngine
{
	public partial class FakeSystemInfo : global::Moqunity.Abstract.UnityEngine.SystemInfo
	{
		public virtual string unsupportedIdentifier => throw new NotImplementedException();

		public virtual float batteryLevel => throw new NotImplementedException();

		public virtual BatteryStatus batteryStatus => throw new NotImplementedException();

		public virtual string operatingSystem => throw new NotImplementedException();

		public virtual OperatingSystemFamily operatingSystemFamily => throw new NotImplementedException();

		public virtual string processorType => throw new NotImplementedException();

		public virtual int processorFrequency => throw new NotImplementedException();

		public virtual int processorCount => throw new NotImplementedException();

		public virtual int systemMemorySize => throw new NotImplementedException();

		public virtual string deviceUniqueIdentifier => throw new NotImplementedException();

		public virtual string deviceName => throw new NotImplementedException();

		public virtual string deviceModel => throw new NotImplementedException();

		public virtual bool supportsAccelerometer => throw new NotImplementedException();

		public virtual bool supportsGyroscope => throw new NotImplementedException();

		public virtual bool supportsLocationService => throw new NotImplementedException();

		public virtual bool supportsVibration => throw new NotImplementedException();

		public virtual bool supportsAudio => throw new NotImplementedException();

		public virtual DeviceType deviceType => throw new NotImplementedException();

		public virtual int graphicsMemorySize => throw new NotImplementedException();

		public virtual string graphicsDeviceName => throw new NotImplementedException();

		public virtual string graphicsDeviceVendor => throw new NotImplementedException();

		public virtual int graphicsDeviceID => throw new NotImplementedException();

		public virtual int graphicsDeviceVendorID => throw new NotImplementedException();

		public virtual GraphicsDeviceType graphicsDeviceType => throw new NotImplementedException();

		public virtual bool graphicsUVStartsAtTop => throw new NotImplementedException();

		public virtual string graphicsDeviceVersion => throw new NotImplementedException();

		public virtual int graphicsShaderLevel => throw new NotImplementedException();

		public virtual bool graphicsMultiThreaded => throw new NotImplementedException();

		public virtual RenderingThreadingMode renderingThreadingMode => throw new NotImplementedException();

		public virtual bool hasHiddenSurfaceRemovalOnGPU => throw new NotImplementedException();

		public virtual bool hasDynamicUniformArrayIndexingInFragmentShaders => throw new NotImplementedException();

		public virtual bool supportsShadows => throw new NotImplementedException();

		public virtual bool supportsRawShadowDepthSampling => throw new NotImplementedException();

		public virtual bool supportsMotionVectors => throw new NotImplementedException();

		public virtual bool supports3DTextures => throw new NotImplementedException();

		public virtual bool supportsCompressed3DTextures => throw new NotImplementedException();

		public virtual bool supports2DArrayTextures => throw new NotImplementedException();

		public virtual bool supports3DRenderTextures => throw new NotImplementedException();

		public virtual bool supportsCubemapArrayTextures => throw new NotImplementedException();

		public virtual CopyTextureSupport copyTextureSupport => throw new NotImplementedException();

		public virtual bool supportsComputeShaders => throw new NotImplementedException();

		public virtual bool supportsConservativeRaster => throw new NotImplementedException();

		public virtual bool supportsMultiview => throw new NotImplementedException();

		public virtual bool supportsGeometryShaders => throw new NotImplementedException();

		public virtual bool supportsTessellationShaders => throw new NotImplementedException();

		public virtual bool supportsRenderTargetArrayIndexFromVertexShader => throw new NotImplementedException();

		public virtual bool supportsInstancing => throw new NotImplementedException();

		public virtual bool supportsHardwareQuadTopology => throw new NotImplementedException();

		public virtual bool supports32bitsIndexBuffer => throw new NotImplementedException();

		public virtual bool supportsSparseTextures => throw new NotImplementedException();

		public virtual int supportedRenderTargetCount => throw new NotImplementedException();

		public virtual bool supportsSeparatedRenderTargetsBlend => throw new NotImplementedException();

		public virtual int supportedRandomWriteTargetCount => throw new NotImplementedException();

		public virtual int supportsMultisampledTextures => throw new NotImplementedException();

		public virtual bool supportsMultisampled2DArrayTextures => throw new NotImplementedException();

		public virtual bool supportsMultisampleAutoResolve => throw new NotImplementedException();

		public virtual int supportsTextureWrapMirrorOnce => throw new NotImplementedException();

		public virtual bool usesReversedZBuffer => throw new NotImplementedException();

		public virtual NPOTSupport npotSupport => throw new NotImplementedException();

		public virtual int maxTextureSize => throw new NotImplementedException();

		public virtual int maxCubemapSize => throw new NotImplementedException();

		public virtual int maxComputeBufferInputsVertex => throw new NotImplementedException();

		public virtual int maxComputeBufferInputsFragment => throw new NotImplementedException();

		public virtual int maxComputeBufferInputsGeometry => throw new NotImplementedException();

		public virtual int maxComputeBufferInputsDomain => throw new NotImplementedException();

		public virtual int maxComputeBufferInputsHull => throw new NotImplementedException();

		public virtual int maxComputeBufferInputsCompute => throw new NotImplementedException();

		public virtual int maxComputeWorkGroupSize => throw new NotImplementedException();

		public virtual int maxComputeWorkGroupSizeX => throw new NotImplementedException();

		public virtual int maxComputeWorkGroupSizeY => throw new NotImplementedException();

		public virtual int maxComputeWorkGroupSizeZ => throw new NotImplementedException();

		public virtual bool supportsAsyncCompute => throw new NotImplementedException();

		public virtual bool supportsGpuRecorder => throw new NotImplementedException();

		public virtual bool supportsGraphicsFence => throw new NotImplementedException();

		public virtual bool supportsAsyncGPUReadback => throw new NotImplementedException();

		public virtual bool supportsRayTracing => throw new NotImplementedException();

		public virtual bool supportsSetConstantBuffer => throw new NotImplementedException();

		public virtual int constantBufferOffsetAlignment => throw new NotImplementedException();

		public virtual bool hasMipMaxLevel => throw new NotImplementedException();

		public virtual bool supportsMipStreaming => throw new NotImplementedException();

		public virtual bool usesLoadStoreActions => throw new NotImplementedException();

		public virtual HDRDisplaySupportFlags hdrDisplaySupportFlags => throw new NotImplementedException();

		public virtual bool supportsStoreAndResolveAction => throw new NotImplementedException();

		public virtual GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
		{
			throw new NotImplementedException();
		}

		public virtual GraphicsFormat GetGraphicsFormat(DefaultFormat format)
		{
			throw new NotImplementedException();
		}

		public virtual int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			throw new NotImplementedException();
		}

		public virtual bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
		{
			throw new NotImplementedException();
		}

		public virtual bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			throw new NotImplementedException();
		}

		public virtual bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			throw new NotImplementedException();
		}

		public virtual bool SupportsTextureFormat(TextureFormat format)
		{
			throw new NotImplementedException();
		}

		public virtual bool SupportsVertexAttributeFormat(VertexAttributeFormat format, int dimension)
		{
			throw new NotImplementedException();
		}
	}
}