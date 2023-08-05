using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagment : MonoBehaviour
{
    public Animator myAnim;

    public void changeScene()
    {
        myAnim.SetTrigger("reachedLastPage");
    }
}
