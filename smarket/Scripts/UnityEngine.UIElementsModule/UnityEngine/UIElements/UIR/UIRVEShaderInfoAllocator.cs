namespace UnityEngine.UIElements.UIR
{
	internal class UIRVEShaderInfoAllocator
	{
		private BaseShaderInfoStorage m_Storage;

		private BitmapAllocator32 m_TransformAllocator;

		private BitmapAllocator32 m_ClipRectAllocator;

		private BitmapAllocator32 m_OpacityAllocator;

		private BitmapAllocator32 m_ColorAllocator;

		private BitmapAllocator32 m_TextSettingsAllocator;

		private bool m_StorageReallyCreated;

		private ColorSpace m_ColorSpace;

		private static readonly Vector2Int identityTransformTexel;

		private static readonly Vector2Int infiniteClipRectTexel;

		private static readonly Vector2Int fullOpacityTexel;

		private static readonly Vector2Int clearColorTexel;

		private static readonly Vector2Int defaultTextCoreSettingsTexel;

		private static readonly Matrix4x4 identityTransformValue;

		private static readonly Vector4 identityTransformRow0Value;

		private static readonly Vector4 identityTransformRow1Value;

		private static readonly Vector4 identityTransformRow2Value;

		private static readonly Vector4 infiniteClipRectValue;

		private static readonly Vector4 fullOpacityValue;

		private static readonly Vector4 clearColorValue;

		private static readonly TextCoreSettings defaultTextCoreSettingsValue;

		public static readonly BMPAlloc identityTransform;

		public static readonly BMPAlloc infiniteClipRect;

		public static readonly BMPAlloc fullOpacity;

		public static readonly BMPAlloc clearColor;

		public static readonly BMPAlloc defaultTextCoreSettings;

		private static int s_DefaultShaderInfoTextureRefCount;

		private static Texture2D s_DefaultShaderInfoTexture;

		private static int pageWidth => 0;

		private static int pageHeight => 0;

		public Texture atlas => null;

		private static void AcquireDefaultShaderInfoTexture()
		{
		}

		private static void ReleaseDefaultShaderInfoTexture()
		{
		}

		private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc)
		{
			return default(Vector2Int);
		}

		private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect)
		{
			return false;
		}

		public UIRVEShaderInfoAllocator(ColorSpace colorSpace)
		{
		}

		private void ReallyCreateStorage()
		{
		}

		public void Dispose()
		{
		}

		public void IssuePendingStorageChanges()
		{
		}

		public BMPAlloc AllocTransform()
		{
			return default(BMPAlloc);
		}

		public BMPAlloc AllocClipRect()
		{
			return default(BMPAlloc);
		}

		public BMPAlloc AllocOpacity()
		{
			return default(BMPAlloc);
		}

		public BMPAlloc AllocColor()
		{
			return default(BMPAlloc);
		}

		public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings)
		{
			return default(BMPAlloc);
		}

		public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform)
		{
		}

		public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect)
		{
		}

		public void SetOpacityValue(BMPAlloc alloc, float opacity)
		{
		}

		public void SetColorValue(BMPAlloc alloc, Color color)
		{
		}

		public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings)
		{
		}

		public void FreeTransform(BMPAlloc alloc)
		{
		}

		public void FreeClipRect(BMPAlloc alloc)
		{
		}

		public void FreeOpacity(BMPAlloc alloc)
		{
		}

		public void FreeColor(BMPAlloc alloc)
		{
		}

		public void FreeTextCoreSettings(BMPAlloc alloc)
		{
		}

		public Color32 TransformAllocToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		public Color32 ClipRectAllocToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		public Color32 OpacityAllocToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		public Color32 ColorAllocToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}

		public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc)
		{
			return default(Color32);
		}
	}
}
