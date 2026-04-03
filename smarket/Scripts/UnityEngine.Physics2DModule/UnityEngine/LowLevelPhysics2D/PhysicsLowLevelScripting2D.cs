using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.LowLevelPhysics2D
{
	[NativeHeader("Modules/Physics2D/LowLevel/PhysicsLowLevel2D.h")]
	[NativeHeader("Modules/Physics2D/LowLevel/PhysicsWorldManager2D.h")]
	[StaticAccessor("PhysicsLowLevel2D", StaticAccessorType.DoubleColon)]
	internal static class PhysicsLowLevelScripting2D
	{
		internal struct PhysicsBuffer : IDisposable
		{
			private IntPtr m_Buffer;

			private int m_Size;

			private Allocator m_Allocator;

			public readonly bool IsEmpty => false;

			public readonly NativeArray<T> ToNativeArray<T>() where T : struct
			{
				return default(NativeArray<T>);
			}

			public readonly Span<T> ToSpan<T>() where T : struct
			{
				return default(Span<T>);
			}

			public readonly ReadOnlySpan<T> ToReadOnlySpan<T>() where T : struct
			{
				return default(ReadOnlySpan<T>);
			}

			public void Dispose()
			{
			}

			public override readonly string ToString()
			{
				return null;
			}
		}

		[NativeMethod(Name = "PhysicsBody::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsBodyDefinition PhysicsBody_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsBodyDefinition);
		}

		[NativeMethod(Name = "PhysicsBody::IsValid", IsThreadSafe = true)]
		internal static bool PhysicsBody_IsValid(PhysicsBody body)
		{
			return false;
		}

		[NativeMethod(Name = "PhysicsBody::GetBodyType", IsThreadSafe = true)]
		internal static PhysicsBody.BodyType PhysicsBody_GetBodyType(PhysicsBody body)
		{
			return default(PhysicsBody.BodyType);
		}

		[NativeMethod(Name = "PhysicsBody::GetCallbackTarget", IsThreadSafe = true)]
		internal static object PhysicsBody_GetCallbackTarget(PhysicsBody body)
		{
			return null;
		}

		[NativeMethod(Name = "PhysicsChain::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsChainDefinition PhysicsChain_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsChainDefinition);
		}

		[NativeMethod(Name = "PhysicsJoint::IsValid", IsThreadSafe = true)]
		internal static bool PhysicsJoint_IsValid(PhysicsJoint joint)
		{
			return false;
		}

		[NativeMethod(Name = "PhysicsJoint::GetJointType", IsThreadSafe = true)]
		internal static PhysicsJoint.JointType PhysicsJoint_GetJointType(PhysicsJoint joint)
		{
			return default(PhysicsJoint.JointType);
		}

		[NativeMethod(Name = "PhysicsJoint::GetCallbackTarget", IsThreadSafe = true)]
		internal static object PhysicsJoint_GetCallbackTarget(PhysicsJoint joint)
		{
			return null;
		}

		[NativeMethod(Name = "PhysicsDistanceJoint::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsDistanceJointDefinition DistanceJoint_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsDistanceJointDefinition);
		}

		[NativeMethod(Name = "PhysicsRelativeJoint::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsRelativeJointDefinition RelativeJoint_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsRelativeJointDefinition);
		}

		[NativeMethod(Name = "PhysicsSliderJoint::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsSliderJointDefinition SliderJoint_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsSliderJointDefinition);
		}

		[NativeMethod(Name = "PhysicsHingeJoint::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsHingeJointDefinition HingeJoint_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsHingeJointDefinition);
		}

		[NativeMethod(Name = "PhysicsFixedJoint::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsFixedJointDefinition FixedJoint_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsFixedJointDefinition);
		}

		[NativeMethod(Name = "PhysicsWheelJoint::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsWheelJointDefinition WheelJoint_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsWheelJointDefinition);
		}

		[NativeMethod(Name = "PhysicsRotate::Create", IsThreadSafe = true)]
		internal static PhysicsRotate PhysicsRotate_CreateDirection(in Vector2 direction)
		{
			return default(PhysicsRotate);
		}

		[NativeMethod(Name = "PhysicsRotate::Create", IsThreadSafe = true)]
		internal static PhysicsRotate PhysicsRotate_CreateAngle(float angle)
		{
			return default(PhysicsRotate);
		}

		[NativeMethod(Name = "PhysicsRotate::IsValid", IsThreadSafe = true)]
		internal static bool PhysicsRotate_IsValid(PhysicsRotate rotation)
		{
			return false;
		}

		[NativeMethod(Name = "PhysicsRotate::GetAngle", IsThreadSafe = true)]
		internal static float PhysicsRotate_GetAngle(PhysicsRotate rotate)
		{
			return 0f;
		}

		[NativeMethod(Name = "PhysicsAABB::IsValid", IsThreadSafe = true)]
		internal static bool PhysicsAABB_IsValid(PhysicsAABB aabb)
		{
			return false;
		}

		[NativeMethod(Name = "PhysicsMath::Atan2", IsThreadSafe = true)]
		internal static float PhysicsMath_Atan2(float y, float x)
		{
			return 0f;
		}

		[StaticAccessor("GetPhysicsLowLevel2D()", StaticAccessorType.Arrow)]
		[NativeMethod(Name = "PhysicsLowLevel2D::GetBypassLowLevel")]
		internal static bool PhysicsGlobal_GetBypassLowLevel()
		{
			return false;
		}

		[StaticAccessor("GetPhysicsLowLevel2D()", StaticAccessorType.Arrow)]
		[NativeMethod(Name = "PhysicsLowLevel2D::IsRenderingAllowed")]
		internal static bool PhysicsGlobal_IsRenderingAllowed()
		{
			return false;
		}

		[NativeMethod(Name = "PhysicsWorldManager2D::PopulateWorldTransformWrite")]
		[StaticAccessor("GetPhysicsLowLevel2D()->GetWorldManager2D()", StaticAccessorType.Arrow)]
		internal static int PhysicsGlobal_PopulateWorldTransformWrite(PhysicsWorld world, IntPtr transformAccessArrayIntPtr, Span<PhysicsBody.TransformWriteTween> transformWriteTweensArray)
		{
			return 0;
		}

		[NativeMethod(Name = "PhysicsShape::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsShapeDefinition PhysicsShape_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsShapeDefinition);
		}

		[NativeMethod(Name = "PhysicsShape::GetDefaultSurfaceMaterial", IsThreadSafe = true)]
		internal static PhysicsShape.SurfaceMaterial PhysicsShape_GetDefaultSurfaceMaterial()
		{
			return default(PhysicsShape.SurfaceMaterial);
		}

		[NativeMethod(Name = "PhysicsShape::IsValid", IsThreadSafe = true)]
		internal static bool PhysicsShape_IsValid(PhysicsShape shape)
		{
			return false;
		}

		[NativeMethod(Name = "PhysicsShape::GetShapeType", IsThreadSafe = true)]
		internal static PhysicsShape.ShapeType PhysicsShape_GetShapeType(PhysicsShape shape)
		{
			return default(PhysicsShape.ShapeType);
		}

		[NativeMethod(Name = "PhysicsShape::GetCallbackTarget", IsThreadSafe = true)]
		internal static object PhysicsShape_GetCallbackTarget(PhysicsShape shape)
		{
			return null;
		}

		[NativeMethod(Name = "PhysicsLowLevel2D::PhysicsContactId::IsValid", IsThreadSafe = true)]
		internal static bool PhysicsContactId_IsValid(PhysicsShape.ContactId contactId)
		{
			return false;
		}

		[NativeMethod(Name = "PhysicsWorld::GetDefaultDefinition", IsThreadSafe = true)]
		internal static PhysicsWorldDefinition PhysicsWorld_GetDefaultDefinition(bool useSettings)
		{
			return default(PhysicsWorldDefinition);
		}

		[NativeMethod(Name = "PhysicsWorld::IsValid", IsThreadSafe = true)]
		internal static bool PhysicsWorld_IsValid(PhysicsWorld world)
		{
			return false;
		}

		[NativeMethod(Name = "PhysicsWorld::SetTransformWriteTweens", IsThreadSafe = true)]
		internal static void PhysicsWorld_SetTransformWriteTweens(PhysicsWorld world, ReadOnlySpan<PhysicsBody.TransformWriteTween> transformWriteTweens)
		{
		}

		[NativeMethod(Name = "PhysicsWorld::GetBodyUpdateCallbackTargets", IsThreadSafe = true)]
		internal static PhysicsCallbacks.BodyUpdateCallbackTargets PhysicsWorld_GetBodyUpdateCallbackTargets(PhysicsWorld world, Allocator allocator)
		{
			return default(PhysicsCallbacks.BodyUpdateCallbackTargets);
		}

		[NativeMethod(Name = "PhysicsWorld::GetTriggerCallbackTargets", IsThreadSafe = true)]
		internal static PhysicsCallbacks.TriggerCallbackTargets PhysicsWorld_GetTriggerCallbackTargets(PhysicsWorld world, Allocator allocator)
		{
			return default(PhysicsCallbacks.TriggerCallbackTargets);
		}

		[NativeMethod(Name = "PhysicsWorld::GetContactCallbackTargets", IsThreadSafe = true)]
		internal static PhysicsCallbacks.ContactCallbackTargets PhysicsWorld_GetContactCallbackTargets(PhysicsWorld world, Allocator allocator)
		{
			return default(PhysicsCallbacks.ContactCallbackTargets);
		}

		[NativeMethod(Name = "PhysicsWorld::GetJointThresholdCallbackTargets", IsThreadSafe = true)]
		internal static PhysicsCallbacks.JointThresholdCallbackTargets PhysicsWorld_GetJointThresholdCallbackTargets(PhysicsWorld world, Allocator allocator)
		{
			return default(PhysicsCallbacks.JointThresholdCallbackTargets);
		}

		[NativeMethod(Name = "PhysicsWorld::GetRenderMaterial", IsThreadSafe = true)]
		internal static Material PhysicsWorld_GetRenderMaterial(string editorResourceName, string playerResourceName)
		{
			return null;
		}

		[NativeMethod(Name = "PhysicsWorld::DrawAllWorlds")]
		internal static void PhysicsWorld_DrawAllWorlds(PhysicsAABB drawAABB)
		{
		}

		private static void PhysicsBody_GetDefaultDefinition_Injected(bool useSettings, out PhysicsBodyDefinition ret)
		{
			ret = default(PhysicsBodyDefinition);
		}

		private static bool PhysicsBody_IsValid_Injected([In] ref PhysicsBody body)
		{
			return false;
		}

		private static PhysicsBody.BodyType PhysicsBody_GetBodyType_Injected([In] ref PhysicsBody body)
		{
			return default(PhysicsBody.BodyType);
		}

		private static object PhysicsBody_GetCallbackTarget_Injected([In] ref PhysicsBody body)
		{
			return null;
		}

		private static void PhysicsChain_GetDefaultDefinition_Injected(bool useSettings, out PhysicsChainDefinition ret)
		{
			ret = default(PhysicsChainDefinition);
		}

		private static bool PhysicsJoint_IsValid_Injected([In] ref PhysicsJoint joint)
		{
			return false;
		}

		private static PhysicsJoint.JointType PhysicsJoint_GetJointType_Injected([In] ref PhysicsJoint joint)
		{
			return default(PhysicsJoint.JointType);
		}

		private static object PhysicsJoint_GetCallbackTarget_Injected([In] ref PhysicsJoint joint)
		{
			return null;
		}

		private static void DistanceJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsDistanceJointDefinition ret)
		{
			ret = default(PhysicsDistanceJointDefinition);
		}

		private static void RelativeJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsRelativeJointDefinition ret)
		{
			ret = default(PhysicsRelativeJointDefinition);
		}

		private static void SliderJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsSliderJointDefinition ret)
		{
			ret = default(PhysicsSliderJointDefinition);
		}

		private static void HingeJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsHingeJointDefinition ret)
		{
			ret = default(PhysicsHingeJointDefinition);
		}

		private static void FixedJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsFixedJointDefinition ret)
		{
			ret = default(PhysicsFixedJointDefinition);
		}

		private static void WheelJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsWheelJointDefinition ret)
		{
			ret = default(PhysicsWheelJointDefinition);
		}

		private static void PhysicsRotate_CreateDirection_Injected(in Vector2 direction, out PhysicsRotate ret)
		{
			ret = default(PhysicsRotate);
		}

		private static void PhysicsRotate_CreateAngle_Injected(float angle, out PhysicsRotate ret)
		{
			ret = default(PhysicsRotate);
		}

		private static bool PhysicsRotate_IsValid_Injected([In] ref PhysicsRotate rotation)
		{
			return false;
		}

		private static float PhysicsRotate_GetAngle_Injected([In] ref PhysicsRotate rotate)
		{
			return 0f;
		}

		private static bool PhysicsAABB_IsValid_Injected([In] ref PhysicsAABB aabb)
		{
			return false;
		}

		private static int PhysicsGlobal_PopulateWorldTransformWrite_Injected([In] ref PhysicsWorld world, IntPtr transformAccessArrayIntPtr, ref ManagedSpanWrapper transformWriteTweensArray)
		{
			return 0;
		}

		private static void PhysicsShape_GetDefaultDefinition_Injected(bool useSettings, out PhysicsShapeDefinition ret)
		{
			ret = default(PhysicsShapeDefinition);
		}

		private static void PhysicsShape_GetDefaultSurfaceMaterial_Injected(out PhysicsShape.SurfaceMaterial ret)
		{
			ret = default(PhysicsShape.SurfaceMaterial);
		}

		private static bool PhysicsShape_IsValid_Injected([In] ref PhysicsShape shape)
		{
			return false;
		}

		private static PhysicsShape.ShapeType PhysicsShape_GetShapeType_Injected([In] ref PhysicsShape shape)
		{
			return default(PhysicsShape.ShapeType);
		}

		private static object PhysicsShape_GetCallbackTarget_Injected([In] ref PhysicsShape shape)
		{
			return null;
		}

		private static bool PhysicsContactId_IsValid_Injected([In] ref PhysicsShape.ContactId contactId)
		{
			return false;
		}

		private static void PhysicsWorld_GetDefaultDefinition_Injected(bool useSettings, out PhysicsWorldDefinition ret)
		{
			ret = default(PhysicsWorldDefinition);
		}

		private static bool PhysicsWorld_IsValid_Injected([In] ref PhysicsWorld world)
		{
			return false;
		}

		private static void PhysicsWorld_SetTransformWriteTweens_Injected([In] ref PhysicsWorld world, ref ManagedSpanWrapper transformWriteTweens)
		{
		}

		private static void PhysicsWorld_GetBodyUpdateCallbackTargets_Injected([In] ref PhysicsWorld world, Allocator allocator, out PhysicsCallbacks.BodyUpdateCallbackTargets ret)
		{
			ret = default(PhysicsCallbacks.BodyUpdateCallbackTargets);
		}

		private static void PhysicsWorld_GetTriggerCallbackTargets_Injected([In] ref PhysicsWorld world, Allocator allocator, out PhysicsCallbacks.TriggerCallbackTargets ret)
		{
			ret = default(PhysicsCallbacks.TriggerCallbackTargets);
		}

		private static void PhysicsWorld_GetContactCallbackTargets_Injected([In] ref PhysicsWorld world, Allocator allocator, out PhysicsCallbacks.ContactCallbackTargets ret)
		{
			ret = default(PhysicsCallbacks.ContactCallbackTargets);
		}

		private static void PhysicsWorld_GetJointThresholdCallbackTargets_Injected([In] ref PhysicsWorld world, Allocator allocator, out PhysicsCallbacks.JointThresholdCallbackTargets ret)
		{
			ret = default(PhysicsCallbacks.JointThresholdCallbackTargets);
		}

		private static IntPtr PhysicsWorld_GetRenderMaterial_Injected(ref ManagedSpanWrapper editorResourceName, ref ManagedSpanWrapper playerResourceName)
		{
			return (IntPtr)0;
		}

		private static void PhysicsWorld_DrawAllWorlds_Injected([In] ref PhysicsAABB drawAABB)
		{
		}
	}
}
