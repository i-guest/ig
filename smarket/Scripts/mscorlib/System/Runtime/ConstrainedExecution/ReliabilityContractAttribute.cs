using System.Runtime.CompilerServices;

namespace System.Runtime.ConstrainedExecution
{
	/// <summary>Defines a contract for reliability between the author of some code, and the developers who have a dependency on that code.</summary>
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface, Inherited = false)]
	public sealed class ReliabilityContractAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly Consistency _003CConsistencyGuarantee_003Ek__BackingField;

		[CompilerGenerated]
		private readonly Cer _003CCer_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.ConstrainedExecution.ReliabilityContractAttribute" /> class with the specified <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> guarantee and <see cref="T:System.Runtime.ConstrainedExecution.Cer" /> value.</summary>
		/// <param name="consistencyGuarantee">One of the <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> values. </param>
		/// <param name="cer">One of the <see cref="T:System.Runtime.ConstrainedExecution.Cer" /> values.</param>
		public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
		{
		}
	}
}
