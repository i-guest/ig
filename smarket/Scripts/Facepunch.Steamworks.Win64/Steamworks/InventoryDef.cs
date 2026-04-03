using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class InventoryDef : IEquatable<InventoryDef>
	{
		[CompilerGenerated]
		private sealed class _003Cget_Properties_003Ed__34 : IEnumerable<KeyValuePair<string, string>>, IEnumerable, IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, string> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public InventoryDef _003C_003E4__this;

			private string[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			KeyValuePair<string, string> IEnumerator<KeyValuePair<string, string>>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, string>);
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
			public _003Cget_Properties_003Ed__34(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal InventoryDefId _id;

		internal Dictionary<string, string> _properties;

		private InventoryRecipe[] _recContaining;

		public int Id => 0;

		public string Name => null;

		public string Description => null;

		public string IconUrl => null;

		public string IconUrlLarge => null;

		public string PriceCategory => null;

		public string Type => null;

		public bool IsGenerator => false;

		public string ExchangeSchema => null;

		public bool Marketable => false;

		public bool Tradable => false;

		public DateTime Created => default(DateTime);

		public DateTime Modified => default(DateTime);

		public IEnumerable<KeyValuePair<string, string>> Properties
		{
			[IteratorStateMachine(typeof(_003Cget_Properties_003Ed__34))]
			get
			{
				return null;
			}
		}

		public int LocalPrice => 0;

		public string LocalPriceFormatted => null;

		public int LocalBasePrice => 0;

		public string LocalBasePriceFormatted => null;

		public InventoryDef(InventoryDefId defId)
		{
		}

		public InventoryRecipe[] GetRecipes()
		{
			return null;
		}

		public string GetProperty(string name)
		{
			return null;
		}

		public bool GetBoolProperty(string name)
		{
			return false;
		}

		public T GetProperty<T>(string name)
		{
			return default(T);
		}

		public InventoryRecipe[] GetRecipesContainingThis()
		{
			return null;
		}

		public static bool operator ==(InventoryDef a, InventoryDef b)
		{
			return false;
		}

		public static bool operator !=(InventoryDef a, InventoryDef b)
		{
			return false;
		}

		public override bool Equals(object p)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(InventoryDef p)
		{
			return false;
		}
	}
}
