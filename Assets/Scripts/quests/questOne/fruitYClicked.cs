using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitYClicked : MonoBehaviour
{
    public gameEvent fuitYClicked;

    private void OnMouseDown()
    {
        fuitYClicked.Raise();
        Destroy(gameObject);
    }
}
