using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblTitleManagedStatistic
	{
		public string StatisticName { get; set; }

		public XblTitleManagedStatType StatisticType { get; set; }

		public double NumberValue { get; set; }

		public string StringValue { get; set; }

		internal XblTitleManagedStatistic(Unity.XGamingRuntime.Interop.XblTitleManagedStatistic interopStruct)
		{
		}

		internal XblTitleManagedStatistic(string statisticName, XblTitleManagedStatType statType, string stringValue, double numberValue)
		{
		}

		public XblTitleManagedStatistic()
		{
		}

		public XblTitleManagedStatistic(string statisticName, string statisticValue)
		{
		}

		public XblTitleManagedStatistic(string statisticName, double statisticValue)
		{
		}

		public static int Create(string statisticName, string statisticValue, out XblTitleManagedStatistic titleManagedStatistic)
		{
			titleManagedStatistic = null;
			return 0;
		}

		public static int Create(string statisticName, double statisticValue, out XblTitleManagedStatistic titleManagedStatistic)
		{
			titleManagedStatistic = null;
			return 0;
		}
	}
}
