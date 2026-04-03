using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	/// <summary>Provides data for loader resolution events, such as the <see cref="E:System.AppDomain.TypeResolve" />, <see cref="E:System.AppDomain.ResourceResolve" />, <see cref="E:System.AppDomain.ReflectionOnlyAssemblyResolve" />, and <see cref="E:System.AppDomain.AssemblyResolve" /> events.</summary>
	public class ResolveEventArgs : EventArgs
	{
		[CompilerGenerated]
		private readonly string _003CName_003Ek__BackingField;

		[CompilerGenerated]
		private readonly Assembly _003CRequestingAssembly_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.ResolveEventArgs" /> class, specifying the name of the item to resolve.</summary>
		/// <param name="name">The name of an item to resolve. </param>
		public ResolveEventArgs(string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ResolveEventArgs" /> class, specifying the name of the item to resolve and the assembly whose dependency is being resolved.</summary>
		/// <param name="name">The name of an item to resolve. </param>
		/// <param name="requestingAssembly">The assembly whose dependency is being resolved.</param>
		public ResolveEventArgs(string name, Assembly requestingAssembly)
		{
		}
	}
}
