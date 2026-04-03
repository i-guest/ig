using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Rigidbody2D : Component
	{
		public Vector2 position
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 linearVelocity
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float angularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useAutoMass => false;

		public float mass => 0f;

		public RigidbodyType2D bodyType => default(RigidbodyType2D);

		public RigidbodyConstraints2D constraints
		{
			get
			{
				return default(RigidbodyConstraints2D);
			}
			set
			{
			}
		}

		public Matrix4x4 localToWorldMatrix => default(Matrix4x4);

		[ExcludeFromDocs]
		[Obsolete("isKinematic has been deprecated. Please use bodyType.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool isKinematic => false;

		public void MovePosition(Vector2 position)
		{
		}

		public void MoveRotation(float angle)
		{
		}

		[NativeMethod("MoveRotation")]
		private void MoveRotation_Angle(float angle)
		{
		}

		[ExcludeFromDocs]
		public void AddForce(Vector2 force)
		{
		}

		[NativeMethod("AddForce")]
		private void AddForce_Internal(Vector2 force, [UnityEngine.Internal.DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}

		private static void get_position_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_position_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static float get_rotation_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_rotation_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void MovePosition_Injected(IntPtr _unity_self, [In] ref Vector2 position)
		{
		}

		private static void MoveRotation_Angle_Injected(IntPtr _unity_self, float angle)
		{
		}

		private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void set_linearVelocity_Injected(IntPtr _unity_self, [In] ref Vector2 value)
		{
		}

		private static float get_angularVelocity_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_angularVelocity_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_useAutoMass_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static float get_mass_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static RigidbodyType2D get_bodyType_Injected(IntPtr _unity_self)
		{
			return default(RigidbodyType2D);
		}

		private static RigidbodyConstraints2D get_constraints_Injected(IntPtr _unity_self)
		{
			return default(RigidbodyConstraints2D);
		}

		private static void set_constraints_Injected(IntPtr _unity_self, RigidbodyConstraints2D value)
		{
		}

		private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void AddForce_Internal_Injected(IntPtr _unity_self, [In] ref Vector2 force, [UnityEngine.Internal.DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}
	}
}
