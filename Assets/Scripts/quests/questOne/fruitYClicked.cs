using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitYClicked : MonoBehaviour
{
    public gameEvent fuitYClicked;
    public float rotationSpeed = 30f;

    private void OnMouseDown()
    {
        if (data.currentQuest == questStates.One)
        {
            Debug.Log("Fruit Y clicked");
            fuitYClicked.Raise();
            Destroy(gameObject);
        }

    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
