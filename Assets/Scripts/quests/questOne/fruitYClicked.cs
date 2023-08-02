using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitYClicked : MonoBehaviour
{
    public gameEvent fuitYClicked;

    private void OnMouseDown()
    {
        if (data.currentQuest == questStates.One)
        {
            Debug.Log("Fruit Y clicked");
            fuitYClicked.Raise();
            Destroy(gameObject);
        }

    }
}
