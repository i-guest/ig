namespace UnityEngine.UI.Extensions.Examples
{
	[RequireComponent(typeof(UILineRendererList))]
	public class LineRendererOrbitList : MonoBehaviour
	{
		private UILineRendererList lr;

		private Circle circle;

		public GameObject OrbitGO;

		private RectTransform orbitGOrt;

		private float orbitTime;

		[SerializeField]
		private float _xAxis = 3f;

		[SerializeField]
		private float _yAxis = 3f;

		[SerializeField]
		private int _steps = 10;

		public float xAxis
		{
			get
			{
				return _xAxis;
			}
			set
			{
				_xAxis = value;
				GenerateOrbit();
			}
		}

		public float yAxis
		{
			get
			{
				return _yAxis;
			}
			set
			{
				_yAxis = value;
				GenerateOrbit();
			}
		}

		public int Steps
		{
			get
			{
				return _steps;
			}
			set
			{
				_steps = value;
				GenerateOrbit();
			}
		}

		private void Awake()
		{
			lr = GetComponent<UILineRendererList>();
			orbitGOrt = OrbitGO.GetComponent<RectTransform>();
			GenerateOrbit();
		}

		private void Update()
		{
			orbitTime = ((orbitTime > (float)_steps) ? (orbitTime = 0f) : (orbitTime + Time.deltaTime));
			orbitGOrt.localPosition = circle.Evaluate(orbitTime);
		}

		private void GenerateOrbit()
		{
			circle = new Circle(_xAxis, _yAxis, _steps);
			for (int i = 0; i < _steps; i++)
			{
				lr.AddPoint(circle.Evaluate(i));
			}
			lr.AddPoint(circle.Evaluate(0f));
		}

		private void OnValidate()
		{
			if (lr != null)
			{
				GenerateOrbit();
			}
		}
	}
}
