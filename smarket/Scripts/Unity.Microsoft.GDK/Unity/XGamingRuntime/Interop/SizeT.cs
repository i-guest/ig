using System;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime.Interop
{
	[MovedFrom("Unity.GameCore.Interop")]
	public struct SizeT
	{
		private readonly UIntPtr value;

		public bool IsZero => false;

		public SizeT(int length)
		{
			value = (UIntPtr)0u;
		}

		public SizeT(uint length)
		{
			value = (UIntPtr)0u;
		}

		public SizeT(long length)
		{
			value = (UIntPtr)0u;
		}

		public SizeT(ulong length)
		{
			value = (UIntPtr)0u;
		}

		public uint ToUInt32()
		{
			return 0u;
		}

		public int ToInt32()
		{
			return 0;
		}

		public ulong ToUInt64()
		{
			return 0uL;
		}

		public long ToInt64()
		{
			return 0L;
		}
	}
}
