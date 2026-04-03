using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	/// <summary>Provides data for the <see cref="E:System.AppDomain.AssemblyLoad" /> event.</summary>
	public class AssemblyLoadEventArgs : EventArgs
	{
		[CompilerGenerated]
		private readonly Assembly _003CLoadedAssembly_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.AssemblyLoadEventArgs" /> class using the specified <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="loadedAssembly">An instance that represents the currently loaded assembly. </param>
		public AssemblyLoadEventArgs(Assembly loadedAssembly)
		{
		}
	}
}
