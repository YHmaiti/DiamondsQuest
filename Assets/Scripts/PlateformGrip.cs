using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformGrip : MonoBehaviour
{
    // we need to have avriables that will represent the player and the trigger 
    public GameObject theTrigger, thePlayer;

    void OnTriggerEnter()
    {
        // allow the plateform to grip our player
        thePlayer.transform.parent = theTrigger.transform;
    }

    void OnTriggerExit()
    {

        // after leaving the grip plateform we simply 
        // set back the parent of the player to null 
        // and disconnect it from the grip 
        thePlayer.transform.parent = null;
    }
}
