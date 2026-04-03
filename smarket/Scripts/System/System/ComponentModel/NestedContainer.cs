namespace System.ComponentModel
{
	/// <summary>Provides the base implementation for the <see cref="T:System.ComponentModel.INestedContainer" /> interface, which enables containers to have an owning component.</summary>
	public class NestedContainer : Container, INestedContainer, IContainer, IDisposable
	{
		private class Site : INestedSite, ISite, IServiceProvider
		{
			private string _name;

			public IComponent Component { get; }

			public IContainer Container { get; }

			public bool DesignMode => false;

			public string FullName => null;

			public string Name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal Site(IComponent component, NestedContainer container, string name)
			{
			}

			public object GetService(Type service)
			{
				return null;
			}
		}

		/// <summary>Gets the owning component for this nested container.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.IComponent" /> that owns this nested container.</returns>
		public IComponent Owner { get; }

		/// <summary>Gets the name of the owning component.</summary>
		/// <returns>The name of the owning component.</returns>
		protected virtual string OwnerName => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.NestedContainer" /> class.</summary>
		/// <param name="owner">The <see cref="T:System.ComponentModel.IComponent" /> that owns this nested container.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="owner" /> is <see langword="null" />.</exception>
		public NestedContainer(IComponent owner)
		{
		}

		/// <summary>Creates a site for the component within the container.</summary>
		/// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to create a site for.</param>
		/// <param name="name">The name to assign to <paramref name="component" />, or <see langword="null" /> to skip the name assignment.</param>
		/// <returns>The newly created <see cref="T:System.ComponentModel.ISite" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="component" /> is <see langword="null" />.</exception>
		protected override ISite CreateSite(IComponent component, string name)
		{
			return null;
		}

		/// <summary>Releases the resources used by the nested container.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing)
		{
		}

		/// <summary>Gets the service object of the specified type, if it is available.</summary>
		/// <param name="service">The <see cref="T:System.Type" /> of the service to retrieve.</param>
		/// <returns>An <see cref="T:System.Object" /> that implements the requested service, or <see langword="null" /> if the service cannot be resolved.</returns>
		protected override object GetService(Type service)
		{
			return null;
		}

		private void OnOwnerDisposed(object sender, EventArgs e)
		{
		}
	}
}
