using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the performance counter element in the <see langword="System.Net" /> configuration file that determines whether networking performance counters are enabled. This class cannot be inherited.</summary>
	public sealed class PerformanceCountersElement : ConfigurationElement
	{
		/// <summary>Gets or sets whether performance counters are enabled.</summary>
		/// <returns>
		///     <see langword="true" /> if performance counters are enabled; otherwise, <see langword="false" />.</returns>
		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Instantiates a <see cref="T:System.Net.Configuration.PerformanceCountersElement" /> object.</summary>
		public PerformanceCountersElement()
		{
		}
	}
}
