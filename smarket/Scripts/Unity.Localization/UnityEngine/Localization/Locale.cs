using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.Metadata;
using UnityEngine.Pool;

namespace UnityEngine.Localization
{
	public class Locale : ScriptableObject, IEquatable<Locale>, IComparable<Locale>, ISerializationCallbackReceiver, IFormatProvider
	{
		[CompilerGenerated]
		private sealed class _003CGetFallbacks_003Ed__20 : IEnumerable<Locale>, IEnumerable, IEnumerator<Locale>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Locale _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Locale _003C_003E4__this;

			private HashSet<Locale> _003CprocessedLocales_003E5__2;

			private PooledObject<HashSet<Locale>> _003C_003E7__wrap2;

			private IList<IMetadata> _003Centries_003E5__4;

			private int _003Ci_003E5__5;

			Locale IEnumerator<Locale>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetFallbacks_003Ed__20(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<Locale> IEnumerable<Locale>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[SerializeField]
		private LocaleIdentifier m_Identifier;

		[SerializeField]
		[MetadataType(MetadataType.Locale)]
		private MetadataCollection m_Metadata;

		[SerializeField]
		private string m_LocaleName;

		[SerializeField]
		private string m_CustomFormatCultureCode;

		[SerializeField]
		private bool m_UseCustomFormatter;

		[SerializeField]
		private ushort m_SortOrder;

		private IFormatProvider m_Formatter;

		public LocaleIdentifier Identifier
		{
			get
			{
				return default(LocaleIdentifier);
			}
			set
			{
			}
		}

		public MetadataCollection Metadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ushort SortOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string LocaleName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseCustomFormatter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string CustomFormatterCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual IFormatProvider Formatter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("GetFallback is obsolete, please use GetFallbacks.")]
		public virtual Locale GetFallback()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetFallbacks_003Ed__20))]
		public IEnumerable<Locale> GetFallbacks()
		{
			return null;
		}

		internal static CultureInfo GetFormatter(bool useCustom, LocaleIdentifier localeIdentifier, string customCode)
		{
			return null;
		}

		public static Locale CreateLocale(string code)
		{
			return null;
		}

		public static Locale CreateLocale(LocaleIdentifier identifier)
		{
			return null;
		}

		public static Locale CreateLocale(SystemLanguage language)
		{
			return null;
		}

		public static Locale CreateLocale(CultureInfo cultureInfo)
		{
			return null;
		}

		public int CompareTo(Locale other)
		{
			return 0;
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Locale other)
		{
			return false;
		}

		object IFormatProvider.GetFormat(Type formatType)
		{
			return null;
		}
	}
}
