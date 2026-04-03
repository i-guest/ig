using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule
{
	internal abstract class RenderGraphDebugSession : IDisposable
	{
		protected class DebugDataContainer
		{
			private readonly Dictionary<string, Dictionary<EntityId, RenderGraph.DebugData>> m_Container;

			public bool AddGraph(string graphName)
			{
				return false;
			}

			public bool RemoveGraph(string graphName)
			{
				return false;
			}

			public bool AddExecution(string graphName, EntityId executionId, string executionName)
			{
				return false;
			}

			public List<string> GetRenderGraphs()
			{
				return null;
			}

			public List<RenderGraph.DebugExecutionItem> GetExecutions(string graphName)
			{
				return null;
			}

			public RenderGraph.DebugData GetDebugData(string renderGraph, EntityId executionId)
			{
				return null;
			}

			public void SetDebugData(string renderGraph, EntityId executionId, RenderGraph.DebugData data)
			{
			}

			public void DeleteExecutionIds(string renderGraph, List<EntityId> executionIds)
			{
			}

			public void Clear()
			{
			}

			public void Invalidate()
			{
			}
		}

		private static RenderGraphDebugSession s_CurrentDebugSession;

		public static List<string> s_EmptyRegisteredGraphs;

		public static List<RenderGraph.DebugExecutionItem> s_EmptyExecutions;

		public abstract bool isActive { get; }

		private DebugDataContainer debugDataContainer { get; }

		public static bool hasActiveDebugSession => false;

		public static RenderGraphDebugSession currentDebugSession => null;

		public static event Action onRegisteredGraphsChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string, EntityId> onDebugDataUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void RegisterGraph(string graphName)
		{
		}

		protected void UnregisterGraph(string graphName)
		{
		}

		protected void RegisterExecution(string graphName, EntityId executionId, string executionName)
		{
		}

		public virtual void Dispose()
		{
		}

		protected void InvalidateData()
		{
		}

		public static void Create<TSession>() where TSession : RenderGraphDebugSession, new()
		{
		}

		public static void EndSession()
		{
		}

		public static List<string> GetRegisteredGraphs()
		{
			return null;
		}

		public static List<RenderGraph.DebugExecutionItem> GetExecutions(string graphName)
		{
			return null;
		}

		public static RenderGraph.DebugData GetDebugData(string renderGraph, EntityId executionId)
		{
			return null;
		}

		public static void SetDebugData(string renderGraph, EntityId executionId, RenderGraph.DebugData data)
		{
		}

		public static void DeleteExecutionIds(string renderGraph, List<EntityId> executionIds)
		{
		}

		protected void RegisterAllLocallyKnownGraphsAndExecutions()
		{
		}
	}
}
