using System;
using System.Linq;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample08
{
	internal class Example08 : MonoBehaviour
	{
		[SerializeField]
		private GridView gridView;

		[SerializeField]
		private InputField paddingTopInputField;

		[SerializeField]
		private InputField paddingBottomInputField;

		[SerializeField]
		private InputField xSpacingInputField;

		[SerializeField]
		private InputField ySpacingInputField;

		[SerializeField]
		private InputField dataCountInputField;

		[SerializeField]
		private InputField selectIndexInputField;

		[SerializeField]
		private Dropdown alignmentDropdown;

		private void Start()
		{
			gridView.OnCellClicked(delegate(int index)
			{
				selectIndexInputField.text = index.ToString();
			});
			paddingTopInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(paddingTopInputField, 0, 999, delegate(int value)
				{
					gridView.PaddingTop = value;
				});
			});
			paddingTopInputField.text = gridView.PaddingTop.ToString();
			paddingBottomInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(paddingBottomInputField, 0, 999, delegate(int value)
				{
					gridView.PaddingBottom = value;
				});
			});
			paddingBottomInputField.text = gridView.PaddingBottom.ToString();
			xSpacingInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(xSpacingInputField, 0, 99, delegate(int value)
				{
					gridView.SpacingX = value;
				});
			});
			xSpacingInputField.text = gridView.SpacingX.ToString();
			ySpacingInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(ySpacingInputField, 0, 99, delegate(int value)
				{
					gridView.SpacingY = value;
				});
			});
			ySpacingInputField.text = gridView.SpacingY.ToString();
			alignmentDropdown.AddOptions((from x in Enum.GetNames(typeof(Alignment))
				select new Dropdown.OptionData(x)).ToList());
			alignmentDropdown.onValueChanged.AddListener(delegate
			{
				SelectCell();
			});
			alignmentDropdown.value = 1;
			selectIndexInputField.onValueChanged.AddListener(delegate
			{
				SelectCell();
			});
			selectIndexInputField.text = "50";
			dataCountInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(dataCountInputField, 1, 99999, GenerateCells);
			});
			dataCountInputField.text = "100";
			gridView.JumpTo(50);
		}

		private void TryParseValue(InputField inputField, int min, int max, Action<int> success)
		{
			if (int.TryParse(inputField.text, out var result))
			{
				if (result < min || result > max)
				{
					inputField.text = Mathf.Clamp(result, min, max).ToString();
				}
				else
				{
					success(result);
				}
			}
		}

		private void SelectCell()
		{
			if (gridView.DataCount != 0)
			{
				TryParseValue(selectIndexInputField, 0, gridView.DataCount - 1, delegate(int index)
				{
					gridView.UpdateSelection(index);
					gridView.ScrollTo(index, 0.4f, Ease.InOutQuint, (Alignment)alignmentDropdown.value);
				});
			}
		}

		private void GenerateCells(int dataCount)
		{
			ItemData[] items = (from i in Enumerable.Range(0, dataCount)
				select new ItemData(i)).ToArray();
			gridView.UpdateContents(items);
			SelectCell();
		}
	}
}
