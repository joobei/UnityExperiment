using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Joutai;

[CustomEditor(typeof(State),true)]
public class StateInspector : Editor {
    
    Color buttonColor;
    //string buttonText = "Used";
    string buttonText;

    public override void OnInspectorGUI()
    {
		State state = (State)target;

		var style = new GUIStyle(GUI.skin.button);
        style.normal.textColor = buttonColor;

        if (state.use)
        {
            buttonText = "Used";
            buttonColor = Color.green;
        }
        else 
        { 
            buttonText = "Not Used";
            buttonColor = Color.red;
        }

        if (GUILayout.Button(buttonText, style)) 
        {
            state.use = !state.use;
        }

        DrawDefaultInspector();
    }


}
