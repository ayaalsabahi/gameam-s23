using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endButtonBehaviour : MonoBehaviour
{
    public void changeSceneClicked()
    {
        SceneManager.LoadScene("OpenWorld");
    }
}
