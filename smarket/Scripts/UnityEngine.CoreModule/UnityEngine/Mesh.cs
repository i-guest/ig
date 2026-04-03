using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[ExcludeFromPreset]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	public sealed class Mesh : Object
	{
		[StaticAccessor("MeshDataBindings", StaticAccessorType.DoubleColon)]
		[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
		public struct MeshData
		{
			[NativeDisableUnsafePtrRestriction]
			internal IntPtr m_Ptr;
		}

		public IndexFormat indexFormat
		{
			get
			{
				return default(IndexFormat);
			}
			set
			{
			}
		}

		public GraphicsBuffer.Target vertexBufferTarget
		{
			get
			{
				return default(GraphicsBuffer.Target);
			}
			set
			{
			}
		}

		public GraphicsBuffer.Target indexBufferTarget
		{
			get
			{
				return default(GraphicsBuffer.Target);
			}
			set
			{
			}
		}

		public int blendShapeCount
		{
			[NativeMethod(Name = "GetBlendShapeChannelCount")]
			get
			{
				return 0;
			}
		}

		[NativeName("BindPosesFromScript")]
		public Matrix4x4[] bindposes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isReadable
		{
			[NativeMethod("GetIsReadable")]
			get
			{
				return false;
			}
		}

		internal bool canAccess
		{
			[NativeMethod("CanAccessFromScript")]
			get
			{
				return false;
			}
		}

		public int vertexCount
		{
			[NativeMethod("GetVertexCount")]
			get
			{
				return 0;
			}
		}

		public int subMeshCount
		{
			[NativeMethod(Name = "GetSubMeshCount")]
			get
			{
				return 0;
			}
			[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = true)]
			set
			{
			}
		}

		public Bounds bounds
		{
			get
			{
				return default(Bounds);
			}
			set
			{
			}
		}

		public Vector3[] vertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3[] normals
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector4[] tangents
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2[] uv
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2[] uv2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2[] uv3
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2[] uv4
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color[] colors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color32[] colors32
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int lodCount => 0;

		public int[] triangles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BoneWeight[] boneWeights
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[FreeFunction("MeshScripting::CreateMesh")]
		private static void Internal_Create([Writable] Mesh mono)
		{
		}

		[RequiredByNativeCode]
		public Mesh()
		{
		}

		[FreeFunction("MeshScripting::MeshFromInstanceId")]
		internal static Mesh FromInstanceID(EntityId id)
		{
			return null;
		}

		[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = true, ThrowsException = true)]
		public void SetIndexBufferParams(int indexCount, IndexFormat format)
		{
		}

		[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
		}

		[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
		}

		[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = true, ThrowsException = true)]
		private void SetVertexBufferParamsFromArray(int vertexCount, params VertexAttributeDescriptor[] attributes)
		{
		}

		[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferData", HasExplicitThis = true)]
		private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
		}

		[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = true)]
		private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
		}

		[FreeFunction(Name = "MeshScripting::GetIndexStart", HasExplicitThis = true)]
		private uint GetIndexStartImpl(int submesh, int meshlod)
		{
			return 0u;
		}

		[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = true)]
		private uint GetIndexCountImpl(int submesh, int meshlod)
		{
			return 0u;
		}

		[FreeFunction(Name = "MeshScripting::GetBaseVertex", HasExplicitThis = true)]
		private uint GetBaseVertexImpl(int submesh)
		{
			return 0u;
		}

		[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = true)]
		private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex, int meshlod)
		{
			return null;
		}

		[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = true)]
		private int[] GetIndicesImpl(int submesh, bool applyBaseVertex, int meshlod)
		{
			return null;
		}

		[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = true, ThrowsException = true)]
		private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex, int meshlod)
		{
		}

		[FreeFunction(Name = "SetMeshIndicesFromNativeArray", HasExplicitThis = true, ThrowsException = true)]
		private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex, int meshlod)
		{
		}

		[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = true)]
		private void PrintErrorCantAccessChannel(VertexAttribute ch)
		{
		}

		[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = true)]
		public bool HasVertexAttribute(VertexAttribute attr)
		{
			return false;
		}

		[FreeFunction(Name = "MeshScripting::GetChannelDimension", HasExplicitThis = true)]
		public int GetVertexAttributeDimension(VertexAttribute attr)
		{
			return 0;
		}

		[FreeFunction(Name = "MeshScripting::GetChannelFormat", HasExplicitThis = true)]
		public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr)
		{
			return default(VertexAttributeFormat);
		}

		[FreeFunction(Name = "MeshScripting::GetChannelStream", HasExplicitThis = true)]
		public int GetVertexAttributeStream(VertexAttribute attr)
		{
			return 0;
		}

		[FreeFunction(Name = "MeshScripting::GetChannelOffset", HasExplicitThis = true)]
		public int GetVertexAttributeOffset(VertexAttribute attr)
		{
			return 0;
		}

		[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = true)]
		private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		[FreeFunction(Name = "SetMeshComponentFromNativeArrayFromScript", HasExplicitThis = true)]
		private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = true)]
		private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim)
		{
			return null;
		}

		[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = true)]
		private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values)
		{
		}

		[FreeFunction(Name = "MeshScripting::GetVertexBufferStride", HasExplicitThis = true)]
		public int GetVertexBufferStride(int stream)
		{
			return 0;
		}

		[FreeFunction(Name = "MeshScripting::GetVertexBufferPtr", HasExplicitThis = true, ThrowsException = true)]
		private GraphicsBuffer GetVertexBufferImpl(int index)
		{
			return null;
		}

		[FreeFunction(Name = "MeshScripting::GetIndexBufferPtr", HasExplicitThis = true, ThrowsException = true)]
		private GraphicsBuffer GetIndexBufferImpl()
		{
			return null;
		}

		[FreeFunction(Name = "MeshScripting::ClearBlendShapes", HasExplicitThis = true)]
		public void ClearBlendShapes()
		{
		}

		[FreeFunction(Name = "MeshScripting::GetBlendShapeName", HasExplicitThis = true, ThrowsException = true)]
		public string GetBlendShapeName(int shapeIndex)
		{
			return null;
		}

		[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameCount", HasExplicitThis = true, ThrowsException = true)]
		public int GetBlendShapeFrameCount(int shapeIndex)
		{
			return 0;
		}

		[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameWeight", HasExplicitThis = true, ThrowsException = true)]
		public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex)
		{
			return 0f;
		}

		[FreeFunction(Name = "GetBlendShapeFrameVerticesFromScript", HasExplicitThis = true, ThrowsException = true)]
		public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents)
		{
		}

		[FreeFunction(Name = "AddBlendShapeFrameFromScript", HasExplicitThis = true, ThrowsException = true)]
		public void AddBlendShapeFrame(string shapeName, float frameWeight, ReadOnlySpan<Vector3> deltaVertices, ReadOnlySpan<Vector3> deltaNormals, ReadOnlySpan<Vector3> deltaTangents)
		{
		}

		public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents)
		{
		}

		[FreeFunction(Name = "MeshScripting::GetBoneWeights", HasExplicitThis = true)]
		private BoneWeight[] GetBoneWeightsImpl()
		{
			return null;
		}

		[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = true)]
		private void SetBoneWeightsImpl(BoneWeight[] weights)
		{
		}

		[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = true, ThrowsException = true)]
		public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
		}

		[FreeFunction("MeshScripting::GetSubMesh", HasExplicitThis = true, ThrowsException = true)]
		public SubMeshDescriptor GetSubMesh(int index)
		{
			return default(SubMeshDescriptor);
		}

		[FreeFunction("MeshScripting::GetLodCount", HasExplicitThis = true)]
		private int GetLodCount()
		{
			return 0;
		}

		[NativeMethod("Clear")]
		private void ClearImpl(bool keepVertexLayout)
		{
		}

		[NativeMethod("RecalculateBounds")]
		private void RecalculateBoundsImpl(MeshUpdateFlags flags)
		{
		}

		[NativeMethod("RecalculateNormals")]
		private void RecalculateNormalsImpl(MeshUpdateFlags flags)
		{
		}

		[NativeMethod("RecalculateTangents")]
		private void RecalculateTangentsImpl(MeshUpdateFlags flags)
		{
		}

		[NativeMethod("MarkDynamic")]
		private void MarkDynamicImpl()
		{
		}

		[NativeMethod("UploadMeshData")]
		private void UploadMeshDataImpl(bool markNoLongerReadable)
		{
		}

		[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = true, ThrowsException = true, HasExplicitThis = true)]
		private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
		{
		}

		internal static VertexAttribute GetUVChannel(int uvIndex)
		{
			return default(VertexAttribute);
		}

		internal static int DefaultDimensionForChannel(VertexAttribute channel)
		{
			return 0;
		}

		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim)
		{
			return null;
		}

		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel)
		{
			return null;
		}

		private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
		}

		private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
		}

		private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
		}

		private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
		}

		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim)
		{
		}

		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType)
		{
		}

		public void SetVertices(List<Vector3> inVertices)
		{
		}

		[ExcludeFromDocs]
		public void SetVertices(List<Vector3> inVertices, int start, int length)
		{
		}

		public void SetVertices(List<Vector3> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void SetVertices<T>(NativeArray<T> inVertices) where T : struct
		{
		}

		[ExcludeFromDocs]
		public void SetVertices<T>(NativeArray<T> inVertices, int start, int length) where T : struct
		{
		}

		public void SetVertices<T>(NativeArray<T> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags) where T : struct
		{
		}

		public void SetNormals(List<Vector3> inNormals)
		{
		}

		[ExcludeFromDocs]
		public void SetNormals(List<Vector3> inNormals, int start, int length)
		{
		}

		public void SetNormals(List<Vector3> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void SetNormals<T>(NativeArray<T> inNormals) where T : struct
		{
		}

		[ExcludeFromDocs]
		public void SetNormals<T>(NativeArray<T> inNormals, int start, int length) where T : struct
		{
		}

		public void SetNormals<T>(NativeArray<T> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags) where T : struct
		{
		}

		public void SetTangents(List<Vector4> inTangents)
		{
		}

		[ExcludeFromDocs]
		public void SetTangents(List<Vector4> inTangents, int start, int length)
		{
		}

		public void SetTangents(List<Vector4> inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void SetColors(List<Color> inColors)
		{
		}

		[ExcludeFromDocs]
		public void SetColors(List<Color> inColors, int start, int length)
		{
		}

		public void SetColors(List<Color> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void SetColors(List<Color32> inColors)
		{
		}

		[ExcludeFromDocs]
		public void SetColors(List<Color32> inColors, int start, int length)
		{
		}

		public void SetColors(List<Color32> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags)
		{
		}

		public void SetUVs(int channel, List<Vector2> uvs)
		{
		}

		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[ExcludeFromDocs]
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length)
		{
		}

		public void SetUVs(int channel, List<Vector2> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		[ExcludeFromDocs]
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
		}

		public void SetUVs(int channel, List<Vector4> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags)
		{
		}

		public void SetUVs(int channel, Vector4[] uvs)
		{
		}

		[ExcludeFromDocs]
		public void SetUVs(int channel, Vector4[] uvs, int start, int length)
		{
		}

		public void SetUVs(int channel, Vector4[] uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void SetUVs<T>(int channel, NativeArray<T> uvs) where T : struct
		{
		}

		[ExcludeFromDocs]
		public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length) where T : struct
		{
		}

		public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags) where T : struct
		{
		}

		private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
		}

		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		public void SetVertexBufferParams(int vertexCount, params VertexAttributeDescriptor[] attributes)
		{
		}

		public void SetVertexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
		{
		}

		public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
		{
		}

		public GraphicsBuffer GetVertexBuffer(int index)
		{
			return null;
		}

		public GraphicsBuffer GetIndexBuffer()
		{
			return null;
		}

		private void PrintErrorCantAccessIndices()
		{
		}

		private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			return false;
		}

		private bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			return false;
		}

		private bool CheckCanAccessSubmeshIndices(int submesh)
		{
			return false;
		}

		public int[] GetTriangles(int submesh)
		{
			return null;
		}

		public int[] GetTriangles(int submesh, [DefaultValue("true")] bool applyBaseVertex)
		{
			return null;
		}

		public int[] GetTriangles(int submesh, int meshLod, bool applyBaseVertex)
		{
			return null;
		}

		[ExcludeFromDocs]
		public int[] GetIndices(int submesh)
		{
			return null;
		}

		public int[] GetIndices(int submesh, int meshLod, bool applyBaseVertex = true)
		{
			return null;
		}

		public void SetIndexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
		{
		}

		public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
		{
		}

		public uint GetIndexStart(int submesh)
		{
			return 0u;
		}

		public uint GetIndexCount(int submesh)
		{
			return 0u;
		}

		public uint GetBaseVertex(int submesh)
		{
			return 0u;
		}

		private void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
		}

		private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex, int meshLod)
		{
		}

		[ExcludeFromDocs]
		public void SetTriangles(int[] triangles, int submesh)
		{
		}

		public void SetTriangles(int[] triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		[ExcludeFromDocs]
		public void SetTriangles(List<int> triangles, int submesh)
		{
		}

		public void SetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		[ExcludeFromDocs]
		public void SetIndices(int[] indices, MeshTopology topology, int submesh)
		{
		}

		[ExcludeFromDocs]
		public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds)
		{
		}

		public void SetIndices(int[] indices, MeshTopology topology, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetIndices<T>(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : struct
		{
		}

		public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : struct
		{
		}

		public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0) where T : struct
		{
		}

		public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, int meshLod, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		[ExcludeFromDocs]
		public void Clear()
		{
		}

		[ExcludeFromDocs]
		public void RecalculateBounds()
		{
		}

		[ExcludeFromDocs]
		public void RecalculateNormals()
		{
		}

		[ExcludeFromDocs]
		public void RecalculateTangents()
		{
		}

		public void RecalculateBounds([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void RecalculateNormals([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void RecalculateTangents([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void MarkDynamic()
		{
		}

		public void UploadMeshData(bool markNoLongerReadable)
		{
		}

		[ExcludeFromDocs]
		public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes)
		{
		}

		[ExcludeFromDocs]
		public void CombineMeshes(CombineInstance[] combine)
		{
		}

		private static IntPtr FromInstanceID_Injected([In] ref EntityId id)
		{
			return (IntPtr)0;
		}

		private static IndexFormat get_indexFormat_Injected(IntPtr _unity_self)
		{
			return default(IndexFormat);
		}

		private static void set_indexFormat_Injected(IntPtr _unity_self, IndexFormat value)
		{
		}

		private static void SetIndexBufferParams_Injected(IntPtr _unity_self, int indexCount, IndexFormat format)
		{
		}

		private static void InternalSetIndexBufferData_Injected(IntPtr _unity_self, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
		}

		private static void InternalSetIndexBufferDataFromArray_Injected(IntPtr _unity_self, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
		}

		private static void SetVertexBufferParamsFromArray_Injected(IntPtr _unity_self, int vertexCount, ref ManagedSpanWrapper attributes)
		{
		}

		private static void InternalSetVertexBufferData_Injected(IntPtr _unity_self, int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
		}

		private static void InternalSetVertexBufferDataFromArray_Injected(IntPtr _unity_self, int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags)
		{
		}

		private static uint GetIndexStartImpl_Injected(IntPtr _unity_self, int submesh, int meshlod)
		{
			return 0u;
		}

		private static uint GetIndexCountImpl_Injected(IntPtr _unity_self, int submesh, int meshlod)
		{
			return 0u;
		}

		private static uint GetBaseVertexImpl_Injected(IntPtr _unity_self, int submesh)
		{
			return 0u;
		}

		private static void GetTrianglesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, int meshlod, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void GetIndicesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, int meshlod, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void SetIndicesImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex, int meshlod)
		{
		}

		private static void SetIndicesNativeArrayImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex, int meshlod)
		{
		}

		private static void PrintErrorCantAccessChannel_Injected(IntPtr _unity_self, VertexAttribute ch)
		{
		}

		private static bool HasVertexAttribute_Injected(IntPtr _unity_self, VertexAttribute attr)
		{
			return false;
		}

		private static int GetVertexAttributeDimension_Injected(IntPtr _unity_self, VertexAttribute attr)
		{
			return 0;
		}

		private static VertexAttributeFormat GetVertexAttributeFormat_Injected(IntPtr _unity_self, VertexAttribute attr)
		{
			return default(VertexAttributeFormat);
		}

		private static int GetVertexAttributeStream_Injected(IntPtr _unity_self, VertexAttribute attr)
		{
			return 0;
		}

		private static int GetVertexAttributeOffset_Injected(IntPtr _unity_self, VertexAttribute attr)
		{
			return 0;
		}

		private static void SetArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		private static void SetNativeArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		private static Array GetAllocArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim)
		{
			return null;
		}

		private static void GetArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values)
		{
		}

		private static int GetVertexBufferStride_Injected(IntPtr _unity_self, int stream)
		{
			return 0;
		}

		private static IntPtr GetVertexBufferImpl_Injected(IntPtr _unity_self, int index)
		{
			return (IntPtr)0;
		}

		private static IntPtr GetIndexBufferImpl_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static GraphicsBuffer.Target get_vertexBufferTarget_Injected(IntPtr _unity_self)
		{
			return default(GraphicsBuffer.Target);
		}

		private static void set_vertexBufferTarget_Injected(IntPtr _unity_self, GraphicsBuffer.Target value)
		{
		}

		private static GraphicsBuffer.Target get_indexBufferTarget_Injected(IntPtr _unity_self)
		{
			return default(GraphicsBuffer.Target);
		}

		private static void set_indexBufferTarget_Injected(IntPtr _unity_self, GraphicsBuffer.Target value)
		{
		}

		private static int get_blendShapeCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void ClearBlendShapes_Injected(IntPtr _unity_self)
		{
		}

		private static void GetBlendShapeName_Injected(IntPtr _unity_self, int shapeIndex, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static int GetBlendShapeFrameCount_Injected(IntPtr _unity_self, int shapeIndex)
		{
			return 0;
		}

		private static float GetBlendShapeFrameWeight_Injected(IntPtr _unity_self, int shapeIndex, int frameIndex)
		{
			return 0f;
		}

		private static void GetBlendShapeFrameVertices_Injected(IntPtr _unity_self, int shapeIndex, int frameIndex, ref ManagedSpanWrapper deltaVertices, ref ManagedSpanWrapper deltaNormals, ref ManagedSpanWrapper deltaTangents)
		{
		}

		private static void AddBlendShapeFrame_Injected(IntPtr _unity_self, ref ManagedSpanWrapper shapeName, float frameWeight, ref ManagedSpanWrapper deltaVertices, ref ManagedSpanWrapper deltaNormals, ref ManagedSpanWrapper deltaTangents)
		{
		}

		private static void GetBoneWeightsImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void SetBoneWeightsImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper weights)
		{
		}

		private static void get_bindposes_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void set_bindposes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static bool get_isReadable_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_canAccess_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static int get_vertexCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_subMeshCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_subMeshCount_Injected(IntPtr _unity_self, int value)
		{
		}

		private static void SetSubMesh_Injected(IntPtr _unity_self, int index, [In] ref SubMeshDescriptor desc, MeshUpdateFlags flags)
		{
		}

		private static void GetSubMesh_Injected(IntPtr _unity_self, int index, out SubMeshDescriptor ret)
		{
			ret = default(SubMeshDescriptor);
		}

		private static int GetLodCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret)
		{
			ret = default(Bounds);
		}

		private static void set_bounds_Injected(IntPtr _unity_self, [In] ref Bounds value)
		{
		}

		private static void ClearImpl_Injected(IntPtr _unity_self, bool keepVertexLayout)
		{
		}

		private static void RecalculateBoundsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags)
		{
		}

		private static void RecalculateNormalsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags)
		{
		}

		private static void RecalculateTangentsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags)
		{
		}

		private static void MarkDynamicImpl_Injected(IntPtr _unity_self)
		{
		}

		private static void UploadMeshDataImpl_Injected(IntPtr _unity_self, bool markNoLongerReadable)
		{
		}

		private static void CombineMeshesImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
		{
		}
	}
}
