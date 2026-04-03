using System.Collections.Generic;
using System.Diagnostics;

namespace System.Threading
{
	/// <summary>Provides thread-local storage of data.</summary>
	/// <typeparam name="T">Specifies the type of data stored per-thread.</typeparam>
	[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
	[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<>))]
	public class ThreadLocal<T> : IDisposable
	{
		private struct LinkedSlotVolatile
		{
			internal LinkedSlot Value;
		}

		private sealed class LinkedSlot
		{
			internal LinkedSlot Next;

			internal LinkedSlot Previous;

			internal LinkedSlotVolatile[] SlotArray;

			internal T Value;

			internal LinkedSlot(LinkedSlotVolatile[] slotArray)
			{
			}
		}

		private class IdManager
		{
			private int m_nextIdToTry;

			private List<bool> m_freeIds;

			internal int GetId()
			{
				return 0;
			}

			internal void ReturnId(int id)
			{
			}
		}

		private class FinalizationHelper
		{
			internal LinkedSlotVolatile[] SlotArray;

			private bool m_trackAllValues;

			internal FinalizationHelper(LinkedSlotVolatile[] slotArray, bool trackAllValues)
			{
			}

			~FinalizationHelper()
			{
			}
		}

		private Func<T> m_valueFactory;

		[ThreadStatic]
		private static LinkedSlotVolatile[] ts_slotArray;

		[ThreadStatic]
		private static FinalizationHelper ts_finalizationHelper;

		private int m_idComplement;

		private bool m_initialized;

		private static IdManager s_idManager;

		private LinkedSlot m_linkedSlot;

		private bool m_trackAllValues;

		/// <summary>Gets or sets the value of this instance for the current thread.</summary>
		/// <returns>Returns an instance of the object that this ThreadLocal is responsible for initializing.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The initialization function attempted to reference <see cref="P:System.Threading.ThreadLocal`1.Value" /> recursively.</exception>
		/// <exception cref="T:System.MissingMemberException">No default constructor is provided and no value factory is supplied.</exception>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		/// <summary>Gets whether <see cref="P:System.Threading.ThreadLocal`1.Value" /> is initialized on the current thread.</summary>
		/// <returns>true if <see cref="P:System.Threading.ThreadLocal`1.Value" /> is initialized on the current thread; otherwise false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
		public bool IsValueCreated => false;

		/// <summary>Initializes the <see cref="T:System.Threading.ThreadLocal`1" /> instance with the specified <paramref name="valueFactory" /> function.</summary>
		/// <param name="valueFactory">The  <see cref="T:System.Func`1" /> invoked to produce a lazily-initialized value when an attempt is made to retrieve <see cref="P:System.Threading.ThreadLocal`1.Value" /> without it having been previously initialized.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="valueFactory" /> is a null reference (Nothing in Visual Basic).</exception>
		public ThreadLocal(Func<T> valueFactory)
		{
		}

		private void Initialize(Func<T> valueFactory, bool trackAllValues)
		{
		}

		/// <summary>Releases the resources used by this <see cref="T:System.Threading.ThreadLocal`1" /> instance.</summary>
		~ThreadLocal()
		{
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.ThreadLocal`1" /> class.</summary>
		public void Dispose()
		{
		}

		/// <summary>Releases the resources used by this <see cref="T:System.Threading.ThreadLocal`1" /> instance.</summary>
		/// <param name="disposing">A Boolean value that indicates whether this method is being called due to a call to <see cref="M:System.Threading.ThreadLocal`1.Dispose" />.</param>
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Creates and returns a string representation of this instance for the current thread.</summary>
		/// <returns>The result of calling <see cref="M:System.Object.ToString" /> on the <see cref="P:System.Threading.ThreadLocal`1.Value" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
		/// <exception cref="T:System.NullReferenceException">The <see cref="P:System.Threading.ThreadLocal`1.Value" /> for the current thread is a null reference (Nothing in Visual Basic).</exception>
		/// <exception cref="T:System.InvalidOperationException">The initialization function attempted to reference <see cref="P:System.Threading.ThreadLocal`1.Value" /> recursively.</exception>
		/// <exception cref="T:System.MissingMemberException">No default constructor is provided and no value factory is supplied.</exception>
		public override string ToString()
		{
			return null;
		}

		private T GetValueSlow()
		{
			return default(T);
		}

		private void SetValueSlow(T value, LinkedSlotVolatile[] slotArray)
		{
		}

		private void CreateLinkedSlot(LinkedSlotVolatile[] slotArray, int id, T value)
		{
		}

		private void GrowTable(ref LinkedSlotVolatile[] table, int minLength)
		{
		}

		private static int GetNewTableSize(int minSize)
		{
			return 0;
		}
	}
}
