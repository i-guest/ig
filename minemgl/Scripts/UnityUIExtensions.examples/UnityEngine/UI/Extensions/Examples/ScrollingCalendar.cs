using System;

namespace UnityEngine.UI.Extensions.Examples
{
	public class ScrollingCalendar : MonoBehaviour
	{
		public RectTransform monthsScrollingPanel;

		public RectTransform yearsScrollingPanel;

		public RectTransform daysScrollingPanel;

		public ScrollRect monthsScrollRect;

		public ScrollRect yearsScrollRect;

		public ScrollRect daysScrollRect;

		public GameObject yearsButtonPrefab;

		public GameObject monthsButtonPrefab;

		public GameObject daysButtonPrefab;

		private GameObject[] monthsButtons;

		private GameObject[] yearsButtons;

		private GameObject[] daysButtons;

		public RectTransform monthCenter;

		public RectTransform yearsCenter;

		public RectTransform daysCenter;

		private UIVerticalScroller yearsVerticalScroller;

		private UIVerticalScroller monthsVerticalScroller;

		private UIVerticalScroller daysVerticalScroller;

		public InputField inputFieldDays;

		public InputField inputFieldMonths;

		public InputField inputFieldYears;

		public Text dateText;

		private int daysSet;

		private int monthsSet;

		private int yearsSet;

		private void InitializeYears()
		{
			int[] array = new int[int.Parse(DateTime.Now.ToString("yyyy")) + 1 - 1900];
			yearsButtons = new GameObject[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 1900 + i;
				GameObject gameObject = Object.Instantiate(yearsButtonPrefab, yearsScrollingPanel);
				gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject.GetComponentInChildren<Text>().text = array[i].ToString() ?? "";
				gameObject.name = "Year_" + array[i];
				gameObject.AddComponent<CanvasGroup>();
				yearsButtons[i] = gameObject;
			}
		}

		private void InitializeMonths()
		{
			int[] array = new int[12];
			monthsButtons = new GameObject[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				string text = "";
				array[i] = i;
				GameObject gameObject = Object.Instantiate(monthsButtonPrefab, monthsScrollingPanel);
				gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
				switch (i)
				{
				case 0:
					text = "Jan";
					break;
				case 1:
					text = "Feb";
					break;
				case 2:
					text = "Mar";
					break;
				case 3:
					text = "Apr";
					break;
				case 4:
					text = "May";
					break;
				case 5:
					text = "Jun";
					break;
				case 6:
					text = "Jul";
					break;
				case 7:
					text = "Aug";
					break;
				case 8:
					text = "Sep";
					break;
				case 9:
					text = "Oct";
					break;
				case 10:
					text = "Nov";
					break;
				case 11:
					text = "Dec";
					break;
				}
				gameObject.GetComponentInChildren<Text>().text = text;
				gameObject.name = "Month_" + array[i];
				gameObject.AddComponent<CanvasGroup>();
				monthsButtons[i] = gameObject;
			}
		}

		private void InitializeDays()
		{
			int[] array = new int[31];
			daysButtons = new GameObject[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i + 1;
				GameObject gameObject = Object.Instantiate(daysButtonPrefab, daysScrollingPanel);
				gameObject.GetComponentInChildren<Text>().text = array[i].ToString() ?? "";
				gameObject.name = "Day_" + array[i];
				gameObject.AddComponent<CanvasGroup>();
				daysButtons[i] = gameObject;
			}
		}

		public void Awake()
		{
			InitializeYears();
			InitializeMonths();
			InitializeDays();
			monthsVerticalScroller = new UIVerticalScroller(monthCenter, monthCenter, monthsScrollRect, monthsButtons);
			yearsVerticalScroller = new UIVerticalScroller(yearsCenter, yearsCenter, yearsScrollRect, yearsButtons);
			daysVerticalScroller = new UIVerticalScroller(daysCenter, daysCenter, daysScrollRect, daysButtons);
			monthsVerticalScroller.Start();
			yearsVerticalScroller.Start();
			daysVerticalScroller.Start();
		}

		public void SetDate()
		{
			daysSet = int.Parse(inputFieldDays.text) - 1;
			monthsSet = int.Parse(inputFieldMonths.text) - 1;
			yearsSet = int.Parse(inputFieldYears.text) - 1900;
			daysVerticalScroller.SnapToElement(daysSet);
			monthsVerticalScroller.SnapToElement(monthsSet);
			yearsVerticalScroller.SnapToElement(yearsSet);
		}

		private void Update()
		{
			monthsVerticalScroller.Update();
			yearsVerticalScroller.Update();
			daysVerticalScroller.Update();
			string result = daysVerticalScroller.Result;
			string result2 = monthsVerticalScroller.Result;
			string result3 = yearsVerticalScroller.Result;
			result = ((result.EndsWith("1") && result != "11") ? (result + "st") : ((result.EndsWith("2") && result != "12") ? (result + "nd") : ((!result.EndsWith("3") || !(result != "13")) ? (result + "th") : (result + "rd"))));
			dateText.text = result2 + " " + result + " " + result3;
		}

		public void DaysScrollUp()
		{
			daysVerticalScroller.ScrollUp();
		}

		public void DaysScrollDown()
		{
			daysVerticalScroller.ScrollDown();
		}

		public void MonthsScrollUp()
		{
			monthsVerticalScroller.ScrollUp();
		}

		public void MonthsScrollDown()
		{
			monthsVerticalScroller.ScrollDown();
		}

		public void YearsScrollUp()
		{
			yearsVerticalScroller.ScrollUp();
		}

		public void YearsScrollDown()
		{
			yearsVerticalScroller.ScrollDown();
		}
	}
}
