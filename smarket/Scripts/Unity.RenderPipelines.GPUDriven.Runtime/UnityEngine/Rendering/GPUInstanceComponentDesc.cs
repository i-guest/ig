namespace UnityEngine.Rendering
{
	internal struct GPUInstanceComponentDesc
	{
		public int propertyID;

		public int byteSize;

		public bool isOverriden;

		public bool isPerInstance;

		public InstanceType instanceType;

		public InstanceComponentGroup componentGroup;

		public GPUInstanceComponentDesc(int inPropertyID, int inByteSize, bool inIsOverriden, bool inPerInstance, InstanceType inInstanceType, InstanceComponentGroup inComponentType)
		{
			propertyID = 0;
			byteSize = 0;
			isOverriden = false;
			isPerInstance = false;
			instanceType = default(InstanceType);
			componentGroup = default(InstanceComponentGroup);
		}
	}
}
