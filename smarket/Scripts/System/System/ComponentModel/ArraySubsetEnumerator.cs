using System.Collections;

namespace System.ComponentModel
{
	internal class ArraySubsetEnumerator : IEnumerator
	{
		private Array array;

		private int total;

		private int current;

		public object Current => null;

		public ArraySubsetEnumerator(Array array, int count)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}
}
