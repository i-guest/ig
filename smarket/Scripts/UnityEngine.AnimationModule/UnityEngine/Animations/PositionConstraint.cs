using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Animation/Constraints/PositionConstraint.h")]
	public sealed class PositionConstraint : Behaviour
	{
	}
}
