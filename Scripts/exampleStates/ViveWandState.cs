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

//*******************************************************************
//********************** IF YOU HAVE STEAMVR  ***********************
//**********************   UNCOMMENT TO USE   ***********************
//*******************************************************************
/*
 
public abstract class ViveWandState : State
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Joutai;

{
    //private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private SteamVR_Controller.Device device;
    private SteamVR_TrackedObject trackedObject;

    protected virtual void Update()
    {
        //TODO: this needs fixing, variable shouldn't be updated every frame.
        var controllerObject = GameObject.Find("RightController");

        //HACK For trigger!!!
        bool triggerClicked = false;
        if (timeRepeat < 0)
        {
            try
            {

                trackedObject = controllerObject.GetComponent<SteamVR_TrackedObject>();
                device = SteamVR_Controller.Input((int)trackedObject.index);
                triggerClicked = device.GetHairTriggerDown();
                //Vector2 triggerPosition = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger);
                //triggerClicked = triggerPosition.x > 0.999f; // trigger treshold seems to be 0.9f
            }
            catch (NullReferenceException e) { Debug.LogWarning(e.Message); }
        }

        if (triggerClicked && triggerTime < 0)
        {
            triggerPressed();
            triggerTime = 1f;
            triggerClicked = false;
        }

        //reset button timeout if trigger button is up
        if (SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.FarthestRight)).GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            triggerTime = -1;
        }
    }

    protected virtual void triggerPressed() {
        //todo: handle trigger pressed
    }
}
*/