using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ControllerClickObject : MonoBehaviour
{
    public SteamVR_Input_Sources handyType;
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean clickAction;

    private GameObject _collidingObject;
    private GameObject _clickedObject;

    private void SetCollidingObject(Collider col)
    {
        // cases in which it is not useful / possible to set the colliding object
        // 1. You can not click something if you are already "holding" something
        // 2. Or if the Object you wanna click has no rigidbody
        // both don't seem relevant to us
        if (_collidingObject || !col.GetComponent<Rigidbody>())
        {
            return;
        }

        // set the colliding Object
        _collidingObject = col.gameObject;
    }
    
    // HIER SIND WIR -> ADD TRIGGER METHODS TODO
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
