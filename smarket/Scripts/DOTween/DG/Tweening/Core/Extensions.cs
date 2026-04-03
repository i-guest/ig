using DG.Tweening.Core.Enums;

namespace DG.Tweening.Core
{
	public static class Extensions
	{
		public static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode)
		{
			return default(T);
		}

		public static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct
		{
			return null;
		}

		public static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t) where TPlugOptions : struct
		{
			return null;
		}
	}
}
