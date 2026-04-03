using System;
using System.Reflection;
using Unity.Collections;

namespace UnityEngine.LowLevelPhysics2D
{
	public readonly struct PhysicsWorld : IEquatable<PhysicsWorld>
	{
		public enum SimulationType
		{
			FixedUpdate = 0,
			Update = 1,
			Script = 2
		}

		public enum TransformWriteMode
		{
			Off = 0,
			Fast2D = 1,
			Slow3D = 2
		}

		public enum TransformPlane
		{
			XY = 0,
			XZ = 1,
			ZY = 2
		}

		[Flags]
		public enum DrawOptions
		{
			Off = 0,
			SelectedBodies = 1,
			SelectedShapes = 2,
			SelectedShapeBounds = 4,
			SelectedJoints = 8,
			AllBodies = 0x10,
			AllShapes = 0x20,
			AllShapeBounds = 0x40,
			AllJoints = 0x80,
			AllContactPoints = 0x100,
			AllContactNormal = 0x200,
			AllContactImpulse = 0x400,
			AllContactFriction = 0x800,
			AllCustom = 0x1000,
			AllSolverIslands = 0x2000,
			DefaultAll = 0x10A0,
			DefaultSelected = 0x100A
		}

		[Flags]
		public enum DrawFillOptions
		{
			Interior = 1,
			Outline = 2,
			Orientation = 4,
			All = 7
		}

		internal readonly struct DrawResults
		{
			public readonly struct PolygonGeometryElement
			{
				public readonly PhysicsTransform transform;

				public readonly Vector2 p0;

				public readonly Vector2 p1;

				public readonly Vector2 p2;

				public readonly Vector2 p3;

				public readonly Vector2 p4;

				public readonly Vector2 p5;

				public readonly Vector2 p6;

				public readonly Vector2 p7;

				public readonly int count;

				public readonly float radius;

				public readonly float elementDepth;

				public readonly DrawFillOptions drawFillOptions;

				public readonly Color color;

				public static int Size()
				{
					return 0;
				}
			}

			public readonly struct CircleGeometryElement
			{
				public readonly PhysicsTransform transform;

				public readonly float radius;

				public readonly float elementDepth;

				public readonly DrawFillOptions drawFillOptions;

				public readonly Color color;

				public static int Size()
				{
					return 0;
				}
			}

			public readonly struct CapsuleGeometryElement
			{
				public readonly PhysicsTransform transform;

				public readonly float radius;

				public readonly float length;

				public readonly float elementDepth;

				public readonly DrawFillOptions drawFillOptions;

				public readonly Color color;

				public static int Size()
				{
					return 0;
				}
			}

			public readonly struct LineElement
			{
				public readonly PhysicsTransform transform;

				public readonly float length;

				public readonly float elementDepth;

				public readonly Color color;

				public static int Size()
				{
					return 0;
				}
			}

			public readonly struct PointElement
			{
				public readonly Vector2 position;

				public readonly float radius;

				public readonly float elementDepth;

				public readonly Color color;

				public static int Size()
				{
					return 0;
				}
			}

			internal readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_PolygonGeometryElements;

			internal readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_CircleGeometryElements;

			internal readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_CapsuleGeometryElements;

			internal readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_LineElements;

			internal readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_PointElements;

			public NativeArray<PolygonGeometryElement> polygonGeometryArray => default(NativeArray<PolygonGeometryElement>);

			public NativeArray<CircleGeometryElement> circleGeometryArray => default(NativeArray<CircleGeometryElement>);

			public NativeArray<CapsuleGeometryElement> capsuleGeometryArray => default(NativeArray<CapsuleGeometryElement>);

			public NativeArray<LineElement> lineArray => default(NativeArray<LineElement>);

			public NativeArray<PointElement> pointArray => default(NativeArray<PointElement>);

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public struct DrawColors
		{
			[DefaultMember("Item")]
			private struct ConstraintGraphArray
			{
				public Color graphConstraint0;

				public Color graphConstraint1;

				public Color graphConstraint2;

				public Color graphConstraint3;

				public Color graphConstraint4;

				public Color graphConstraint5;

				public Color graphConstraint6;

				public Color graphConstraint7;

				public Color graphConstraint8;

				public Color graphConstraint9;

				public Color graphConstraint10;

				public Color graphConstraint11;

				public Color graphConstraint12;

				public Color graphConstraint13;

				public Color graphConstraint14;

				public Color graphConstraint15;

				public Color graphConstraint16;

				public Color graphConstraint17;

				public Color graphConstraint18;

				public Color graphConstraint19;

				public Color graphConstraint20;

				public Color graphConstraint21;

				public Color graphConstraint22;

				public Color graphConstraint23;
			}

			public Color transformAxisX;

			public Color transformAxisY;

			public Color bodyBad;

			public Color bodyDisabled;

			public Color bodyAwake;

			public Color bodyStatic;

			public Color bodyKinematic;

			public Color bodyTimeOfImpactEvent;

			public Color bodyFastCollisions;

			public Color bodyMovingFast;

			public Color bodySpeedCapped;

			public Color shapeTrigger;

			public Color shapeOther;

			public Color shapeBounds;

			public Color contactSpeculative;

			public Color contactAdded;

			public Color contactPersisted;

			public Color contactNormal;

			public Color contactImpulse;

			public Color contactFriction;

			public Color solverIsland;

			private readonly ConstraintGraphArray m_ConstraintGraph;
		}

		internal readonly ushort m_Index1;

		private readonly ushort m_Generation;

		public static bool bypassLowLevel => false;

		public static bool isRenderingAllowed => false;

		public bool isValid => false;

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(PhysicsWorld other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal void SetTransformWriteTweens(ReadOnlySpan<PhysicsBody.TransformWriteTween> transformWriteTweens)
		{
		}

		public void SendBodyUpdateCallbacks()
		{
		}

		public void SendContactCallbacks()
		{
		}

		public void SendTriggerCallbacks()
		{
		}

		public void SendJointThresholdCallbacks()
		{
		}

		internal static void DrawAllWorlds(PhysicsAABB drawAABB)
		{
		}
	}
}
