using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitZCaught : MonoBehaviour
{
    public gameEvent fruitZClicked;

    private void OnMouseDown()
    {
        fruitZClicked.Raise();
        Destroy(gameObject);
    }
}
