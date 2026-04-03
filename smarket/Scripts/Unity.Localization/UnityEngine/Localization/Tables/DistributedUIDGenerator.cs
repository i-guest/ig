using System;

namespace UnityEngine.Localization.Tables
{
	[Serializable]
	public class DistributedUIDGenerator : IKeyGenerator
	{
		private const int kMachineIdBits = 10;

		private const int kSequenceBits = 12;

		private static readonly int kMaxNodeId;

		private static readonly int kMaxSequence;

		public const string MachineIdPrefKey = "KeyGenerator-MachineId";

		[SerializeField]
		[HideInInspector]
		private long m_CustomEpoch;

		private long m_LastTimestamp;

		private long m_Sequence;

		private int m_MachineId;

		public long CustomEpoch => 0L;

		public int MachineId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public DistributedUIDGenerator()
		{
		}

		public DistributedUIDGenerator(long customEpoch)
		{
		}

		public long GetNextKey()
		{
			return 0L;
		}

		private long TimeStamp()
		{
			return 0L;
		}

		private static int GetMachineId()
		{
			return 0;
		}

		private long WaitNextMillis(long currentTimestamp)
		{
			return 0L;
		}
	}
}
