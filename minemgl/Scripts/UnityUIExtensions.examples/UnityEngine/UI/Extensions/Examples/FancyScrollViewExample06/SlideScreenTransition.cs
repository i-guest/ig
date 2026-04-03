namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample06
{
	internal class SlideScreenTransition : MonoBehaviour
	{
		[SerializeField]
		private RectTransform targetTransform;

		[SerializeField]
		private GraphicRaycaster graphicRaycaster;

		private const float Duration = 0.3f;

		private bool shouldAnimate;

		private bool isOutAnimation;

		private float timer;

		private float startX;

		private float endX;

		public void In(MovementDirection direction)
		{
			Animate(direction, isOut: false);
		}

		public void Out(MovementDirection direction)
		{
			Animate(direction, isOut: true);
		}

		private void Animate(MovementDirection direction, bool isOut)
		{
			if (!shouldAnimate)
			{
				timer = 0.3f;
				isOutAnimation = isOut;
				shouldAnimate = true;
				graphicRaycaster.enabled = false;
				if (!isOutAnimation)
				{
					base.gameObject.SetActive(value: true);
				}
				switch (direction)
				{
				case MovementDirection.Left:
					endX = 0f - targetTransform.rect.width;
					break;
				case MovementDirection.Right:
					endX = targetTransform.rect.width;
					break;
				default:
					Debug.LogWarning("Example only support horizontal direction.");
					break;
				}
				startX = (isOutAnimation ? 0f : (0f - endX));
				endX = (isOutAnimation ? endX : 0f);
				UpdatePosition(0f);
			}
		}

		private void Update()
		{
			if (!shouldAnimate)
			{
				return;
			}
			timer -= Time.deltaTime;
			if (timer > 0f)
			{
				UpdatePosition(1f - timer / 0.3f);
				return;
			}
			shouldAnimate = false;
			graphicRaycaster.enabled = true;
			if (isOutAnimation)
			{
				base.gameObject.SetActive(value: false);
			}
			UpdatePosition(1f);
		}

		private void UpdatePosition(float position)
		{
			float x = Mathf.Lerp(startX, endX, position);
			targetTransform.anchoredPosition = new Vector2(x, targetTransform.anchoredPosition.y);
		}
	}
}
