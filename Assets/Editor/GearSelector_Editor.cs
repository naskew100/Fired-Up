using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(GearSelector))]
[CanEditMultipleObjects]
public class GearSelector_Editor : Editor {

	public override void OnInspectorGUI (){
		serializedObject.Update();
	}
}
