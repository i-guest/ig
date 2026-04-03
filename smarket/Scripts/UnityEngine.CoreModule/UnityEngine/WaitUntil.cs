using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class WaitUntil : CustomYieldInstruction
	{
		private readonly Func<bool> m_Predicate;

		private readonly Action m_TimeoutCallback;

		private readonly WaitTimeoutMode m_TimeoutMode;

		private readonly double m_MaxExecutionTime;

		public override bool keepWaiting => false;

		public WaitUntil(Func<bool> predicate)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private double GetTime()
		{
			return 0.0;
		}
	}
}
