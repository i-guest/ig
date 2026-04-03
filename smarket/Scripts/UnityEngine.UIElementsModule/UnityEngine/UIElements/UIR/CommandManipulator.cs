namespace UnityEngine.UIElements.UIR
{
	internal static class CommandManipulator
	{
		public static void ReplaceHeadCommands(RenderTreeManager renderTreeManager, RenderData renderData, EntryProcessor processor)
		{
		}

		public static void ReplaceTailCommands(RenderTreeManager renderTreeManager, RenderData renderData, EntryProcessor processor)
		{
		}

		private static RenderChainCommand FindPrevCommand(RenderData candidate, bool searchFromHead)
		{
			return null;
		}

		private static void FindHeadCommandInsertionPoint(RenderData renderData, out RenderChainCommand prev, out RenderChainCommand next)
		{
			prev = null;
			next = null;
		}

		private static void FindTailCommandInsertionPoint(RenderData renderData, out RenderChainCommand prev, out RenderChainCommand next)
		{
			prev = null;
			next = null;
		}

		private static void RemoveChain(RenderTree renderTree, RenderChainCommand first, RenderChainCommand last)
		{
		}

		public static void ResetCommands(RenderTreeManager renderTreeManager, RenderData renderData)
		{
		}

		private static void InjectCommandInBetween(RenderChainCommand cmd, bool isHeadCommand, RenderChainCommand prev, RenderChainCommand next)
		{
		}

		public static void DisableElementRendering(RenderTreeManager renderTreeManager, VisualElement ve, bool renderingDisabled)
		{
		}

		private static void RemoveSingleCommand(RenderTreeManager renderTreeManager, RenderData renderData, RenderChainCommand cmd)
		{
		}
	}
}
