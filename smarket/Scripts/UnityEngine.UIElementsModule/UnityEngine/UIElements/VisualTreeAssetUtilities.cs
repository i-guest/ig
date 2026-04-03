using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static class VisualTreeAssetUtilities
	{
		[CompilerGenerated]
		private sealed class _003CEnumerateEnclosingNamespaces_003Ed__0 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private string fullTypeName;

			public string _003C_003E3__fullTypeName;

			private int _003CstartIndex_003E5__1;

			private int _003ClastDot_003E5__2;

			string IEnumerator<string>.Current
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
			public _003CEnumerateEnclosingNamespaces_003Ed__0(int _003C_003E1__state)
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
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[IteratorStateMachine(typeof(_003CEnumerateEnclosingNamespaces_003Ed__0))]
		public static IEnumerable<string> EnumerateEnclosingNamespaces(string fullTypeName)
		{
			return null;
		}

		public static UxmlNamespaceDefinition FindUxmlNamespaceDefinitionForTypeName(this VisualTreeAsset vta, UxmlAsset asset, string fullTypeName)
		{
			return default(UxmlNamespaceDefinition);
		}
	}
}
