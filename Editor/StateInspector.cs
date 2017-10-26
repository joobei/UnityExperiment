using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Joutai;

[CustomEditor(typeof(State),true)]
public class StateInspector : Editor {

    bool use = true;
    Color buttonColor = Color.green;
    string buttonText = "Used";

	public override void OnInspectorGUI()
    {
        State instructionState = (State)target;

		var style = new GUIStyle(GUI.skin.button);
        style.normal.textColor = buttonColor;

        if (GUILayout.Button(buttonText, style)) 
        {
            if (use)
            {
                instructionState.use = false;
                use = false;
                buttonColor = Color.red;
                buttonText = "Not Used";
            }
            else
            {
                instructionState.use = true;
                use = true;
                buttonColor = Color.green;
                buttonText = "Used";
            }
        }
        DrawDefaultInspector();
    }


}
