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

public abstract class State : MonoBehaviour
{
    //Whether or not this state will be used
    //this is checked by onEnable()
    [HideInInspector]
    public bool use;

	AudioSource audioSource;
	protected float timeRepeat = 1f; //to stop sounds from playing too fast - needs fixing
	protected float triggerTime = -1f;

	//public State nextState;

	protected String stateName; //not really necessary... unless you want a state to behave differently
								//depending on the state it came from.

	//List of objects this state is going to use 
	//and therefore needs to activate (in Activate method)
	public GameObject[] neededObjects;

    //Disable all objects other
    //than the ones the state needs
    public virtual void OnEnable()
    {
        if (use)
        {
            //disable all objects except those tagged "permanent"
            //this is so that we don't disable 
            //gameobjects holding networking scripts, OpenVR, HMD's etc.
            List<GameObject> permanentObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("permanent"));

            GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
            foreach (GameObject go in allObjects)
            {
                //if it's not in the permanent objects array
                //disable it
                if(!permanentObjects.Contains(go))
                {
                    go.SetActive(false);    
                }

            }

            //enable only Objects needed by current state
            foreach (GameObject gobject in neededObjects)
            {
                gobject.SetActive(true);
            }

            audioSource = GetComponent<AudioSource>();
            AudioClip clip = (AudioClip)Resources.Load("Toot");
            audioSource.PlayOneShot(clip);
            //Debug.Log("State: " + this.stateName);
        }
        else
        {
            advanceState();
        }
    }


    //This function should be called whenever you want to move to the next state
	public virtual void advanceState()
	{
		State[] states = GetComponentsInParent<State>(true);

		for (int i = 0; i < states.Length; i++)
		{
		    if (states[i].Equals(this))
		    {
                //disable this state
		        this.enabled = false;
                //if there IS a next state, enable it.
                if (i+1 < states.Length)
                {
                    states[i + 1].enabled = true;    
					break;
                }
		    }
		    
		}
	}

	//public virtual void regressState()
	//{
	//    enabled = false;
	//    previousState.enabled = true;
	//}

	protected void playSound(String filename)
	{
		AudioClip clip = (AudioClip)Resources.Load(filename);
	    audioSource.PlayOneShot(clip);
	}

}
