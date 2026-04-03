using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public class ContextContainer : IDisposable
	{
		private static class TypeId<T>
		{
			public static uint value;
		}

		private struct Item
		{
			public ContextItem storage;

			public bool isSet;
		}

		private Item[] m_Items;

		private List<uint> m_ActiveItemIndices;

		private static uint s_TypeCount;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Get<T>() where T : ContextItem, new()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Create<T>() where T : ContextItem, new()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T GetOrCreate<T>() where T : ContextItem, new()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains<T>() where T : ContextItem, new()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool Contains(uint typeId)
		{
			return false;
		}

		private T CreateAndGetData<T>(uint typeId) where T : ContextItem, new()
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
