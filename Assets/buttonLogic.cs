using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonLogic : MonoBehaviour
{
    //load the game
    public void buttonPressed()
    {
        SceneManager.LoadScene("OpenWorld");
    }
}
