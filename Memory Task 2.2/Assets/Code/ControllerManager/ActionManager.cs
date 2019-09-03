using System.Collections;
using System.Collections.Generic;
using Valve.VR;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean myAction;
    //public SteamVR_Action_Boolean grabAction;

    // Update is called once per frame
    void Update()
    {
        if (GetActivationAction())
        {
            print("Activated " + handType);
        }
    }

    public bool GetActivationAction()
    {
        return myAction.GetStateDown(handType);
    }
}
