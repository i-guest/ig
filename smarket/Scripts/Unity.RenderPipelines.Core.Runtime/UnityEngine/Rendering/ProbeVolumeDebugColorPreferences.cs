using System;

namespace UnityEngine.Rendering
{
	internal class ProbeVolumeDebugColorPreferences
	{
		internal static Func<Color> GetDetailSubdivisionColor;

		internal static Func<Color> GetMediumSubdivisionColor;

		internal static Func<Color> GetLowSubdivisionColor;

		internal static Func<Color> GetVeryLowSubdivisionColor;

		internal static Func<Color> GetSparseSubdivisionColor;

		internal static Func<Color> GetSparsestSubdivisionColor;

		internal static Color s_DetailSubdivision;

		internal static Color s_MediumSubdivision;

		internal static Color s_LowSubdivision;

		internal static Color s_VeryLowSubdivision;

		internal static Color s_SparseSubdivision;

		internal static Color s_SparsestSubdivision;

		static ProbeVolumeDebugColorPreferences()
		{
		}
	}
}
