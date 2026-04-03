using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.SubsystemsImplementation
{
	[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
	public static class SubsystemDescriptorStore
	{
		private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors;

		private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors;

		private static List<SubsystemDescriptor> s_DeprecatedDescriptors;

		[RequiredByNativeCode]
		internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc)
		{
		}

		[RequiredByNativeCode]
		internal static void ClearManagedDescriptors()
		{
		}

		private static void ReportSingleSubsystemAnalytics(string id)
		{
		}

		public static void RegisterDescriptor(SubsystemDescriptorWithProvider descriptor)
		{
		}

		internal static void GetSubsystemDescriptors<T>(List<T> descriptors)
		{
		}

		private static void AddDescriptorSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo)
		{
		}

		internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList)
		{
		}

		internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor)
		{
		}

		private static void ReportSingleSubsystemAnalytics_Injected(ref ManagedSpanWrapper id)
		{
		}
	}
}
