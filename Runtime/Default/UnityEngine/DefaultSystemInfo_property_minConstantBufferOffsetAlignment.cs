namespace Moqunity.UnityEngine
{
	public partial class DefaultSystemInfo
	{
		/// <summary>
		///   <para>Obsolete - use SystemInfo.constantBufferOffsetAlignment instead. Minimum buffer offset (in bytes) when binding a constant buffer using Shader.SetConstantBuffer or Material.SetConstantBuffer.</para>
		/// </summary>
#if UNITY_2020_1_OR_NEWER
		[global::System.Obsolete("Use SystemInfo.constantBufferOffsetAlignment instead.")]
#endif
#if UNITY_2019_1_OR_NEWER
		public bool minConstantBufferOffsetAlignment => global::UnityEngine.SystemInfo.minConstantBufferOffsetAlignment;
#endif
	}
}