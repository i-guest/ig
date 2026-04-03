using System;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample07
{
	internal class Cell : FancyScrollRectCell<ItemData, Context>
	{
		[SerializeField]
		private Text message;

		[SerializeField]
		private Image image;

		[SerializeField]
		private Button button;

		public override void Initialize()
		{
			button.onClick.AddListener(delegate
			{
				base.Context.OnCellClicked?.Invoke(base.Index);
			});
		}

		public override void UpdateContent(ItemData itemData)
		{
			message.text = itemData.Message;
			bool flag = base.Context.SelectedIndex == base.Index;
			image.color = (flag ? new Color32(0, byte.MaxValue, byte.MaxValue, 100) : new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 77));
		}

		protected override void UpdatePosition(float normalizedPosition, float localPosition)
		{
			base.UpdatePosition(normalizedPosition, localPosition);
			float num = Mathf.Sin(normalizedPosition * MathF.PI * 2f) * 65f;
			base.transform.localPosition += Vector3.right * num;
		}
	}
}
