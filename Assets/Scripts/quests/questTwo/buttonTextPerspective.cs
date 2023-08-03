using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonTextPerspective : MonoBehaviour
{
    //makes sure that button is always facing player
    private void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}
