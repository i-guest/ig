using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	public class CustomInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		public struct PlayerActions
		{
			private CustomInputActions m_Wrapper;

			public InputAction Move => null;

			public InputAction Look => null;

			public InputAction Jump => null;

			public InputAction Sprint => null;

			public InputAction Use => null;

			public InputAction Take => null;

			public InputAction CheckoutTake => null;

			public InputAction Drop => null;

			public InputAction Cancel => null;

			public InputAction Back => null;

			public InputAction Throw => null;

			public InputAction ApproveCheckout => null;

			public InputAction Close => null;

			public InputAction Scroll => null;

			public InputAction FinishDay => null;

			public InputAction Sell => null;

			public InputAction OpenClose => null;

			public InputAction LB => null;

			public InputAction RB => null;

			public InputAction ToolWheel => null;

			public InputAction WholesaleOffer => null;

			public InputAction OnlineOrder => null;

			public InputAction Map => null;

			public InputAction Backspace => null;

			public InputAction Enter => null;

			public InputAction CheatManager => null;

			public InputAction Previous => null;

			public InputAction Next => null;

			public InputAction Swap => null;

			public InputAction Ping => null;

			public bool enabled => false;

			public PlayerActions(CustomInputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(PlayerActions set)
			{
				return null;
			}

			public void AddCallbacks(IPlayerActions instance)
			{
			}

			private void UnregisterCallbacks(IPlayerActions instance)
			{
			}

			public void RemoveCallbacks(IPlayerActions instance)
			{
			}

			public void SetCallbacks(IPlayerActions instance)
			{
			}
		}

		public struct UIActions
		{
			private CustomInputActions m_Wrapper;

			public InputAction Navigate => null;

			public InputAction Submit => null;

			public InputAction Back => null;

			public InputAction Point => null;

			public InputAction Click => null;

			public InputAction ScrollWheel => null;

			public InputAction MiddleClick => null;

			public InputAction RightClick => null;

			public InputAction TrackedDevicePosition => null;

			public InputAction TrackedDeviceOrientation => null;

			public InputAction LeftShoulder => null;

			public InputAction RightShoulder => null;

			public InputAction LeftTrigger => null;

			public InputAction RightTrigger => null;

			public InputAction LeftAnalogClick => null;

			public InputAction RightAnalogClick => null;

			public InputAction North => null;

			public InputAction East => null;

			public InputAction West => null;

			public InputAction Select => null;

			public InputAction Start => null;

			public InputAction Dpad => null;

			public InputAction RightAnalog => null;

			public InputAction LeftAnalog => null;

			public bool enabled => false;

			public UIActions(CustomInputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(UIActions set)
			{
				return null;
			}

			public void AddCallbacks(IUIActions instance)
			{
			}

			private void UnregisterCallbacks(IUIActions instance)
			{
			}

			public void RemoveCallbacks(IUIActions instance)
			{
			}

			public void SetCallbacks(IUIActions instance)
			{
			}
		}

		public struct ToolActions
		{
			private CustomInputActions m_Wrapper;

			public InputAction ToggleWeaponWheel => null;

			public InputAction Confirm => null;

			public InputAction RightStick => null;

			public InputAction PointerPosition => null;

			public bool enabled => false;

			public ToolActions(CustomInputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(ToolActions set)
			{
				return null;
			}

			public void AddCallbacks(IToolActions instance)
			{
			}

			private void UnregisterCallbacks(IToolActions instance)
			{
			}

			public void RemoveCallbacks(IToolActions instance)
			{
			}

			public void SetCallbacks(IToolActions instance)
			{
			}
		}

		public struct VehicleActions
		{
			private CustomInputActions m_Wrapper;

			public InputAction Gas => null;

			public InputAction Brake => null;

			public InputAction Steer => null;

			public InputAction LookAround => null;

			public InputAction ExitVehicle => null;

			public InputAction ResetVehicle => null;

			public InputAction SwitchMap => null;

			public InputAction HandBrake => null;

			public InputAction Refuel => null;

			public bool enabled => false;

			public VehicleActions(CustomInputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(VehicleActions set)
			{
				return null;
			}

			public void AddCallbacks(IVehicleActions instance)
			{
			}

			private void UnregisterCallbacks(IVehicleActions instance)
			{
			}

			public void RemoveCallbacks(IVehicleActions instance)
			{
			}

			public void SetCallbacks(IVehicleActions instance)
			{
			}
		}

		public interface IPlayerActions
		{
			void OnMove(InputAction.CallbackContext context);

			void OnLook(InputAction.CallbackContext context);

			void OnJump(InputAction.CallbackContext context);

			void OnSprint(InputAction.CallbackContext context);

			void OnUse(InputAction.CallbackContext context);

			void OnTake(InputAction.CallbackContext context);

			void OnCheckoutTake(InputAction.CallbackContext context);

			void OnDrop(InputAction.CallbackContext context);

			void OnCancel(InputAction.CallbackContext context);

			void OnBack(InputAction.CallbackContext context);

			void OnThrow(InputAction.CallbackContext context);

			void OnApproveCheckout(InputAction.CallbackContext context);

			void OnClose(InputAction.CallbackContext context);

			void OnScroll(InputAction.CallbackContext context);

			void OnFinishDay(InputAction.CallbackContext context);

			void OnSell(InputAction.CallbackContext context);

			void OnOpenClose(InputAction.CallbackContext context);

			void OnLB(InputAction.CallbackContext context);

			void OnRB(InputAction.CallbackContext context);

			void OnToolWheel(InputAction.CallbackContext context);

			void OnWholesaleOffer(InputAction.CallbackContext context);

			void OnOnlineOrder(InputAction.CallbackContext context);

			void OnMap(InputAction.CallbackContext context);

			void OnBackspace(InputAction.CallbackContext context);

			void OnEnter(InputAction.CallbackContext context);

			void OnCheatManager(InputAction.CallbackContext context);

			void OnPrevious(InputAction.CallbackContext context);

			void OnNext(InputAction.CallbackContext context);

			void OnSwap(InputAction.CallbackContext context);

			void OnPing(InputAction.CallbackContext context);
		}

		public interface IUIActions
		{
			void OnNavigate(InputAction.CallbackContext context);

			void OnSubmit(InputAction.CallbackContext context);

			void OnBack(InputAction.CallbackContext context);

			void OnPoint(InputAction.CallbackContext context);

			void OnClick(InputAction.CallbackContext context);

			void OnScrollWheel(InputAction.CallbackContext context);

			void OnMiddleClick(InputAction.CallbackContext context);

			void OnRightClick(InputAction.CallbackContext context);

			void OnTrackedDevicePosition(InputAction.CallbackContext context);

			void OnTrackedDeviceOrientation(InputAction.CallbackContext context);

			void OnLeftShoulder(InputAction.CallbackContext context);

			void OnRightShoulder(InputAction.CallbackContext context);

			void OnLeftTrigger(InputAction.CallbackContext context);

			void OnRightTrigger(InputAction.CallbackContext context);

			void OnLeftAnalogClick(InputAction.CallbackContext context);

			void OnRightAnalogClick(InputAction.CallbackContext context);

			void OnNorth(InputAction.CallbackContext context);

			void OnEast(InputAction.CallbackContext context);

			void OnWest(InputAction.CallbackContext context);

			void OnSelect(InputAction.CallbackContext context);

			void OnStart(InputAction.CallbackContext context);

			void OnDpad(InputAction.CallbackContext context);

			void OnRightAnalog(InputAction.CallbackContext context);

			void OnLeftAnalog(InputAction.CallbackContext context);
		}

		public interface IToolActions
		{
			void OnToggleWeaponWheel(InputAction.CallbackContext context);

			void OnConfirm(InputAction.CallbackContext context);

			void OnRightStick(InputAction.CallbackContext context);

			void OnPointerPosition(InputAction.CallbackContext context);
		}

		public interface IVehicleActions
		{
			void OnGas(InputAction.CallbackContext context);

			void OnBrake(InputAction.CallbackContext context);

			void OnSteer(InputAction.CallbackContext context);

			void OnLookAround(InputAction.CallbackContext context);

			void OnExitVehicle(InputAction.CallbackContext context);

			void OnResetVehicle(InputAction.CallbackContext context);

			void OnSwitchMap(InputAction.CallbackContext context);

			void OnHandBrake(InputAction.CallbackContext context);

			void OnRefuel(InputAction.CallbackContext context);
		}

		private readonly InputActionMap m_Player;

		private List<IPlayerActions> m_PlayerActionsCallbackInterfaces;

		private readonly InputAction m_Player_Move;

		private readonly InputAction m_Player_Look;

		private readonly InputAction m_Player_Jump;

		private readonly InputAction m_Player_Sprint;

		private readonly InputAction m_Player_Use;

		private readonly InputAction m_Player_Take;

		private readonly InputAction m_Player_CheckoutTake;

		private readonly InputAction m_Player_Drop;

		private readonly InputAction m_Player_Cancel;

		private readonly InputAction m_Player_Back;

		private readonly InputAction m_Player_Throw;

		private readonly InputAction m_Player_ApproveCheckout;

		private readonly InputAction m_Player_Close;

		private readonly InputAction m_Player_Scroll;

		private readonly InputAction m_Player_FinishDay;

		private readonly InputAction m_Player_Sell;

		private readonly InputAction m_Player_OpenClose;

		private readonly InputAction m_Player_LB;

		private readonly InputAction m_Player_RB;

		private readonly InputAction m_Player_ToolWheel;

		private readonly InputAction m_Player_WholesaleOffer;

		private readonly InputAction m_Player_OnlineOrder;

		private readonly InputAction m_Player_Map;

		private readonly InputAction m_Player_Backspace;

		private readonly InputAction m_Player_Enter;

		private readonly InputAction m_Player_CheatManager;

		private readonly InputAction m_Player_Previous;

		private readonly InputAction m_Player_Next;

		private readonly InputAction m_Player_Swap;

		private readonly InputAction m_Player_Ping;

		private readonly InputActionMap m_UI;

		private List<IUIActions> m_UIActionsCallbackInterfaces;

		private readonly InputAction m_UI_Navigate;

		private readonly InputAction m_UI_Submit;

		private readonly InputAction m_UI_Back;

		private readonly InputAction m_UI_Point;

		private readonly InputAction m_UI_Click;

		private readonly InputAction m_UI_ScrollWheel;

		private readonly InputAction m_UI_MiddleClick;

		private readonly InputAction m_UI_RightClick;

		private readonly InputAction m_UI_TrackedDevicePosition;

		private readonly InputAction m_UI_TrackedDeviceOrientation;

		private readonly InputAction m_UI_LeftShoulder;

		private readonly InputAction m_UI_RightShoulder;

		private readonly InputAction m_UI_LeftTrigger;

		private readonly InputAction m_UI_RightTrigger;

		private readonly InputAction m_UI_LeftAnalogClick;

		private readonly InputAction m_UI_RightAnalogClick;

		private readonly InputAction m_UI_North;

		private readonly InputAction m_UI_East;

		private readonly InputAction m_UI_West;

		private readonly InputAction m_UI_Select;

		private readonly InputAction m_UI_Start;

		private readonly InputAction m_UI_Dpad;

		private readonly InputAction m_UI_RightAnalog;

		private readonly InputAction m_UI_LeftAnalog;

		private readonly InputActionMap m_Tool;

		private List<IToolActions> m_ToolActionsCallbackInterfaces;

		private readonly InputAction m_Tool_ToggleWeaponWheel;

		private readonly InputAction m_Tool_Confirm;

		private readonly InputAction m_Tool_RightStick;

		private readonly InputAction m_Tool_PointerPosition;

		private readonly InputActionMap m_Vehicle;

		private List<IVehicleActions> m_VehicleActionsCallbackInterfaces;

		private readonly InputAction m_Vehicle_Gas;

		private readonly InputAction m_Vehicle_Brake;

		private readonly InputAction m_Vehicle_Steer;

		private readonly InputAction m_Vehicle_LookAround;

		private readonly InputAction m_Vehicle_ExitVehicle;

		private readonly InputAction m_Vehicle_ResetVehicle;

		private readonly InputAction m_Vehicle_SwitchMap;

		private readonly InputAction m_Vehicle_HandBrake;

		private readonly InputAction m_Vehicle_Refuel;

		private int m_KeyboardMouseSchemeIndex;

		private int m_GamepadSchemeIndex;

		private int m_TouchSchemeIndex;

		private int m_JoystickSchemeIndex;

		private int m_XRSchemeIndex;

		public InputActionAsset asset { get; }

		public InputBinding? bindingMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReadOnlyArray<InputDevice>? devices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

		public IEnumerable<InputBinding> bindings => null;

		public PlayerActions Player => default(PlayerActions);

		public UIActions UI => default(UIActions);

		public ToolActions Tool => default(ToolActions);

		public VehicleActions Vehicle => default(VehicleActions);

		public InputControlScheme KeyboardMouseScheme => default(InputControlScheme);

		public InputControlScheme GamepadScheme => default(InputControlScheme);

		public InputControlScheme TouchScheme => default(InputControlScheme);

		public InputControlScheme JoystickScheme => default(InputControlScheme);

		public InputControlScheme XRScheme => default(InputControlScheme);

		~CustomInputActions()
		{
		}

		public void Dispose()
		{
		}

		public bool Contains(InputAction action)
		{
			return false;
		}

		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			action = null;
			return 0;
		}
	}
}
