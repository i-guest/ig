using System;
using System.Collections.Generic;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	internal class MeshGenerationNodeManager : IDisposable
	{
		private List<MeshGenerationNodeImpl> m_Nodes;

		private int m_UsedCounter;

		private EntryRecorder m_EntryRecorder;

		protected bool disposed { get; private set; }

		public MeshGenerationNodeManager(EntryRecorder entryRecorder)
		{
		}

		public void CreateNode(Entry parentEntry, out MeshGenerationNode node)
		{
			node = default(MeshGenerationNode);
		}

		public void CreateUnsafeNode(Entry parentEntry, out UnsafeMeshGenerationNode node)
		{
			node = default(UnsafeMeshGenerationNode);
		}

		private MeshGenerationNodeImpl CreateImpl(Entry parentEntry, bool safe)
		{
			return null;
		}

		public void ResetAll()
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
