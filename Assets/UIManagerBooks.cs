using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerBooks : MonoBehaviour
{
    public Animator myAnim;

    public void reachedLastPage()
    {
        myAnim.SetTrigger("reachedLastPage");
        //add a scene change as well once the animation is done
    }

    public void changeScene()
    {
        SceneManager.LoadScene("EndScene");
    }

}
