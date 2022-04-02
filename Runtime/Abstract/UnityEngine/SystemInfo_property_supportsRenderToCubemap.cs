﻿namespace Moqunity.Abstract.UnityEngine
{
	public partial interface SystemInfo
	{
		/// <summary>
		///   <para>Are cubemap render textures supported? (Read Only)</para>
		/// </summary>
#if UNITY_2019_1_OR_NEWER
		[global::System.Obsolete("supportsRenderToCubemap always returns true, no need to call it")]
#endif
		public  bool supportsRenderToCubemap { get; }
	}
}