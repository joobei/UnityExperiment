using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownState : State
{
    public String[] introTextArray;
    short textIndex = 0;
    public GameObject canvasObject;
    public Text textPane;
    float countDownTimer = 1f;

    public override void OnEnable()
    {
        base.OnEnable();
        textPane.text = introTextArray[0];
        //textPane.fontSize = 33;
        countDownTimer = 1f;
    }

    protected void Update()
    {
        countDownTimer -= Time.deltaTime;

        if (countDownTimer <0) {
            textIndex++;
            if (textIndex >= introTextArray.Length)
            {
                textIndex = 0;
                advanceState();
            }
            else {
                textPane.text = introTextArray[textIndex];
                countDownTimer = 1f;
            }
        }
    }
}
