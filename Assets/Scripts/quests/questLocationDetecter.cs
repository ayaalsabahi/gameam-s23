using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*this file checks whether the player colided with the respective aligned areas of the forest or not
   and if so, sends out a signal that the collision has occured and if it is the correct timing of
   the quest or not*/
public class questLocationDetecter : MonoBehaviour
{
    
    [Header("Events")]
    public gameEvent forestReached;
    public gameEvent fireplaceReached;
    public gameEvent libraryReached;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "forest" && data.currentQuest == questStates.One)
        {
            forestReached.Raise();
            Debug.Log("I reached the forest!");
        } 

        else if (other.gameObject.name == "fireplace" && data.currentQuest == questStates.Two)
            fireplaceReached.Raise();

        else if (other.gameObject.name == "library" && data.currentQuest == questStates.Three)
            libraryReached.Raise();
    }

}

