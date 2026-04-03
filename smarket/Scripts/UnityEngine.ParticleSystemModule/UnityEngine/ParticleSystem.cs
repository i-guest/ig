using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[UsedByNativeCode]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	public sealed class ParticleSystem : Component
	{
		public struct MainModule
		{
			internal ParticleSystem m_ParticleSystem;

			public float duration
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool loop
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool prewarm
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startDelay
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartDelay")]
			private MinMaxCurveBlittable startDelayBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startDelayMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startLifetime
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartLifetime")]
			private MinMaxCurveBlittable startLifetimeBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startLifetimeMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startSpeed
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartSpeed")]
			private MinMaxCurveBlittable startSpeedBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startSpeedMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool startSize3D
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startSize
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartSizeX")]
			private MinMaxCurveBlittable startSizeBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			[NativeName("StartSizeXMultiplier")]
			public float startSizeMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startSizeX
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartSizeX")]
			private MinMaxCurveBlittable startSizeXBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startSizeXMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startSizeY
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartSizeY")]
			private MinMaxCurveBlittable startSizeYBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startSizeYMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startSizeZ
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartSizeZ")]
			private MinMaxCurveBlittable startSizeZBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startSizeZMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool startRotation3D
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startRotation
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartRotationZ")]
			private MinMaxCurveBlittable startRotationBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			[NativeName("StartRotationZMultiplier")]
			public float startRotationMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startRotationX
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartRotationX")]
			private MinMaxCurveBlittable startRotationXBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startRotationXMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startRotationY
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartRotationY")]
			private MinMaxCurveBlittable startRotationYBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startRotationYMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startRotationZ
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartRotationZ")]
			private MinMaxCurveBlittable startRotationZBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startRotationZMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float flipRotation
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxGradient startColor
			{
				get
				{
					return default(MinMaxGradient);
				}
				set
				{
				}
			}

			[NativeName("StartColor")]
			private MinMaxGradientBlittable startColorBlittable
			{
				get
				{
					return default(MinMaxGradientBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve gravityModifier
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("GravityModifier")]
			private MinMaxCurveBlittable gravityModifierBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float gravityModifierMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemSimulationSpace simulationSpace
			{
				get
				{
					return default(ParticleSystemSimulationSpace);
				}
				[NativeThrows]
				set
				{
				}
			}

			public Transform customSimulationSpace
			{
				get
				{
					return null;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float simulationSpeed
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemScalingMode scalingMode
			{
				get
				{
					return default(ParticleSystemScalingMode);
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool playOnAwake
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int maxParticles
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal MainModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_startDelayBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startDelayBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startLifetimeBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startLifetimeBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startSpeedBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startSpeedBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startSizeBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startSizeBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startSizeXBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startSizeXBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startSizeYBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startSizeYBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startSizeZBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startSizeZBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startRotationBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startRotationBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startRotationXBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startRotationXBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startRotationYBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startRotationYBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startRotationZBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startRotationZBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startColorBlittable_Injected(ref MainModule _unity_self, out MinMaxGradientBlittable ret)
			{
				ret = default(MinMaxGradientBlittable);
			}

			private static void set_startColorBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxGradientBlittable value)
			{
			}

			private static void get_gravityModifierBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_gravityModifierBlittable_Injected(ref MainModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static IntPtr get_customSimulationSpace_Injected(ref MainModule _unity_self)
			{
				return (IntPtr)0;
			}

			private static void set_customSimulationSpace_Injected(ref MainModule _unity_self, IntPtr value)
			{
			}
		}

		public struct EmissionModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve rateOverTime
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("RateOverTime")]
			private MinMaxCurveBlittable rateOverTimeBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float rateOverTimeMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve rateOverDistance
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("RateOverDistance")]
			private MinMaxCurveBlittable rateOverDistanceBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float rateOverDistanceMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int burstCount
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal EmissionModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			public void SetBursts(Burst[] bursts)
			{
			}

			public void SetBursts(Burst[] bursts, int size)
			{
			}

			public int GetBursts(Burst[] bursts)
			{
				return 0;
			}

			[NativeThrows]
			public void SetBurst(int index, Burst burst)
			{
			}

			[NativeThrows]
			public Burst GetBurst(int index)
			{
				return default(Burst);
			}

			private static void get_rateOverTimeBlittable_Injected(ref EmissionModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_rateOverTimeBlittable_Injected(ref EmissionModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_rateOverDistanceBlittable_Injected(ref EmissionModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_rateOverDistanceBlittable_Injected(ref EmissionModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void SetBurst_Injected(ref EmissionModule _unity_self, int index, [In] ref Burst burst)
			{
			}

			private static void GetBurst_Injected(ref EmissionModule _unity_self, int index, out Burst ret)
			{
				ret = default(Burst);
			}
		}

		public struct ShapeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemShapeType shapeType
			{
				get
				{
					return default(ParticleSystemShapeType);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float randomDirectionAmount
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float sphericalDirectionAmount
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool alignToDirection
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float radius
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float angle
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float length
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemMeshShapeType meshShapeType
			{
				get
				{
					return default(ParticleSystemMeshShapeType);
				}
				[NativeThrows]
				set
				{
				}
			}

			public Mesh mesh
			{
				get
				{
					return null;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MeshRenderer meshRenderer
			{
				get
				{
					return null;
				}
				[NativeThrows]
				set
				{
				}
			}

			public SkinnedMeshRenderer skinnedMeshRenderer
			{
				get
				{
					return null;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool useMeshMaterialIndex
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int meshMaterialIndex
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool useMeshColors
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float normalOffset
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float arc
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public Vector3 position
			{
				[NativeThrows]
				set
				{
				}
			}

			public Vector3 scale
			{
				get
				{
					return default(Vector3);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal ShapeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static IntPtr get_mesh_Injected(ref ShapeModule _unity_self)
			{
				return (IntPtr)0;
			}

			private static void set_mesh_Injected(ref ShapeModule _unity_self, IntPtr value)
			{
			}

			private static IntPtr get_meshRenderer_Injected(ref ShapeModule _unity_self)
			{
				return (IntPtr)0;
			}

			private static void set_meshRenderer_Injected(ref ShapeModule _unity_self, IntPtr value)
			{
			}

			private static IntPtr get_skinnedMeshRenderer_Injected(ref ShapeModule _unity_self)
			{
				return (IntPtr)0;
			}

			private static void set_skinnedMeshRenderer_Injected(ref ShapeModule _unity_self, IntPtr value)
			{
			}

			private static void set_position_Injected(ref ShapeModule _unity_self, [In] ref Vector3 value)
			{
			}

			private static void get_scale_Injected(ref ShapeModule _unity_self, out Vector3 ret)
			{
				ret = default(Vector3);
			}

			private static void set_scale_Injected(ref ShapeModule _unity_self, [In] ref Vector3 value)
			{
			}
		}

		public struct CollisionModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemCollisionType type
			{
				get
				{
					return default(ParticleSystemCollisionType);
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemCollisionMode mode
			{
				get
				{
					return default(ParticleSystemCollisionMode);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve dampen
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Dampen")]
			private MinMaxCurveBlittable dampenBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float dampenMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve bounce
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Bounce")]
			private MinMaxCurveBlittable bounceBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float bounceMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve lifetimeLoss
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("LifetimeLoss")]
			private MinMaxCurveBlittable lifetimeLossBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float lifetimeLossMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float minKillSpeed
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float maxKillSpeed
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public LayerMask collidesWith
			{
				get
				{
					return default(LayerMask);
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool enableDynamicColliders
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int maxCollisionShapes
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemCollisionQuality quality
			{
				get
				{
					return default(ParticleSystemCollisionQuality);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float voxelSize
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float radiusScale
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool sendCollisionMessages
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal CollisionModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_dampenBlittable_Injected(ref CollisionModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_dampenBlittable_Injected(ref CollisionModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_bounceBlittable_Injected(ref CollisionModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_bounceBlittable_Injected(ref CollisionModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_lifetimeLossBlittable_Injected(ref CollisionModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_lifetimeLossBlittable_Injected(ref CollisionModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_collidesWith_Injected(ref CollisionModule _unity_self, out LayerMask ret)
			{
				ret = default(LayerMask);
			}

			private static void set_collidesWith_Injected(ref CollisionModule _unity_self, [In] ref LayerMask value)
			{
			}
		}

		public struct TriggerModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemOverlapAction inside
			{
				get
				{
					return default(ParticleSystemOverlapAction);
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemOverlapAction outside
			{
				get
				{
					return default(ParticleSystemOverlapAction);
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemOverlapAction enter
			{
				get
				{
					return default(ParticleSystemOverlapAction);
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemOverlapAction exit
			{
				get
				{
					return default(ParticleSystemOverlapAction);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float radiusScale
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal TriggerModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}
		}

		public struct SubEmittersModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				[NativeThrows]
				set
				{
				}
			}

			public int subEmittersCount => 0;

			internal SubEmittersModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			[NativeThrows]
			public void AddSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type, ParticleSystemSubEmitterProperties properties, float emitProbability)
			{
			}

			public void AddSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type, ParticleSystemSubEmitterProperties properties)
			{
			}

			[NativeThrows]
			public void RemoveSubEmitter(int index)
			{
			}

			[NativeThrows]
			public ParticleSystem GetSubEmitterSystem(int index)
			{
				return null;
			}

			[NativeThrows]
			public ParticleSystemSubEmitterType GetSubEmitterType(int index)
			{
				return default(ParticleSystemSubEmitterType);
			}

			[NativeThrows]
			public ParticleSystemSubEmitterProperties GetSubEmitterProperties(int index)
			{
				return default(ParticleSystemSubEmitterProperties);
			}

			private static void AddSubEmitter_Injected(ref SubEmittersModule _unity_self, IntPtr subEmitter, ParticleSystemSubEmitterType type, ParticleSystemSubEmitterProperties properties, float emitProbability)
			{
			}

			private static IntPtr GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index)
			{
				return (IntPtr)0;
			}
		}

		public struct TextureSheetAnimationModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int numTilesX
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int numTilesY
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemAnimationType animation
			{
				get
				{
					return default(ParticleSystemAnimationType);
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemAnimationRowMode rowMode
			{
				get
				{
					return default(ParticleSystemAnimationRowMode);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve frameOverTime
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("FrameOverTime")]
			private MinMaxCurveBlittable frameOverTimeBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float frameOverTimeMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve startFrame
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StartFrame")]
			private MinMaxCurveBlittable startFrameBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float startFrameMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int cycleCount
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int rowIndex
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			public UVChannelFlags uvChannelMask
			{
				get
				{
					return default(UVChannelFlags);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal TextureSheetAnimationModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_frameOverTimeBlittable_Injected(ref TextureSheetAnimationModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_frameOverTimeBlittable_Injected(ref TextureSheetAnimationModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_startFrameBlittable_Injected(ref TextureSheetAnimationModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_startFrameBlittable_Injected(ref TextureSheetAnimationModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		[RequiredByNativeCode("particleSystemParticle", Optional = true)]
		public struct Particle
		{
			private Vector3 m_Position;

			private Vector3 m_Velocity;

			private Vector3 m_AnimatedVelocity;

			private Vector3 m_InitialVelocity;

			private Vector3 m_AxisOfRotation;

			private Vector3 m_Rotation;

			private Vector3 m_AngularVelocity;

			private Vector3 m_StartSize;

			private Color32 m_StartColor;

			private uint m_RandomSeed;

			private uint m_ParentRandomSeed;

			private float m_Lifetime;

			private float m_StartLifetime;

			private int m_MeshIndex;

			private float m_EmitAccumulator0;

			private float m_EmitAccumulator1;

			private uint m_Flags;

			[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", false)]
			public float lifetime
			{
				set
				{
				}
			}

			public Vector3 position
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Vector3 velocity
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public float remainingLifetime
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float startLifetime
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public Color32 startColor
			{
				get
				{
					return default(Color32);
				}
				set
				{
				}
			}

			public uint randomSeed
			{
				set
				{
				}
			}

			public float startSize
			{
				set
				{
				}
			}

			public float rotation => 0f;

			public Vector3 rotation3D
			{
				get
				{
					return default(Vector3);
				}
				set
				{
				}
			}

			public Vector3 angularVelocity3D
			{
				set
				{
				}
			}

			public float GetCurrentSize(ParticleSystem system)
			{
				return 0f;
			}

			public Color32 GetCurrentColor(ParticleSystem system)
			{
				return default(Color32);
			}
		}

		[NativeType(CodegenOptions.Custom, "MonoBurst", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct Burst
		{
			private float m_Time;

			private MinMaxCurveBlittable m_Count;

			private int m_RepeatCount;

			private float m_RepeatInterval;

			private float m_InvProbability;

			public float time
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public MinMaxCurve count
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			public short minCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public short maxCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int cycleCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public float repeatInterval
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float probability
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}
		}

		[Serializable]
		public struct MinMaxCurve
		{
			[SerializeField]
			internal ParticleSystemCurveMode m_Mode;

			[SerializeField]
			internal float m_CurveMultiplier;

			[SerializeField]
			internal AnimationCurve m_CurveMin;

			[SerializeField]
			internal AnimationCurve m_CurveMax;

			[SerializeField]
			internal float m_ConstantMin;

			[SerializeField]
			internal float m_ConstantMax;

			public ParticleSystemCurveMode mode
			{
				get
				{
					return default(ParticleSystemCurveMode);
				}
				set
				{
				}
			}

			public float curveMultiplier
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public AnimationCurve curveMax
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public AnimationCurve curveMin
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public float constantMax
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float constantMin
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float constant
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public AnimationCurve curve
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		[RequiredByNativeCode]
		internal struct MinMaxCurveBlittable
		{
			private ParticleSystemCurveMode m_Mode;

			private float m_CurveMultiplier;

			private IntPtr m_CurveMin;

			private IntPtr m_CurveMax;

			internal float m_ConstantMin;

			internal float m_ConstantMax;

			public static implicit operator MinMaxCurve(MinMaxCurveBlittable minMaxCurveBlittable)
			{
				return default(MinMaxCurve);
			}

			public static implicit operator MinMaxCurveBlittable(MinMaxCurve minMaxCurve)
			{
				return default(MinMaxCurveBlittable);
			}

			internal static MinMaxCurveBlittable FromMixMaxCurve(in MinMaxCurve minMaxCurve)
			{
				return default(MinMaxCurveBlittable);
			}

			internal static MinMaxCurve ToMinMaxCurve(in MinMaxCurveBlittable minMaxCurveBlittable)
			{
				return default(MinMaxCurve);
			}
		}

		[Serializable]
		public struct MinMaxGradient
		{
			[SerializeField]
			internal ParticleSystemGradientMode m_Mode;

			[SerializeField]
			internal Gradient m_GradientMin;

			[SerializeField]
			internal Gradient m_GradientMax;

			[SerializeField]
			internal Color m_ColorMin;

			[SerializeField]
			internal Color m_ColorMax;

			public ParticleSystemGradientMode mode
			{
				get
				{
					return default(ParticleSystemGradientMode);
				}
				set
				{
				}
			}

			public Gradient gradientMax
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Gradient gradientMin
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Color colorMax
			{
				get
				{
					return default(Color);
				}
				set
				{
				}
			}

			public Color colorMin
			{
				get
				{
					return default(Color);
				}
				set
				{
				}
			}

			public Color color
			{
				get
				{
					return default(Color);
				}
				set
				{
				}
			}

			public Gradient gradient
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public MinMaxGradient(Color color)
			{
				m_Mode = default(ParticleSystemGradientMode);
				m_GradientMin = null;
				m_GradientMax = null;
				m_ColorMin = default(Color);
				m_ColorMax = default(Color);
			}

			public static implicit operator MinMaxGradient(Color color)
			{
				return default(MinMaxGradient);
			}
		}

		[Serializable]
		[RequiredByNativeCode]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		internal struct MinMaxGradientBlittable
		{
			private ParticleSystemGradientMode m_Mode;

			private IntPtr m_GradientMin;

			private IntPtr m_GradientMax;

			private Color m_ColorMin;

			private Color m_ColorMax;

			public static implicit operator MinMaxGradient(MinMaxGradientBlittable minMaxGradientBlittable)
			{
				return default(MinMaxGradient);
			}

			public static implicit operator MinMaxGradientBlittable(MinMaxGradient minMaxGradient)
			{
				return default(MinMaxGradientBlittable);
			}

			internal static MinMaxGradientBlittable FromMixMaxGradient(in MinMaxGradient minMaxGradient)
			{
				return default(MinMaxGradientBlittable);
			}

			internal static MinMaxGradient ToMinMaxGradient(in MinMaxGradientBlittable minMaxGradientBlittable)
			{
				return default(MinMaxGradient);
			}
		}

		public struct EmitParams
		{
			[NativeName("particle")]
			private Particle m_Particle;

			[NativeName("positionSet")]
			private bool m_PositionSet;

			[NativeName("velocitySet")]
			private bool m_VelocitySet;

			[NativeName("axisOfRotationSet")]
			private bool m_AxisOfRotationSet;

			[NativeName("rotationSet")]
			private bool m_RotationSet;

			[NativeName("rotationalSpeedSet")]
			private bool m_AngularVelocitySet;

			[NativeName("startSizeSet")]
			private bool m_StartSizeSet;

			[NativeName("startColorSet")]
			private bool m_StartColorSet;

			[NativeName("randomSeedSet")]
			private bool m_RandomSeedSet;

			[NativeName("startLifetimeSet")]
			private bool m_StartLifetimeSet;

			[NativeName("meshIndexSet")]
			private bool m_MeshIndexSet;

			[NativeName("applyShapeToPosition")]
			private bool m_ApplyShapeToPosition;

			public Vector3 position
			{
				set
				{
				}
			}

			public Vector3 velocity
			{
				set
				{
				}
			}

			public float startLifetime
			{
				set
				{
				}
			}

			public float startSize
			{
				set
				{
				}
			}

			public Color32 startColor
			{
				set
				{
				}
			}
		}

		public struct VelocityOverLifetimeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve x
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("X")]
			private MinMaxCurveBlittable xBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve y
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Y")]
			private MinMaxCurveBlittable yBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve z
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Z")]
			private MinMaxCurveBlittable zBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float xMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float yMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float zMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemSimulationSpace space
			{
				get
				{
					return default(ParticleSystemSimulationSpace);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal VelocityOverLifetimeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_xBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_xBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_yBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_yBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_zBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_zBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		public struct LimitVelocityOverLifetimeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve limitX
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("LimitX")]
			private MinMaxCurveBlittable limitXBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float limitXMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve limitY
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("LimitY")]
			private MinMaxCurveBlittable limitYBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float limitYMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve limitZ
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("LimitZ")]
			private MinMaxCurveBlittable limitZBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float limitZMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve limit
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Magnitude")]
			private MinMaxCurveBlittable limitBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			[NativeName("MagnitudeMultiplier")]
			public float limitMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float dampen
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool separateAxes
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemSimulationSpace space
			{
				get
				{
					return default(ParticleSystemSimulationSpace);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_limitXBlittable_Injected(ref LimitVelocityOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_limitXBlittable_Injected(ref LimitVelocityOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_limitYBlittable_Injected(ref LimitVelocityOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_limitYBlittable_Injected(ref LimitVelocityOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_limitZBlittable_Injected(ref LimitVelocityOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_limitZBlittable_Injected(ref LimitVelocityOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_limitBlittable_Injected(ref LimitVelocityOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_limitBlittable_Injected(ref LimitVelocityOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		public struct InheritVelocityModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemInheritVelocityMode mode
			{
				get
				{
					return default(ParticleSystemInheritVelocityMode);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve curve
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Curve")]
			private MinMaxCurveBlittable curveBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float curveMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal InheritVelocityModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_curveBlittable_Injected(ref InheritVelocityModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_curveBlittable_Injected(ref InheritVelocityModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		public struct ForceOverLifetimeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve x
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("X")]
			private MinMaxCurveBlittable xBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve y
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Y")]
			private MinMaxCurveBlittable yBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve z
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Z")]
			private MinMaxCurveBlittable zBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float xMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float yMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float zMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemSimulationSpace space
			{
				get
				{
					return default(ParticleSystemSimulationSpace);
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool randomized
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal ForceOverLifetimeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_xBlittable_Injected(ref ForceOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_xBlittable_Injected(ref ForceOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_yBlittable_Injected(ref ForceOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_yBlittable_Injected(ref ForceOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_zBlittable_Injected(ref ForceOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_zBlittable_Injected(ref ForceOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		public struct ColorOverLifetimeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxGradient color
			{
				get
				{
					return default(MinMaxGradient);
				}
				set
				{
				}
			}

			[NativeName("Color")]
			private MinMaxGradientBlittable colorBlittable
			{
				get
				{
					return default(MinMaxGradientBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal ColorOverLifetimeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_colorBlittable_Injected(ref ColorOverLifetimeModule _unity_self, out MinMaxGradientBlittable ret)
			{
				ret = default(MinMaxGradientBlittable);
			}

			private static void set_colorBlittable_Injected(ref ColorOverLifetimeModule _unity_self, [In] ref MinMaxGradientBlittable value)
			{
			}
		}

		public struct ColorBySpeedModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxGradient color
			{
				get
				{
					return default(MinMaxGradient);
				}
				set
				{
				}
			}

			[NativeName("Color")]
			private MinMaxGradientBlittable colorBlittable
			{
				get
				{
					return default(MinMaxGradientBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public Vector2 range
			{
				get
				{
					return default(Vector2);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal ColorBySpeedModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_colorBlittable_Injected(ref ColorBySpeedModule _unity_self, out MinMaxGradientBlittable ret)
			{
				ret = default(MinMaxGradientBlittable);
			}

			private static void set_colorBlittable_Injected(ref ColorBySpeedModule _unity_self, [In] ref MinMaxGradientBlittable value)
			{
			}

			private static void get_range_Injected(ref ColorBySpeedModule _unity_self, out Vector2 ret)
			{
				ret = default(Vector2);
			}

			private static void set_range_Injected(ref ColorBySpeedModule _unity_self, [In] ref Vector2 value)
			{
			}
		}

		public struct SizeOverLifetimeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve size
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("X")]
			private MinMaxCurveBlittable sizeBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			[NativeName("XMultiplier")]
			public float sizeMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve x
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("X")]
			private MinMaxCurveBlittable xBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float xMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve y
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Y")]
			private MinMaxCurveBlittable yBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float yMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve z
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Z")]
			private MinMaxCurveBlittable zBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float zMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool separateAxes
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal SizeOverLifetimeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_sizeBlittable_Injected(ref SizeOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_sizeBlittable_Injected(ref SizeOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_xBlittable_Injected(ref SizeOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_xBlittable_Injected(ref SizeOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_yBlittable_Injected(ref SizeOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_yBlittable_Injected(ref SizeOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_zBlittable_Injected(ref SizeOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_zBlittable_Injected(ref SizeOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		public struct SizeBySpeedModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve size
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("X")]
			private MinMaxCurveBlittable sizeBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			[NativeName("XMultiplier")]
			public float sizeMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve x
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("X")]
			private MinMaxCurveBlittable xBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float xMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve y
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Y")]
			private MinMaxCurveBlittable yBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float yMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve z
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Z")]
			private MinMaxCurveBlittable zBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float zMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool separateAxes
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public Vector2 range
			{
				get
				{
					return default(Vector2);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal SizeBySpeedModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_sizeBlittable_Injected(ref SizeBySpeedModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_sizeBlittable_Injected(ref SizeBySpeedModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_xBlittable_Injected(ref SizeBySpeedModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_xBlittable_Injected(ref SizeBySpeedModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_yBlittable_Injected(ref SizeBySpeedModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_yBlittable_Injected(ref SizeBySpeedModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_zBlittable_Injected(ref SizeBySpeedModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_zBlittable_Injected(ref SizeBySpeedModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_range_Injected(ref SizeBySpeedModule _unity_self, out Vector2 ret)
			{
				ret = default(Vector2);
			}

			private static void set_range_Injected(ref SizeBySpeedModule _unity_self, [In] ref Vector2 value)
			{
			}
		}

		public struct RotationOverLifetimeModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve x
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("X")]
			private MinMaxCurveBlittable xBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float xMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve y
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Y")]
			private MinMaxCurveBlittable yBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float yMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve z
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Z")]
			private MinMaxCurveBlittable zBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float zMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool separateAxes
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal RotationOverLifetimeModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_xBlittable_Injected(ref RotationOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_xBlittable_Injected(ref RotationOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_yBlittable_Injected(ref RotationOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_yBlittable_Injected(ref RotationOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_zBlittable_Injected(ref RotationOverLifetimeModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_zBlittable_Injected(ref RotationOverLifetimeModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		public struct RotationBySpeedModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve x
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("X")]
			private MinMaxCurveBlittable xBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float xMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve y
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Y")]
			private MinMaxCurveBlittable yBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float yMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve z
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Z")]
			private MinMaxCurveBlittable zBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float zMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool separateAxes
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public Vector2 range
			{
				get
				{
					return default(Vector2);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal RotationBySpeedModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_xBlittable_Injected(ref RotationBySpeedModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_xBlittable_Injected(ref RotationBySpeedModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_yBlittable_Injected(ref RotationBySpeedModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_yBlittable_Injected(ref RotationBySpeedModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_zBlittable_Injected(ref RotationBySpeedModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_zBlittable_Injected(ref RotationBySpeedModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_range_Injected(ref RotationBySpeedModule _unity_self, out Vector2 ret)
			{
				ret = default(Vector2);
			}

			private static void set_range_Injected(ref RotationBySpeedModule _unity_self, [In] ref Vector2 value)
			{
			}
		}

		public struct ExternalForcesModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float multiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal ExternalForcesModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}
		}

		public struct NoiseModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool separateAxes
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve strength
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StrengthX")]
			private MinMaxCurveBlittable strengthBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			[NativeName("StrengthXMultiplier")]
			public float strengthMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve strengthX
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StrengthX")]
			private MinMaxCurveBlittable strengthXBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float strengthXMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve strengthY
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StrengthY")]
			private MinMaxCurveBlittable strengthYBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float strengthYMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve strengthZ
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("StrengthZ")]
			private MinMaxCurveBlittable strengthZBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float strengthZMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float frequency
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool damping
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int octaveCount
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float octaveMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float octaveScale
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemNoiseQuality quality
			{
				get
				{
					return default(ParticleSystemNoiseQuality);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve scrollSpeed
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("ScrollSpeed")]
			private MinMaxCurveBlittable scrollSpeedBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float scrollSpeedMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool remapEnabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve remap
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("RemapX")]
			private MinMaxCurveBlittable remapBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			[NativeName("RemapXMultiplier")]
			public float remapMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve remapX
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("RemapX")]
			private MinMaxCurveBlittable remapXBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float remapXMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve remapY
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("RemapY")]
			private MinMaxCurveBlittable remapYBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float remapYMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve remapZ
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("RemapZ")]
			private MinMaxCurveBlittable remapZBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float remapZMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal NoiseModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_strengthBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_strengthBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_strengthXBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_strengthXBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_strengthYBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_strengthYBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_strengthZBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_strengthZBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_scrollSpeedBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_scrollSpeedBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_remapBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_remapBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_remapXBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_remapXBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_remapYBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_remapYBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_remapZBlittable_Injected(ref NoiseModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_remapZBlittable_Injected(ref NoiseModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		public struct LightsModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float ratio
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool useRandomDistribution
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public Light light
			{
				get
				{
					return null;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool useParticleColor
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool sizeAffectsRange
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool alphaAffectsIntensity
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve range
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Range")]
			private MinMaxCurveBlittable rangeBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float rangeMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve intensity
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Intensity")]
			private MinMaxCurveBlittable intensityBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float intensityMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public int maxLights
			{
				get
				{
					return 0;
				}
				[NativeThrows]
				set
				{
				}
			}

			internal LightsModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static IntPtr get_light_Injected(ref LightsModule _unity_self)
			{
				return (IntPtr)0;
			}

			private static void set_light_Injected(ref LightsModule _unity_self, IntPtr value)
			{
			}

			private static void get_rangeBlittable_Injected(ref LightsModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_rangeBlittable_Injected(ref LightsModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_intensityBlittable_Injected(ref LightsModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_intensityBlittable_Injected(ref LightsModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}
		}

		public struct TrailModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float ratio
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve lifetime
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("Lifetime")]
			private MinMaxCurveBlittable lifetimeBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float lifetimeMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public float minVertexDistance
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public ParticleSystemTrailTextureMode textureMode
			{
				get
				{
					return default(ParticleSystemTrailTextureMode);
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool worldSpace
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool dieWithParticles
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool sizeAffectsWidth
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool sizeAffectsLifetime
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public bool inheritParticleColor
			{
				get
				{
					return false;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxGradient colorOverLifetime
			{
				get
				{
					return default(MinMaxGradient);
				}
				set
				{
				}
			}

			[NativeName("ColorOverLifetime")]
			private MinMaxGradientBlittable colorOverLifetimeBlittable
			{
				get
				{
					return default(MinMaxGradientBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxCurve widthOverTrail
			{
				get
				{
					return default(MinMaxCurve);
				}
				set
				{
				}
			}

			[NativeName("WidthOverTrail")]
			private MinMaxCurveBlittable widthOverTrailBlittable
			{
				get
				{
					return default(MinMaxCurveBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			public float widthOverTrailMultiplier
			{
				get
				{
					return 0f;
				}
				[NativeThrows]
				set
				{
				}
			}

			public MinMaxGradient colorOverTrail
			{
				get
				{
					return default(MinMaxGradient);
				}
				set
				{
				}
			}

			[NativeName("ColorOverTrail")]
			private MinMaxGradientBlittable colorOverTrailBlittable
			{
				get
				{
					return default(MinMaxGradientBlittable);
				}
				[NativeThrows]
				set
				{
				}
			}

			internal TrailModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			private static void get_lifetimeBlittable_Injected(ref TrailModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_lifetimeBlittable_Injected(ref TrailModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_colorOverLifetimeBlittable_Injected(ref TrailModule _unity_self, out MinMaxGradientBlittable ret)
			{
				ret = default(MinMaxGradientBlittable);
			}

			private static void set_colorOverLifetimeBlittable_Injected(ref TrailModule _unity_self, [In] ref MinMaxGradientBlittable value)
			{
			}

			private static void get_widthOverTrailBlittable_Injected(ref TrailModule _unity_self, out MinMaxCurveBlittable ret)
			{
				ret = default(MinMaxCurveBlittable);
			}

			private static void set_widthOverTrailBlittable_Injected(ref TrailModule _unity_self, [In] ref MinMaxCurveBlittable value)
			{
			}

			private static void get_colorOverTrailBlittable_Injected(ref TrailModule _unity_self, out MinMaxGradientBlittable ret)
			{
				ret = default(MinMaxGradientBlittable);
			}

			private static void set_colorOverTrailBlittable_Injected(ref TrailModule _unity_self, [In] ref MinMaxGradientBlittable value)
			{
			}
		}

		public bool isPlaying
		{
			[NativeName("SyncJobs(false)->IsPlaying")]
			get
			{
				return false;
			}
		}

		public bool isStopped
		{
			[NativeName("SyncJobs(false)->IsStopped")]
			get
			{
				return false;
			}
		}

		public bool isPaused
		{
			[NativeName("SyncJobs(false)->IsPaused")]
			get
			{
				return false;
			}
		}

		public int particleCount
		{
			[NativeName("SyncJobs(false)->GetParticleCount")]
			get
			{
				return 0;
			}
		}

		public float time
		{
			[NativeName("SyncJobs(false)->GetSecPosition")]
			get
			{
				return 0f;
			}
			[NativeName("SyncJobs(false)->SetSecPosition")]
			set
			{
			}
		}

		public uint randomSeed
		{
			[NativeName("SyncJobs(false)->SetRandomSeed")]
			set
			{
			}
		}

		public bool useAutoRandomSeed
		{
			[NativeName("GetAutoRandomSeed")]
			get
			{
				return false;
			}
			[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
			set
			{
			}
		}

		public MainModule main => default(MainModule);

		public EmissionModule emission => default(EmissionModule);

		public ShapeModule shape => default(ShapeModule);

		public VelocityOverLifetimeModule velocityOverLifetime => default(VelocityOverLifetimeModule);

		public LimitVelocityOverLifetimeModule limitVelocityOverLifetime => default(LimitVelocityOverLifetimeModule);

		public InheritVelocityModule inheritVelocity => default(InheritVelocityModule);

		public ForceOverLifetimeModule forceOverLifetime => default(ForceOverLifetimeModule);

		public ColorOverLifetimeModule colorOverLifetime => default(ColorOverLifetimeModule);

		public ColorBySpeedModule colorBySpeed => default(ColorBySpeedModule);

		public SizeOverLifetimeModule sizeOverLifetime => default(SizeOverLifetimeModule);

		public SizeBySpeedModule sizeBySpeed => default(SizeBySpeedModule);

		public RotationOverLifetimeModule rotationOverLifetime => default(RotationOverLifetimeModule);

		public RotationBySpeedModule rotationBySpeed => default(RotationBySpeedModule);

		public ExternalForcesModule externalForces => default(ExternalForcesModule);

		public NoiseModule noise => default(NoiseModule);

		public CollisionModule collision => default(CollisionModule);

		public TriggerModule trigger => default(TriggerModule);

		public SubEmittersModule subEmitters => default(SubEmittersModule);

		public TextureSheetAnimationModule textureSheetAnimation => default(TextureSheetAnimationModule);

		public LightsModule lights => default(LightsModule);

		public TrailModule trails => default(TrailModule);

		[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
		}

		[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Particle particle)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = true)]
		internal float GetParticleCurrentSize(ref Particle particle)
		{
			return 0f;
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = true)]
		internal Color32 GetParticleCurrentColor(ref Particle particle)
		{
			return default(Color32);
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = true, ThrowsException = true)]
		public void SetParticles([Out] Particle[] particles, int size, int offset)
		{
		}

		public void SetParticles([Out] Particle[] particles, int size)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = true, ThrowsException = true)]
		public int GetParticles([Out][NotNull] Particle[] particles, int size, int offset)
		{
			return 0;
		}

		public int GetParticles([Out] Particle[] particles, int size)
		{
			return 0;
		}

		public int GetParticles([Out] Particle[] particles)
		{
			return 0;
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public void SetCustomParticleData([NotNull] List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		public int GetCustomParticleData([NotNull] List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			return 0;
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = true)]
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep)
		{
		}

		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart)
		{
		}

		public void Simulate(float t, [DefaultValue("true")] bool withChildren)
		{
		}

		public void Simulate(float t)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
		public void Play([DefaultValue("true")] bool withChildren)
		{
		}

		public void Play()
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = true)]
		public void Pause([DefaultValue("true")] bool withChildren)
		{
		}

		public void Pause()
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = true)]
		public void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior)
		{
		}

		public void Stop([DefaultValue("true")] bool withChildren)
		{
		}

		public void Stop()
		{
		}

		[RequiredByNativeCode]
		public void Emit(int count)
		{
		}

		[NativeName("SyncJobs()->Emit")]
		private void Emit_Internal(int count)
		{
		}

		[NativeName("SyncJobs()->EmitParticlesExternal")]
		public void Emit(EmitParams emitParams, int count)
		{
		}

		[NativeName("SyncJobs()->EmitParticleExternal")]
		private void EmitOld_Internal(ref Particle particle)
		{
		}

		private static bool get_isPlaying_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_isStopped_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_isPaused_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static int get_particleCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static float get_time_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_time_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_randomSeed_Injected(IntPtr _unity_self, uint value)
		{
		}

		private static bool get_useAutoRandomSeed_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_useAutoRandomSeed_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float GetParticleCurrentSize_Injected(IntPtr _unity_self, ref Particle particle)
		{
			return 0f;
		}

		private static void GetParticleCurrentColor_Injected(IntPtr _unity_self, ref Particle particle, out Color32 ret)
		{
			ret = default(Color32);
		}

		private static void SetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset)
		{
			particles = default(BlittableArrayWrapper);
		}

		private static int GetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset)
		{
			particles = default(BlittableArrayWrapper);
			return 0;
		}

		private static void SetCustomParticleData_Injected(IntPtr _unity_self, ref BlittableListWrapper customData, ParticleSystemCustomData streamIndex)
		{
		}

		private static int GetCustomParticleData_Injected(IntPtr _unity_self, ref BlittableListWrapper customData, ParticleSystemCustomData streamIndex)
		{
			return 0;
		}

		private static void Simulate_Injected(IntPtr _unity_self, float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep)
		{
		}

		private static void Play_Injected(IntPtr _unity_self, [DefaultValue("true")] bool withChildren)
		{
		}

		private static void Pause_Injected(IntPtr _unity_self, [DefaultValue("true")] bool withChildren)
		{
		}

		private static void Stop_Injected(IntPtr _unity_self, [DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior)
		{
		}

		private static void Emit_Internal_Injected(IntPtr _unity_self, int count)
		{
		}

		private static void Emit_Injected(IntPtr _unity_self, [In] ref EmitParams emitParams, int count)
		{
		}

		private static void EmitOld_Internal_Injected(IntPtr _unity_self, ref Particle particle)
		{
		}
	}
}
