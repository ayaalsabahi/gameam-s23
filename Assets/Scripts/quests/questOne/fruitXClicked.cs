using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitXClicked : MonoBehaviour
{
    public gameEvent fuitXClicked;
    public float rotationSpeed = 30f;

    private void OnMouseDown()
    {
        if(data.currentQuest == questStates.One)
        {
            
            fuitXClicked.Raise();
            Destroy(gameObject);
        }
        
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
