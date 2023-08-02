using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitXClicked : MonoBehaviour
{
    public gameEvent fuitXClicked;

    private void OnMouseDown()
    {
        if(data.currentQuest == questStates.One)
        {
            
            fuitXClicked.Raise();
            Destroy(gameObject);
        }
        
    }
}
