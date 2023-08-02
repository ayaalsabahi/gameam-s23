using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitZClicked : MonoBehaviour
{
    public gameEvent fuitZClicked;

    private void OnMouseDown()
    {
        if (data.currentQuest == questStates.One)
        {
            
            Destroy(gameObject);
            fuitZClicked.Raise();


        }

    }
}
