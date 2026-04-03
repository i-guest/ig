using System;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample05
{
	[ExecuteInEditMode]
	internal class Cell : FancyCell<ItemData, Context>
	{
		private static class AnimatorHash
		{
			public static readonly int Scroll = Animator.StringToHash("scroll");

			public static readonly int In = Animator.StringToHash("in");

			public static readonly int Out = Animator.StringToHash("out");
		}

		[SerializeField]
		private Animator scrollAnimator;

		[SerializeField]
		private Animator selectAnimator;

		[SerializeField]
		private Text message;

		[SerializeField]
		private Image image;

		[SerializeField]
		private Button button;

		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		[HideInInspector]
		private Vector3 position;

		private float hash;

		private bool currentSelection;

		private float updateSelectionTime;

		private float currentPosition;

		public override void Initialize()
		{
			hash = Random.value * 100f;
			button.onClick.AddListener(delegate
			{
				base.Context.OnCellClicked?.Invoke(base.Index);
			});
			Context context = base.Context;
			context.UpdateCellState = (Action)Delegate.Combine(context.UpdateCellState, (Action)delegate
			{
				int siblingIndex = rectTransform.GetSiblingIndex();
				float num = Mathf.Clamp01((Time.time - updateSelectionTime) * 3.3333333f);
				float selectAnimation = (currentSelection ? num : (1f - num));
				Vector3 vector = (IsVisible ? (position + GetFluctuation()) : (rectTransform.rect.size.x * 10f * Vector3.left));
				base.Context.SetCellState(siblingIndex, base.Index, vector.x, vector.y, selectAnimation);
			});
		}

		private void LateUpdate()
		{
			image.rectTransform.localPosition = position + GetFluctuation();
		}

		private Vector3 GetFluctuation()
		{
			float x = Mathf.Sin(Time.time + hash * 40f) * 10f;
			float y = Mathf.Sin(Time.time + hash) * 10f;
			return new Vector3(x, y, 0f);
		}

		public override void UpdateContent(ItemData cellData)
		{
			message.text = cellData.Message;
			SetSelection(base.Context.SelectedIndex == base.Index);
		}

		public override void UpdatePosition(float position)
		{
			currentPosition = position;
			if (scrollAnimator.isActiveAndEnabled)
			{
				scrollAnimator.Play(AnimatorHash.Scroll, -1, position);
			}
			scrollAnimator.speed = 0f;
		}

		private void SetSelection(bool selected)
		{
			if (currentSelection != selected)
			{
				currentSelection = selected;
				selectAnimator.SetTrigger(selected ? AnimatorHash.In : AnimatorHash.Out);
				updateSelectionTime = Time.time;
			}
		}

		private void OnEnable()
		{
			UpdatePosition(currentPosition);
		}
	}
}
