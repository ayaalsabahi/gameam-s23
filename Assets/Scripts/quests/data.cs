using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum questStates { Null, One, Two, Three };

//this file keeps track of the states pretty much
public class data : MonoBehaviour
{
    public static questStates currentQuest = questStates.One;

}
