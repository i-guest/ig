using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal class CameraScreenRaycaster : IScreenRaycaster
	{
		public class CameraRayEnumerator : IEnumerator<(Ray, Camera, bool)>, IEnumerator, IDisposable, IEnumerable<(Ray, Camera, bool)>, IEnumerable
		{
			private Camera[] m_Cameras;

			private int m_LayerMask;

			private Vector2 m_MousePosition;

			private int? m_TargetDisplay;

			private int m_Index;

			private Camera m_CurrentCamera;

			private Ray m_CurrentRay;

			private bool m_IsInsideCameraRect;

			public (Ray, Camera, bool) Current => default((Ray, Camera, bool));

			object IEnumerator.Current => null;

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public IEnumerator<(Ray, Camera, bool)> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			public static CameraRayEnumerator GetPooled(Camera[] cameras, int layerMask, Vector2 mousePosition, int? targetDisplay)
			{
				return null;
			}

			public void Dispose()
			{
			}
		}

		public Camera[] cameras;

		public Camera[] singleCamera;

		public int layerMask;

		public virtual void Update()
		{
		}

		public IEnumerable<(Ray, Camera, bool)> MakeRay(Vector2 mousePosition, int pointerId, int? targetDisplay)
		{
			return null;
		}

		private static bool IsValid(Camera camera, int layerMask, int? targetDisplay)
		{
			return false;
		}

		private static bool MakeRay(Camera camera, Vector2 mousePosition, out Ray ray)
		{
			ray = default(Ray);
			return false;
		}
	}
}
