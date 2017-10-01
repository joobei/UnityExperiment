using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(InstructionState))]
public class StateInspector : Editor {

	public override void OnInspectorGUI()
    {
        InstructionState instructionState = (InstructionState)target;



		var style = new GUIStyle(GUI.skin.button);
		style.normal.textColor = Color.green;
        //style.normal.background = 
        if (GUILayout.Button("Use this State", style)) 
        {
            instructionState.use = !instructionState.use;
        }
        DrawDefaultInspector();
    }


}
