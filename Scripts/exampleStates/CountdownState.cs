using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Joutai;

public class CountdownState : State
{
    private Text textPane;
    public float countDownTimer = 3.0f;

    public override void OnEnable()
    {
        if (use) {
        base.OnEnable();
        GameObject mainCamera = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        textPane = CreateText(mainCamera);
        textPane.text = countDownTimer.ToString();
        }
    }

	public void Update()
	{
        countDownTimer -= Time.deltaTime;
        textPane.text = countDownTimer.ToString("f0");

        if (countDownTimer < 0) advanceState();
    }

    Text CreateText(GameObject camera)
    {
        GameObject UICanvasGO = new GameObject("InstructionCanvas");

        RectTransform trans = UICanvasGO.AddComponent<RectTransform>();
        trans.anchoredPosition = new Vector2(0, 0);

        UICanvasGO.AddComponent<Canvas>();
        UICanvasGO.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
        UICanvasGO.GetComponent<Canvas>().worldCamera = camera.GetComponent<Camera>();
        UICanvasGO.GetComponent<Canvas>().planeDistance = 100;

        UICanvasGO.AddComponent<CanvasScaler>();

        GameObject textGO = new GameObject("Text");
        textGO.transform.SetParent(UICanvasGO.transform);
        textGO.AddComponent<RectTransform>();
        textGO.GetComponent<RectTransform>().position = Vector3.zero;
        textGO.GetComponent<RectTransform>().localPosition = Vector3.zero;
        textGO.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
        Text text = textGO.AddComponent<Text>();
        text.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
        text.resizeTextForBestFit = true;


        return text;
    }
}
