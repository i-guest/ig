using Unity.Properties;

namespace UnityEngine.UIElements
{
	internal class BindingUpdater
	{
		private sealed class CastDataSourceVisitor : ConcreteTypeVisitor
		{
			public DataBinding Binding { get; set; }

			public BindingContext bindingContext { get; set; }

			public BindingResult result { get; set; }

			public void Reset()
			{
			}

			protected override void VisitContainer<TContainer>(ref TContainer container)
			{
			}
		}

		private sealed class UIPathVisitor : PathVisitor
		{
			public DataBinding binding { get; set; }

			public BindingUpdateStage direction { get; set; }

			public BindingContext bindingContext { get; set; }

			public BindingResult result { get; set; }

			public override void Reset()
			{
			}

			protected override void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
			{
			}
		}

		private static readonly CastDataSourceVisitor s_VisitDataSourceAsRootVisitor;

		private static readonly UIPathVisitor s_VisitDataSourceAtPathVisitor;

		public bool ShouldProcessBindingAtStage(Binding bindingObject, BindingUpdateStage stage, bool versionChanged, bool dirty)
		{
			return false;
		}

		private static bool ShouldProcessBindingAtStage(DataBinding dataBinding, BindingUpdateStage stage, bool versionChanged, bool dirty)
		{
			return false;
		}

		private bool ShouldProcessBindingAtStage(CustomBinding customBinding, BindingUpdateStage stage, bool versionChanged, bool dirty)
		{
			return false;
		}

		public BindingResult UpdateUI(in BindingContext context, Binding bindingObject)
		{
			return default(BindingResult);
		}

		public BindingResult UpdateSource(in BindingContext context, Binding bindingObject)
		{
			return default(BindingResult);
		}

		private BindingResult UpdateUI(in BindingContext context, DataBinding dataBinding)
		{
			return default(BindingResult);
		}

		private BindingResult UpdateUI(in BindingContext context, CustomBinding customBinding)
		{
			return default(BindingResult);
		}

		private BindingResult UpdateDataSource(in BindingContext context, DataBinding dataBinding)
		{
			return default(BindingResult);
		}

		private BindingResult UpdateDataSource(in BindingContext context, CustomBinding customBinding)
		{
			return default(BindingResult);
		}

		private static BindingResult TryUpdateUIWithNonContainer(in BindingContext context, DataBinding binding, object value)
		{
			return default(BindingResult);
		}

		private static (bool, VisitReturnCode, BindingResult) VisitRoot(DataBinding dataBinding, ref object container, in BindingContext context)
		{
			return default((bool, VisitReturnCode, BindingResult));
		}

		private static (bool, VisitReturnCode, VisitReturnCode, BindingResult) VisitAtPath<TContainer>(DataBinding dataBinding, BindingUpdateStage direction, ref TContainer container, in PropertyPath path, in BindingContext context)
		{
			return default((bool, VisitReturnCode, VisitReturnCode, BindingResult));
		}

		internal static string GetVisitationErrorString(VisitReturnCode returnCode, in BindingContext context)
		{
			return null;
		}

		internal static string GetExtractValueErrorString(VisitReturnCode returnCode, object target, in PropertyPath path)
		{
			return null;
		}

		internal static string GetRootDataSourceError(object target)
		{
			return null;
		}
	}
}
