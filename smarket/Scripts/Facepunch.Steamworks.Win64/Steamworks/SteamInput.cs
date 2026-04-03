using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamInput : SteamClientClass<SteamInput>
	{
		[CompilerGenerated]
		private sealed class _003Cget_Controllers_003Ed__7 : IEnumerable<Controller>, IEnumerable, IEnumerator<Controller>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Controller _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int _003Cnum_003E5__2;

			private int _003Ci_003E5__3;

			Controller IEnumerator<Controller>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(Controller);
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
			public _003Cget_Controllers_003Ed__7(int _003C_003E1__state)
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
			IEnumerator<Controller> IEnumerable<Controller>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal const int STEAM_CONTROLLER_MAX_COUNT = 16;

		private static readonly InputHandle_t[] queryArray;

		internal static Dictionary<string, InputDigitalActionHandle_t> DigitalHandles;

		internal static Dictionary<string, InputAnalogActionHandle_t> AnalogHandles;

		internal static Dictionary<string, InputActionSetHandle_t> ActionSets;

		internal static ISteamInput Internal => null;

		public static IEnumerable<Controller> Controllers
		{
			[IteratorStateMachine(typeof(_003Cget_Controllers_003Ed__7))]
			get
			{
				return null;
			}
		}

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		public static void RunFrame()
		{
		}

		public static string GetDigitalActionGlyph(Controller controller, string action)
		{
			return null;
		}

		public static string GetPngActionGlyph(Controller controller, string action, GlyphSize size)
		{
			return null;
		}

		public static string GetSvgActionGlyph(Controller controller, string action)
		{
			return null;
		}

		internal static InputDigitalActionHandle_t GetDigitalActionHandle(string name)
		{
			return default(InputDigitalActionHandle_t);
		}

		internal static InputAnalogActionHandle_t GetAnalogActionHandle(string name)
		{
			return default(InputAnalogActionHandle_t);
		}

		internal static InputActionSetHandle_t GetActionSetHandle(string name)
		{
			return default(InputActionSetHandle_t);
		}
	}
}
