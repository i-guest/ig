namespace Unity.Properties
{
	public interface ICollectionPropertyBag<TCollection, TElement> : IPropertyBag<TCollection>, IPropertyBag, ICollectionPropertyBagAccept<TCollection>
	{
	}
}
