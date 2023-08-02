using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "game event")]

public class gameEvent : ScriptableObject
{
    public List<gameEventListener> listeners = new List<gameEventListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].onEventRaised();
        }
    }

    //regestering listeners
    public void RegisterListener(gameEventListener listener)
    {
        if (!listeners.Contains(listener)) listeners.Add(listener);
    }

    //unregestering listeners
    public void UnegisterListener(gameEventListener listener)
    {
        if (listeners.Contains(listener)) listeners.Remove(listener);
    }

}