using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	public class UniversalCameraHistory : ICameraHistoryReadAccess, ICameraHistoryWriteAccess, IPerFrameHistoryAccessTracker, IDisposable
	{
		private static class TypeId<T>
		{
			public static uint value;
		}

		private struct Item
		{
			public ContextItem storage;

			public int requestVersion;

			public int writeVersion;

			public void Reset()
			{
			}
		}

		private const int k_ValidVersionCount = 2;

		private static uint s_TypeCount;

		private Item[] m_Items;

		private int m_Version;

		private BufferedRTHandleSystem m_HistoryTextures;

		public event ICameraHistoryReadAccess.HistoryRequestDelegate OnGatherHistoryRequests
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void RequestAccess<Type>() where Type : ContextItem
		{
		}

		public Type GetHistoryForRead<Type>() where Type : ContextItem
		{
			return null;
		}

		public bool IsAccessRequested<Type>() where Type : ContextItem
		{
			return false;
		}

		public Type GetHistoryForWrite<Type>() where Type : ContextItem, new()
		{
			return null;
		}

		public bool IsWritten<Type>() where Type : ContextItem
		{
			return false;
		}

		internal UniversalCameraHistory()
		{
		}

		public void Dispose()
		{
		}

		internal void GatherHistoryRequests()
		{
		}

		private bool IsValidRequest(int i)
		{
			return false;
		}

		private bool IsValid(int i)
		{
			return false;
		}

		internal void ReleaseUnusedHistory()
		{
		}

		internal void SwapAndSetReferenceSize(int cameraWidth, int cameraHeight)
		{
		}
	}
}
