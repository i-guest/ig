using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine.Bindings;
using UnityEngine.Pool;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem
	{
		[Flags]
		private enum TransitionState
		{
			None = 0,
			Running = 1,
			Started = 2,
			Ended = 4,
			Canceled = 8
		}

		private struct AnimationDataSet<TTimingData, TStyleData>
		{
			public VisualElement[] elements;

			public StylePropertyId[] properties;

			public TTimingData[] timing;

			public TStyleData[] style;

			public int count;

			private Dictionary<ElementPropertyPair, int> indices;

			private int capacity
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			private void LocalInit()
			{
			}

			public static AnimationDataSet<TTimingData, TStyleData> Create()
			{
				return default(AnimationDataSet<TTimingData, TStyleData>);
			}

			public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index)
			{
				index = default(int);
				return false;
			}

			public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData)
			{
			}

			public void Remove(int cancelledIndex)
			{
			}

			public void Replace(int index, TTimingData timingData, TStyleData styleData)
			{
			}

			public void RemoveAll(VisualElement ve)
			{
			}

			public void RemoveAll()
			{
			}

			public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties)
			{
			}
		}

		private struct ElementPropertyPair
		{
			private class EqualityComparer : IEqualityComparer<ElementPropertyPair>
			{
				public bool Equals(ElementPropertyPair x, ElementPropertyPair y)
				{
					return false;
				}

				public int GetHashCode(ElementPropertyPair obj)
				{
					return 0;
				}
			}

			public static readonly IEqualityComparer<ElementPropertyPair> Comparer;

			public readonly VisualElement element;

			public readonly StylePropertyId property;

			public ElementPropertyPair(VisualElement element, StylePropertyId property)
			{
				this.element = null;
				this.property = default(StylePropertyId);
			}
		}

		private abstract class Values
		{
			public abstract void CancelAllAnimations();

			public abstract void CancelAllAnimations(VisualElement ve);

			public abstract void CancelAnimation(VisualElement ve, StylePropertyId id);

			public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id);

			public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds);

			public abstract void Update(double currentTime);

			protected abstract void UpdateValues();

			protected abstract void UpdateComputedStyle();

			protected abstract void UpdateComputedStyle(int i);
		}

		private abstract class Values<T> : Values
		{
			private class TransitionEventsFrameState
			{
				private static readonly UnityEngine.Pool.ObjectPool<Queue<EventBase>> k_EventQueuePool;

				public readonly Dictionary<ElementPropertyPair, TransitionState> elementPropertyStateDelta;

				public readonly Dictionary<ElementPropertyPair, Queue<EventBase>> elementPropertyQueuedEvents;

				public IPanel panel;

				private int m_ChangesCount;

				public static Queue<EventBase> GetPooledQueue()
				{
					return null;
				}

				public void RegisterChange()
				{
				}

				public void UnregisterChange()
				{
				}

				public bool StateChanged()
				{
					return false;
				}

				public void Clear()
				{
				}
			}

			public struct TimingData
			{
				public double startTime;

				public float duration;

				public Func<float, float> easingCurve;

				public float easedProgress;

				public float reversingShorteningFactor;

				public bool isStarted;

				public float delay;
			}

			public struct StyleData
			{
				public T startValue;

				public T endValue;

				public T reversingAdjustedStartValue;

				public T currentValue;
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			public struct EmptyData
			{
				public static EmptyData Default;
			}

			private double m_CurrentTime;

			private TransitionEventsFrameState m_CurrentFrameEventsState;

			private TransitionEventsFrameState m_NextFrameEventsState;

			public AnimationDataSet<TimingData, StyleData> running;

			public AnimationDataSet<EmptyData, T> completed;

			public bool isEmpty => false;

			public abstract Func<T, T, bool> SameFunc { get; }

			protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b)
			{
				return false;
			}

			protected virtual T Copy(T value)
			{
				return default(T);
			}

			private void SwapFrameStates()
			{
			}

			private void QueueEvent(EventBase evt, ElementPropertyPair epp)
			{
			}

			private void ClearEventQueue(ElementPropertyPair epp)
			{
			}

			private void QueueTransitionRunEvent(VisualElement ve, int runningIndex)
			{
			}

			private void QueueTransitionStartEvent(VisualElement ve, int runningIndex)
			{
			}

			private void QueueTransitionEndEvent(VisualElement ve, int runningIndex)
			{
			}

			private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, double panelElapsed)
			{
			}

			private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, double panelElapsed)
			{
			}

			public sealed override void CancelAllAnimations()
			{
			}

			public sealed override void CancelAllAnimations(VisualElement ve)
			{
			}

			public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id)
			{
			}

			public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id)
			{
			}

			public sealed override void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds)
			{
			}

			private float ComputeReversingShorteningFactor(int oldIndex)
			{
				return 0f;
			}

			private float ComputeReversingDuration(float newTransitionDuration, float newReversingShorteningFactor)
			{
				return 0f;
			}

			private float ComputeReversingDelay(float delay, float newReversingShorteningFactor)
			{
				return 0f;
			}

			public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, float duration, float delay, Func<float, float> easingCurve, double currentTime)
			{
				return false;
			}

			private void ForceComputedStyleEndValue(int runningIndex)
			{
			}

			public sealed override void Update(double currentTime)
			{
			}

			private void ProcessEventQueue()
			{
			}

			private void UpdateProgress(double currentTime)
			{
			}
		}

		private class ValuesFloat : Values<float>
		{
			public override Func<float, float, bool> SameFunc { get; }

			private static bool IsSame(float a, float b)
			{
				return false;
			}

			private static void Lerp(float a, float b, ref float result, float t)
			{
			}

			protected sealed override void UpdateValues()
			{
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesInt : Values<int>
		{
			public override Func<int, int, bool> SameFunc { get; }

			private static bool IsSame(int a, int b)
			{
				return false;
			}

			private static int Lerp(int a, int b, float t)
			{
				return 0;
			}

			protected sealed override void UpdateValues()
			{
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesLength : Values<Length>
		{
			public override Func<Length, Length, bool> SameFunc { get; }

			private static bool IsSame(Length a, Length b)
			{
				return false;
			}

			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b)
			{
				return false;
			}

			internal static Length Lerp(Length a, Length b, float t)
			{
				return default(Length);
			}

			protected sealed override void UpdateValues()
			{
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesColor : Values<Color>
		{
			public override Func<Color, Color, bool> SameFunc { get; }

			private static bool IsSame(Color c, Color d)
			{
				return false;
			}

			private static Color Lerp(Color a, Color b, float t)
			{
				return default(Color);
			}

			protected sealed override void UpdateValues()
			{
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private abstract class ValuesDiscrete<T> : Values<T>
		{
			public override Func<T, T, bool> SameFunc { get; }

			private static bool IsSame(T a, T b)
			{
				return false;
			}

			private static T Lerp(T a, T b, float t)
			{
				return default(T);
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private class ValuesEnum : ValuesDiscrete<int>
		{
			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesBackground : ValuesDiscrete<Background>
		{
			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesFontDefinition : ValuesDiscrete<FontDefinition>
		{
			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesFont : ValuesDiscrete<Font>
		{
			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesTextShadow : Values<TextShadow>
		{
			public override Func<TextShadow, TextShadow, bool> SameFunc { get; }

			private static bool IsSame(TextShadow a, TextShadow b)
			{
				return false;
			}

			private static TextShadow Lerp(TextShadow a, TextShadow b, float t)
			{
				return default(TextShadow);
			}

			protected sealed override void UpdateValues()
			{
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesScale : Values<Scale>
		{
			public override Func<Scale, Scale, bool> SameFunc { get; }

			private static bool IsSame(Scale a, Scale b)
			{
				return false;
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			private static Scale Lerp(Scale a, Scale b, float t)
			{
				return default(Scale);
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private class ValuesRotate : Values<Rotate>
		{
			public override Func<Rotate, Rotate, bool> SameFunc { get; }

			private static bool IsSame(Rotate a, Rotate b)
			{
				return false;
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			private static Rotate Lerp(Rotate a, Rotate b, float t)
			{
				return default(Rotate);
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private class ValuesRatio : Values<Ratio>
		{
			public override Func<Ratio, Ratio, bool> SameFunc { get; }

			private static bool IsSame(Ratio a, Ratio b)
			{
				return false;
			}

			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Ratio a, ref Ratio b)
			{
				return false;
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			private static Ratio Lerp(Ratio a, Ratio b, float t)
			{
				return default(Ratio);
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private class ValuesTranslate : Values<Translate>
		{
			public override Func<Translate, Translate, bool> SameFunc { get; }

			private static bool IsSame(Translate a, Translate b)
			{
				return false;
			}

			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b)
			{
				return false;
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			private static Translate Lerp(Translate a, Translate b, float t)
			{
				return default(Translate);
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private class ValuesTransformOrigin : Values<TransformOrigin>
		{
			public override Func<TransformOrigin, TransformOrigin, bool> SameFunc { get; }

			private static bool IsSame(TransformOrigin a, TransformOrigin b)
			{
				return false;
			}

			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b)
			{
				return false;
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t)
			{
				return default(TransformOrigin);
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private class ValuesBackgroundPosition : ValuesDiscrete<BackgroundPosition>
		{
			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesBackgroundRepeat : ValuesDiscrete<BackgroundRepeat>
		{
			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}
		}

		private class ValuesBackgroundSize : Values<BackgroundSize>
		{
			public override Func<BackgroundSize, BackgroundSize, bool> SameFunc { get; }

			private static bool IsSame(BackgroundSize a, BackgroundSize b)
			{
				return false;
			}

			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b)
			{
				return false;
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t)
			{
				return default(BackgroundSize);
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private class ValuesListFilterFunction : Values<List<FilterFunction>>
		{
			public override Func<List<FilterFunction>, List<FilterFunction>, bool> SameFunc { get; }

			protected override List<FilterFunction> Copy(List<FilterFunction> value)
			{
				return null;
			}

			private static bool IsSame(List<FilterFunction> a, List<FilterFunction> b)
			{
				return false;
			}

			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref List<FilterFunction> a, ref List<FilterFunction> b)
			{
				return false;
			}

			private static bool AreFilterDefinitionsCompatible(FilterFunctionDefinition filterDef1, FilterFunctionDefinition filterDef2)
			{
				return false;
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			private static FilterParameter LerpFilterParameters(FilterParameter a, FilterParameter b, float t)
			{
				return default(FilterParameter);
			}

			private static void Lerp(List<FilterFunction> a, List<FilterFunction> b, ref List<FilterFunction> result, float t)
			{
			}

			private static FilterFunction GetFunctionOrDefault(ref List<FilterFunction> srcList, ref List<FilterFunction> refList, int index)
			{
				return default(FilterFunction);
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private class ValuesMaterialDefinition : Values<MaterialDefinition>
		{
			public override Func<MaterialDefinition, MaterialDefinition, bool> SameFunc { get; }

			protected override MaterialDefinition Copy(MaterialDefinition value)
			{
				return default(MaterialDefinition);
			}

			private static bool IsSame(MaterialDefinition a, MaterialDefinition b)
			{
				return false;
			}

			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref MaterialDefinition a, ref MaterialDefinition b)
			{
				return false;
			}

			protected sealed override void UpdateComputedStyle()
			{
			}

			protected sealed override void UpdateComputedStyle(int i)
			{
			}

			private static MaterialPropertyValue LerpPropertyValues(MaterialPropertyValue a, MaterialPropertyValue b, float t)
			{
				return default(MaterialPropertyValue);
			}

			private static MaterialPropertyValue GetValueOrDefault(List<MaterialPropertyValue> srcList, List<MaterialPropertyValue> refList, int index)
			{
				return default(MaterialPropertyValue);
			}

			private static void Lerp(MaterialDefinition a, MaterialDefinition b, ref MaterialDefinition result, float t)
			{
			}

			protected sealed override void UpdateValues()
			{
			}
		}

		private double m_CurrentTime;

		private ValuesFloat m_Floats;

		private ValuesInt m_Ints;

		private ValuesLength m_Lengths;

		private ValuesColor m_Colors;

		private ValuesEnum m_Enums;

		private ValuesBackground m_Backgrounds;

		private ValuesFontDefinition m_FontDefinitions;

		private ValuesFont m_Fonts;

		private ValuesTextShadow m_TextShadows;

		private ValuesScale m_Scale;

		private ValuesRotate m_Rotate;

		private ValuesRatio m_Ratio;

		private ValuesTranslate m_Translate;

		private ValuesTransformOrigin m_TransformOrigin;

		private ValuesBackgroundPosition m_BackgroundPosition;

		private ValuesBackgroundRepeat m_BackgroundRepeat;

		private ValuesBackgroundSize m_BackgroundSize;

		private ValuesListFilterFunction m_FilterFunctions;

		private ValuesMaterialDefinition m_MaterialDefinition;

		private readonly List<Values> m_AllValues;

		private readonly Dictionary<StylePropertyId, Values> m_PropertyToValues;

		public StylePropertyAnimationSystem(BaseVisualElementPanel p)
		{
		}

		private T GetOrCreate<T>(ref T values) where T : new()
		{
			return default(T);
		}

		private bool StartTransition<T>(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, Values<T> values)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransitionEnum(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, Ratio startValue, Ratio endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, List<FilterFunction> startValue, List<FilterFunction> endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public bool StartTransition(VisualElement owner, StylePropertyId prop, MaterialDefinition startValue, MaterialDefinition endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve)
		{
			return false;
		}

		public void CancelAllAnimations()
		{
		}

		public void CancelAllAnimations(VisualElement owner)
		{
		}

		public void CancelAnimation(VisualElement owner, StylePropertyId id)
		{
		}

		public void UpdateAnimation(VisualElement owner, StylePropertyId id)
		{
		}

		public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds)
		{
		}

		private void UpdateTracking<T>(Values<T> values)
		{
		}

		private double CurrentTimeSeconds()
		{
			return 0.0;
		}

		public void Update(double updateTime)
		{
		}
	}
}
