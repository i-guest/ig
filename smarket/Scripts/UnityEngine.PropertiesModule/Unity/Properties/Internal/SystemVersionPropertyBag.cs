using System;

namespace Unity.Properties.Internal
{
	internal class SystemVersionPropertyBag : ContainerPropertyBag<Version>
	{
		private class MajorProperty : Property<Version, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Version container)
			{
				return 0;
			}

			public override void SetValue(ref Version container, int value)
			{
			}
		}

		private class MinorProperty : Property<Version, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Version container)
			{
				return 0;
			}

			public override void SetValue(ref Version container, int value)
			{
			}
		}

		private class BuildProperty : Property<Version, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Version container)
			{
				return 0;
			}

			public override void SetValue(ref Version container, int value)
			{
			}
		}

		private class RevisionProperty : Property<Version, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Version container)
			{
				return 0;
			}

			public override void SetValue(ref Version container, int value)
			{
			}
		}
	}
}
