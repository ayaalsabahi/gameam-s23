using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookButtonPressed : MonoBehaviour
{
    public gameEvent mousePressed;

    private void OnMouseDown()
    {
        mousePressed.Raise();
        Destroy(gameObject);
    }
}
