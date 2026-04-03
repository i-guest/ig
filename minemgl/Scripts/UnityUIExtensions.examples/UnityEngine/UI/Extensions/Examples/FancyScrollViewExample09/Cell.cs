using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample09
{
	internal class Cell : FancyCell<ItemData>
	{
		private readonly EasingFunction alphaEasing = Easing.Get(Ease.OutQuint);

		[SerializeField]
		private Text title;

		[SerializeField]
		private Text description;

		[SerializeField]
		private RawImage image;

		[SerializeField]
		private Image background;

		[SerializeField]
		private CanvasGroup canvasGroup;

		private ItemData data;

		public override void UpdateContent(ItemData itemData)
		{
			data = itemData;
			image.texture = null;
			TextureLoader.Load(itemData.Url, delegate((string Url, Texture Texture) result)
			{
				if (!(image == null) && !(result.Url != data.Url))
				{
					image.texture = result.Texture;
				}
			});
			title.text = itemData.Title;
			description.text = itemData.Description;
			UpdateSibling();
		}

		private void UpdateSibling()
		{
			IEnumerable<Cell> source = from Transform t in base.transform.parent
				select t.GetComponent<Cell>() into cell
				where cell.IsVisible
				select cell;
			if (base.Index == source.Min((Cell x) => x.Index))
			{
				base.transform.SetAsLastSibling();
			}
			if (base.Index == source.Max((Cell x) => x.Index))
			{
				base.transform.SetAsFirstSibling();
			}
		}

		public override void UpdatePosition(float t)
		{
			t = 1f - t;
			float num = Mathf.Min(0.75f, t) / 0.75f;
			float num2 = Mathf.Max(0f, t - 0.75f) / 0.25f;
			base.transform.localRotation = ((t < 0.75f) ? Quaternion.Euler(0f, 0f, -15f * (1f - num)) : Quaternion.Euler(0f, 0f, 25f * num2));
			base.transform.localPosition = Vector3.left * 500f * num2;
			canvasGroup.alpha = alphaEasing(1f - num2);
			background.color = Color.Lerp(Color.gray, Color.white, num);
		}
	}
}
