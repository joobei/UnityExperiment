/*  This file is part of Joutai.

    Joutai is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Joutai is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Joutai.  If not, see <http://www.gnu.org/licenses/>. 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Joutai;

public class InstructionState : State
{
    public String[] introTextArray;

    //this textIndex should ideally ber
    //replaced by something more intelligent
    short textIndex = 0;

    public Text textPane;   

    public override void OnEnable()
    {
        base.OnEnable();
        textPane.text = introTextArray[textIndex];
    }

    protected void mousePressed()
    {
        localAdvance();	
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePressed();
        }
    }

    //advance to next text instruction
    void localAdvance() {
		textIndex++;
		if (textIndex >= introTextArray.Length)
		{
			textIndex = 0;
			advanceState();
		}
		else
		{
			textPane.text = introTextArray[textIndex];
		}
    }
}
