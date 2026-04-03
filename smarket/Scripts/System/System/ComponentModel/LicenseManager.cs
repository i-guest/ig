using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Provides properties and methods to add a license to a component and to manage a <see cref="T:System.ComponentModel.LicenseProvider" />. This class cannot be inherited.</summary>
	public sealed class LicenseManager
	{
		private static readonly object s_selfLock;

		private static LicenseContext s_context;

		private static object s_contextLockHolder;

		private static Hashtable s_providers;

		private static Hashtable s_providerInstances;

		private static readonly object s_internalSyncObject;

		/// <summary>Gets or sets the current <see cref="T:System.ComponentModel.LicenseContext" />, which specifies when you can use the licensed object.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.LicenseContext" /> that specifies when you can use the licensed object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.ComponentModel.LicenseManager.CurrentContext" /> property is currently locked and cannot be changed.</exception>
		public static LicenseContext CurrentContext
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the <see cref="T:System.ComponentModel.LicenseUsageMode" /> which specifies when you can use the licensed object for the <see cref="P:System.ComponentModel.LicenseManager.CurrentContext" />.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.LicenseUsageMode" /> values, as specified in the <see cref="P:System.ComponentModel.LicenseManager.CurrentContext" /> property.</returns>
		public static LicenseUsageMode UsageMode => default(LicenseUsageMode);

		private LicenseManager()
		{
		}

		private static void CacheProvider(Type type, LicenseProvider provider)
		{
		}

		/// <summary>Creates an instance of the specified type, given a context in which you can use the licensed instance.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to create. </param>
		/// <param name="creationContext">A <see cref="T:System.ComponentModel.LicenseContext" /> that specifies when you can use the licensed instance. </param>
		/// <returns>An instance of the specified type.</returns>
		public static object CreateWithContext(Type type, LicenseContext creationContext)
		{
			return null;
		}

		/// <summary>Creates an instance of the specified type with the specified arguments, given a context in which you can use the licensed instance.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to create. </param>
		/// <param name="creationContext">A <see cref="T:System.ComponentModel.LicenseContext" /> that specifies when you can use the licensed instance. </param>
		/// <param name="args">An array of type <see cref="T:System.Object" /> that represents the arguments for the type. </param>
		/// <returns>An instance of the specified type with the given array of arguments.</returns>
		public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args)
		{
			return null;
		}

		private static bool GetCachedNoLicenseProvider(Type type)
		{
			return false;
		}

		private static LicenseProvider GetCachedProvider(Type type)
		{
			return null;
		}

		private static LicenseProvider GetCachedProviderInstance(Type providerType)
		{
			return null;
		}

		/// <summary>Returns whether the given type has a valid license.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> to find a valid license for. </param>
		/// <returns>
		///     <see langword="true" /> if the given type is licensed; otherwise, <see langword="false" />.</returns>
		public static bool IsLicensed(Type type)
		{
			return false;
		}

		/// <summary>Determines whether a valid license can be granted for the specified type.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of object that requests the <see cref="T:System.ComponentModel.License" />. </param>
		/// <returns>
		///     <see langword="true" /> if a valid license can be granted; otherwise, <see langword="false" />.</returns>
		public static bool IsValid(Type type)
		{
			return false;
		}

		/// <summary>Determines whether a valid license can be granted for the specified instance of the type. This method creates a valid <see cref="T:System.ComponentModel.License" />.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of object that requests the license. </param>
		/// <param name="instance">An object of the specified type or a type derived from the specified type. </param>
		/// <param name="license">A <see cref="T:System.ComponentModel.License" /> that is a valid license, or <see langword="null" /> if a valid license cannot be granted. </param>
		/// <returns>
		///     <see langword="true" /> if a valid <see cref="T:System.ComponentModel.License" /> can be granted; otherwise, <see langword="false" />.</returns>
		public static bool IsValid(Type type, object instance, out License license)
		{
			license = null;
			return false;
		}

		/// <summary>Prevents changes being made to the current <see cref="T:System.ComponentModel.LicenseContext" /> of the given object.</summary>
		/// <param name="contextUser">The object whose current context you want to lock. </param>
		/// <exception cref="T:System.InvalidOperationException">The context is already locked.</exception>
		public static void LockContext(object contextUser)
		{
		}

		/// <summary>Allows changes to be made to the current <see cref="T:System.ComponentModel.LicenseContext" /> of the given object.</summary>
		/// <param name="contextUser">The object whose current context you want to unlock. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="contextUser" /> represents a different user than the one specified in a previous call to <see cref="M:System.ComponentModel.LicenseManager.LockContext(System.Object)" />. </exception>
		public static void UnlockContext(object contextUser)
		{
		}

		private static bool ValidateInternal(Type type, object instance, bool allowExceptions, out License license)
		{
			license = null;
			return false;
		}

		private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, out License license, out string licenseKey)
		{
			license = null;
			licenseKey = null;
			return false;
		}

		/// <summary>Determines whether a license can be granted for the specified type.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of object that requests the license. </param>
		/// <exception cref="T:System.ComponentModel.LicenseException">A <see cref="T:System.ComponentModel.License" /> cannot be granted. </exception>
		public static void Validate(Type type)
		{
		}

		/// <summary>Determines whether a license can be granted for the instance of the specified type.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of object that requests the license. </param>
		/// <param name="instance">An <see cref="T:System.Object" /> of the specified type or a type derived from the specified type. </param>
		/// <returns>A valid <see cref="T:System.ComponentModel.License" />.</returns>
		/// <exception cref="T:System.ComponentModel.LicenseException">The type is licensed, but a <see cref="T:System.ComponentModel.License" /> cannot be granted. </exception>
		public static License Validate(Type type, object instance)
		{
			return null;
		}
	}
}
