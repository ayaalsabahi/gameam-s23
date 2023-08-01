using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gameEventListener : MonoBehaviour
{
    //we need to know which gameEvent we want to listen to
    public gameEvent gameEvent;
    public UnityEvent response;

    //adding ourselevs as listeners
    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    //removing as listeners
    private void OnDisable()
    {
        gameEvent.UnegisterListener(this);
    }

    public void onEventRaised()
    {
        response.Invoke();
    }
}
