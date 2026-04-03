namespace Unity.Properties
{
	public interface ICollectionPropertyBagVisitor
	{
		void Visit<TCollection, TElement>(ICollectionPropertyBag<TCollection, TElement> properties, ref TCollection container);
	}
}
