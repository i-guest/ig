namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample02
{
	internal class Cell : FancyCell<ItemData, Context>
	{
		private static class AnimatorHash
		{
			public static readonly int Scroll = Animator.StringToHash("scroll");
		}

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private Text message;

		[SerializeField]
		private Image image;

		[SerializeField]
		private Button button;

		private float currentPosition;

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

		public override void UpdatePosition(float position)
		{
			currentPosition = position;
			if (animator.isActiveAndEnabled)
			{
				animator.Play(AnimatorHash.Scroll, -1, position);
			}
			animator.speed = 0f;
		}

		private void OnEnable()
		{
			UpdatePosition(currentPosition);
		}
	}
}
