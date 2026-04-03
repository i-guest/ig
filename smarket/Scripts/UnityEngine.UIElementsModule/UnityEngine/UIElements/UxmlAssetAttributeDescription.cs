namespace UnityEngine.UIElements
{
	public class UxmlAssetAttributeDescription<T> : TypedUxmlAttributeDescription<T> where T : Object
	{
		public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}

		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, out T value)
		{
			value = null;
			return false;
		}
	}
}
