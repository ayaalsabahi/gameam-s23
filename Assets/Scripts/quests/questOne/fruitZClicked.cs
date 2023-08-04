using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitZClicked : MonoBehaviour
{
    public gameEvent fuitZClicked;
    public float rotationSpeed = 30f;

    private void OnMouseDown()
    {
        if (data.currentQuest == questStates.One)
        {
            
            Destroy(gameObject);
            fuitZClicked.Raise();
        }

    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
