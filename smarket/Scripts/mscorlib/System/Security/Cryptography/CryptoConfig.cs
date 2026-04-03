using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Accesses the cryptography configuration information.</summary>
	[ComVisible(true)]
	public class CryptoConfig
	{
		private static readonly object lockObject;

		private static Dictionary<string, Type> algorithms;

		/// <summary>Indicates whether the runtime should enforce the policy to create only Federal Information Processing Standard (FIPS) certified algorithms.</summary>
		/// <returns>
		///     <see langword="true" /> to enforce the policy; otherwise, <see langword="false" />. </returns>
		[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
		public static bool AllowOnlyFipsAlgorithms => false;

		/// <summary>Adds a set of names to object identifier (OID) mappings to be used for the current application domain.  </summary>
		/// <param name="oid">The object identifier (OID) to map to.</param>
		/// <param name="names">An array of names to map to the OID.</param>
		/// <exception cref="T:System.ArgumentNullException">The<paramref name=" oid" /> or <paramref name="names" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">One of the entries in the <paramref name="names" /> parameter is empty or <see langword="null" />.</exception>
		public static void AddOID(string oid, params string[] names)
		{
		}

		/// <summary>Creates a new instance of the specified cryptographic object.</summary>
		/// <param name="name">The simple name of the cryptographic object of which to create an instance. </param>
		/// <returns>A new instance of the specified cryptographic object.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="name" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
		public static object CreateFromName(string name)
		{
			return null;
		}

		/// <summary>Creates a new instance of the specified cryptographic object with the specified arguments.</summary>
		/// <param name="name">The simple name of the cryptographic object of which to create an instance. </param>
		/// <param name="args">The arguments used to create the specified cryptographic object. </param>
		/// <returns>A new instance of the specified cryptographic object.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="name" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
		public static object CreateFromName(string name, params object[] args)
		{
			return null;
		}

		internal static string MapNameToOID(string name, object arg)
		{
			return null;
		}

		/// <summary>Gets the object identifier (OID) of the algorithm corresponding to the specified simple name.</summary>
		/// <param name="name">The simple name of the algorithm for which to get the OID. </param>
		/// <returns>The OID of the specified algorithm.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		public static string MapNameToOID(string name)
		{
			return null;
		}

		private static void Initialize()
		{
		}

		/// <summary>Adds a set of names to algorithm mappings to be used for the current application domain.  </summary>
		/// <param name="algorithm">The algorithm to map to.</param>
		/// <param name="names">An array of names to map to the algorithm.</param>
		/// <exception cref="T:System.ArgumentNullException">The<paramref name=" algorithm" /> or <paramref name="names" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="algorithm" /> cannot be accessed from outside the assembly.-or-One of the entries in the <paramref name="names" /> parameter is empty or <see langword="null" />.</exception>
		public static void AddAlgorithm(Type algorithm, params string[] names)
		{
		}

		/// <summary>Encodes the specified object identifier (OID).</summary>
		/// <param name="str">The OID to encode. </param>
		/// <returns>A byte array containing the encoded OID.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="str" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">An error occurred while encoding the OID. </exception>
		public static byte[] EncodeOID(string str)
		{
			return null;
		}

		private static byte[] EncodeLongNumber(long x)
		{
			return null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptoConfig" /> class. </summary>
		public CryptoConfig()
		{
		}
	}
}
