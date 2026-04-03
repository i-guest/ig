using System;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample05
{
	internal class Context
	{
		public int SelectedIndex = -1;

		public Action<int> OnCellClicked;

		public Action UpdateCellState;

		public Vector4[] CellState = new Vector4[1];

		public void SetCellState(int cellIndex, int dataIndex, float x, float y, float selectAnimation)
		{
			int num = cellIndex + 1;
			if (num > CellState.Length)
			{
				Array.Resize(ref CellState, num);
			}
			CellState[cellIndex].x = x;
			CellState[cellIndex].y = y;
			CellState[cellIndex].z = dataIndex;
			CellState[cellIndex].w = selectAnimation;
		}
	}
}
