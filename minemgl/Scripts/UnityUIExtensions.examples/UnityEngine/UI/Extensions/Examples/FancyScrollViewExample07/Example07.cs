using System;
using System.Linq;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample07
{
	internal class Example07 : MonoBehaviour
	{
		[SerializeField]
		private ScrollView scrollView;

		[SerializeField]
		private InputField paddingTopInputField;

		[SerializeField]
		private InputField paddingBottomInputField;

		[SerializeField]
		private InputField spacingInputField;

		[SerializeField]
		private InputField dataCountInputField;

		[SerializeField]
		private InputField selectIndexInputField;

		[SerializeField]
		private Dropdown alignmentDropdown;

		private void Start()
		{
			scrollView.OnCellClicked(delegate(int index)
			{
				selectIndexInputField.text = index.ToString();
			});
			paddingTopInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(paddingTopInputField, 0, 999, delegate(int value)
				{
					scrollView.PaddingTop = value;
				});
			});
			paddingTopInputField.text = scrollView.PaddingTop.ToString();
			paddingBottomInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(paddingBottomInputField, 0, 999, delegate(int value)
				{
					scrollView.PaddingBottom = value;
				});
			});
			paddingBottomInputField.text = scrollView.PaddingBottom.ToString();
			spacingInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(spacingInputField, 0, 100, delegate(int value)
				{
					scrollView.Spacing = value;
				});
			});
			spacingInputField.text = scrollView.Spacing.ToString();
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
			selectIndexInputField.text = "10";
			dataCountInputField.onValueChanged.AddListener(delegate
			{
				TryParseValue(dataCountInputField, 1, 99999, GenerateCells);
			});
			dataCountInputField.text = "20";
			scrollView.JumpTo(10);
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
			if (scrollView.DataCount != 0)
			{
				TryParseValue(selectIndexInputField, 0, scrollView.DataCount - 1, delegate(int index)
				{
					scrollView.ScrollTo(index, 0.3f, Ease.InOutQuint, (Alignment)alignmentDropdown.value);
				});
			}
		}

		private void GenerateCells(int dataCount)
		{
			ItemData[] items = (from i in Enumerable.Range(0, dataCount)
				select new ItemData($"Cell {i}")).ToArray();
			scrollView.UpdateData(items);
			SelectCell();
		}
	}
}
