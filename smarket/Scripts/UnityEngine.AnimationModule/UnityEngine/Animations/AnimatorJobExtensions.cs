using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	[StaticAccessor("AnimatorJobExtensionsBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorJobExtensions.bindings.h")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
	public static class AnimatorJobExtensions
	{
		public static TransformStreamHandle BindStreamTransform(this Animator animator, Transform transform)
		{
			return default(TransformStreamHandle);
		}

		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, Type type, string property)
		{
			return default(PropertyStreamHandle);
		}

		public static PropertyStreamHandle BindCustomStreamProperty(this Animator animator, string property, CustomStreamPropertyType type)
		{
			return default(PropertyStreamHandle);
		}

		public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, Type type, string property, [DefaultValue("false")] bool isObjectReference)
		{
			return default(PropertyStreamHandle);
		}

		public static TransformSceneHandle BindSceneTransform(this Animator animator, Transform transform)
		{
			return default(TransformSceneHandle);
		}

		public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, Type type, string property)
		{
			return default(PropertySceneHandle);
		}

		public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, Type type, string property, [DefaultValue("false")] bool isObjectReference)
		{
			return default(PropertySceneHandle);
		}

		private static void InternalBindStreamTransform([NotNull] Animator animator, [NotNull] Transform transform, out TransformStreamHandle transformStreamHandle)
		{
			transformStreamHandle = default(TransformStreamHandle);
		}

		private static void InternalBindStreamProperty([NotNull] Animator animator, [NotNull] Transform transform, [NotNull] Type type, [NotNull] string property, bool isObjectReference, out PropertyStreamHandle propertyStreamHandle)
		{
			propertyStreamHandle = default(PropertyStreamHandle);
		}

		private static void InternalBindCustomStreamProperty([NotNull] Animator animator, [NotNull] string property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle)
		{
			propertyStreamHandle = default(PropertyStreamHandle);
		}

		private static void InternalBindSceneTransform([NotNull] Animator animator, [NotNull] Transform transform, out TransformSceneHandle transformSceneHandle)
		{
			transformSceneHandle = default(TransformSceneHandle);
		}

		private static void InternalBindSceneProperty([NotNull] Animator animator, [NotNull] Transform transform, [NotNull] Type type, [NotNull] string property, bool isObjectReference, out PropertySceneHandle propertySceneHandle)
		{
			propertySceneHandle = default(PropertySceneHandle);
		}

		private static void InternalBindStreamTransform_Injected(IntPtr animator, IntPtr transform, out TransformStreamHandle transformStreamHandle)
		{
			transformStreamHandle = default(TransformStreamHandle);
		}

		private static void InternalBindStreamProperty_Injected(IntPtr animator, IntPtr transform, Type type, ref ManagedSpanWrapper property, bool isObjectReference, out PropertyStreamHandle propertyStreamHandle)
		{
			propertyStreamHandle = default(PropertyStreamHandle);
		}

		private static void InternalBindCustomStreamProperty_Injected(IntPtr animator, ref ManagedSpanWrapper property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle)
		{
			propertyStreamHandle = default(PropertyStreamHandle);
		}

		private static void InternalBindSceneTransform_Injected(IntPtr animator, IntPtr transform, out TransformSceneHandle transformSceneHandle)
		{
			transformSceneHandle = default(TransformSceneHandle);
		}

		private static void InternalBindSceneProperty_Injected(IntPtr animator, IntPtr transform, Type type, ref ManagedSpanWrapper property, bool isObjectReference, out PropertySceneHandle propertySceneHandle)
		{
			propertySceneHandle = default(PropertySceneHandle);
		}
	}
}
