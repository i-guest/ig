using TMPro;

namespace UnityEngine.UI.Extensions
{
	public class ReorderableListDebug : MonoBehaviour
	{
		public TMP_Text DebugLabel;

		private void Awake()
		{
			ReorderableList[] array = Object.FindObjectsByType<ReorderableList>(FindObjectsSortMode.None);
			for (int i = 0; i < array.Length; i++)
			{
				array[i].OnElementDropped.AddListener(ElementDropped);
			}
		}

		private void ElementDropped(ReorderableList.ReorderableListEventStruct droppedStruct)
		{
			DebugLabel.text = "";
			TMP_Text debugLabel = DebugLabel;
			debugLabel.text = debugLabel.text + "Dropped Object: " + droppedStruct.DroppedObject.name + "\n";
			TMP_Text debugLabel2 = DebugLabel;
			debugLabel2.text = debugLabel2.text + "Is Clone ?: " + droppedStruct.IsAClone + "\n";
			if (droppedStruct.IsAClone)
			{
				TMP_Text debugLabel3 = DebugLabel;
				debugLabel3.text = debugLabel3.text + "Source Object: " + droppedStruct.SourceObject.name + "\n";
			}
			DebugLabel.text += $"From {droppedStruct.FromList.name} at Index {droppedStruct.FromIndex} \n";
			DebugLabel.text += string.Format("To {0} at Index {1} \n", (droppedStruct.ToList == null) ? "Empty space" : droppedStruct.ToList.name, droppedStruct.ToIndex);
		}
	}
}
