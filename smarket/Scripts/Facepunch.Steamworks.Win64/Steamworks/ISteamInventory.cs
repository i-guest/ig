using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamInventory : SteamInterface
	{
		public const string Version = "STEAMINVENTORY_INTERFACE_V003";

		internal ISteamInventory(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamInventory_v003();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServerInventory_v003();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern Result _GetResultStatus(IntPtr self, SteamInventoryResult_t resultHandle);

		internal Result GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(Result);
		}

		[PreserveSig]
		private static extern bool _GetResultItems(IntPtr self, SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		internal bool GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetResultItemProperty(IntPtr self, SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		internal bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer)
		{
			pchValueBuffer = null;
			return false;
		}

		[PreserveSig]
		private static extern uint _GetResultTimestamp(IntPtr self, SteamInventoryResult_t resultHandle);

		internal uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _CheckResultSteamID(IntPtr self, SteamInventoryResult_t resultHandle, SteamId steamIDExpected);

		internal bool CheckResultSteamID(SteamInventoryResult_t resultHandle, SteamId steamIDExpected)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _DestroyResult(IntPtr self, SteamInventoryResult_t resultHandle);

		internal void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[PreserveSig]
		private static extern bool _GetAllItems(IntPtr self, ref SteamInventoryResult_t pResultHandle);

		internal bool GetAllItems(ref SteamInventoryResult_t pResultHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetItemsByID(IntPtr self, ref SteamInventoryResult_t pResultHandle, ref InventoryItemId pInstanceIDs, uint unCountInstanceIDs);

		internal bool GetItemsByID(ref SteamInventoryResult_t pResultHandle, ref InventoryItemId pInstanceIDs, uint unCountInstanceIDs)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SerializeResult(IntPtr self, SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize);

		internal bool SerializeResult(SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _DeserializeResult(IntPtr self, ref SteamInventoryResult_t pOutResultHandle, IntPtr pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		internal bool DeserializeResult(ref SteamInventoryResult_t pOutResultHandle, IntPtr pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GenerateItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In][Out] InventoryDefId[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		internal bool GenerateItems(ref SteamInventoryResult_t pResultHandle, [In][Out] InventoryDefId[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GrantPromoItems(IntPtr self, ref SteamInventoryResult_t pResultHandle);

		internal bool GrantPromoItems(ref SteamInventoryResult_t pResultHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddPromoItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryDefId itemDef);

		internal bool AddPromoItem(ref SteamInventoryResult_t pResultHandle, InventoryDefId itemDef)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _AddPromoItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In][Out] InventoryDefId[] pArrayItemDefs, uint unArrayLength);

		internal bool AddPromoItems(ref SteamInventoryResult_t pResultHandle, [In][Out] InventoryDefId[] pArrayItemDefs, uint unArrayLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ConsumeItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity);

		internal bool ConsumeItem(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ExchangeItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In][Out] InventoryDefId[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] InventoryItemId[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		internal bool ExchangeItems(ref SteamInventoryResult_t pResultHandle, [In][Out] InventoryDefId[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] InventoryItemId[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _TransferItemQuantity(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest);

		internal bool TransferItemQuantity(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest)
		{
			return false;
		}

		[PreserveSig]
		private static extern void _SendItemDropHeartbeat(IntPtr self);

		internal void SendItemDropHeartbeat()
		{
		}

		[PreserveSig]
		private static extern bool _TriggerItemDrop(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition);

		internal bool TriggerItemDrop(ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _TradeItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, SteamId steamIDTradePartner, [In][Out] InventoryItemId[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] InventoryItemId[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		internal bool TradeItems(ref SteamInventoryResult_t pResultHandle, SteamId steamIDTradePartner, [In][Out] InventoryItemId[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] InventoryItemId[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _LoadItemDefinitions(IntPtr self);

		internal bool LoadItemDefinitions()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetItemDefinitionIDs(IntPtr self, [In][Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		internal bool GetItemDefinitionIDs([In][Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetItemDefinitionProperty(IntPtr self, InventoryDefId iDefinition, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		internal bool GetItemDefinitionProperty(InventoryDefId iDefinition, string pchPropertyName, out string pchValueBuffer)
		{
			pchValueBuffer = null;
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestEligiblePromoItemDefinitionsIDs(IntPtr self, SteamId steamID);

		internal CallResult<SteamInventoryEligiblePromoItemDefIDs_t> RequestEligiblePromoItemDefinitionsIDs(SteamId steamID)
		{
			return default(CallResult<SteamInventoryEligiblePromoItemDefIDs_t>);
		}

		[PreserveSig]
		private static extern bool _GetEligiblePromoItemDefinitionIDs(IntPtr self, SteamId steamID, [In][Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		internal bool GetEligiblePromoItemDefinitionIDs(SteamId steamID, [In][Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _StartPurchase(IntPtr self, [In][Out] InventoryDefId[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		internal CallResult<SteamInventoryStartPurchaseResult_t> StartPurchase([In][Out] InventoryDefId[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(CallResult<SteamInventoryStartPurchaseResult_t>);
		}

		[PreserveSig]
		private static extern SteamAPICall_t _RequestPrices(IntPtr self);

		internal CallResult<SteamInventoryRequestPricesResult_t> RequestPrices()
		{
			return default(CallResult<SteamInventoryRequestPricesResult_t>);
		}

		[PreserveSig]
		private static extern uint _GetNumItemsWithPrices(IntPtr self);

		internal uint GetNumItemsWithPrices()
		{
			return 0u;
		}

		[PreserveSig]
		private static extern bool _GetItemsWithPrices(IntPtr self, [In][Out] InventoryDefId[] pArrayItemDefs, [In][Out] ulong[] pCurrentPrices, [In][Out] ulong[] pBasePrices, uint unArrayLength);

		internal bool GetItemsWithPrices([In][Out] InventoryDefId[] pArrayItemDefs, [In][Out] ulong[] pCurrentPrices, [In][Out] ulong[] pBasePrices, uint unArrayLength)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetItemPrice(IntPtr self, InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice);

		internal bool GetItemPrice(InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice)
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamInventoryUpdateHandle_t _StartUpdateProperties(IntPtr self);

		internal SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		[PreserveSig]
		private static extern bool _RemoveProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName);

		internal bool RemoveProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, string pchPropertyValue);

		internal bool SetProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, string pchPropertyValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, bool bValue);

		internal bool SetProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, bool bValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, long nValue);

		internal bool SetProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, long nValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetProperty(IntPtr self, SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, float flValue);

		internal bool SetProperty(SteamInventoryUpdateHandle_t handle, InventoryItemId nItemID, string pchPropertyName, float flValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SubmitUpdateProperties(IntPtr self, SteamInventoryUpdateHandle_t handle, ref SteamInventoryResult_t pResultHandle);

		internal bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, ref SteamInventoryResult_t pResultHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _InspectItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, string pchItemToken);

		internal bool InspectItem(ref SteamInventoryResult_t pResultHandle, string pchItemToken)
		{
			return false;
		}
	}
}
