using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bookButtonClicked : MonoBehaviour
{
    //load back to where player was in the library
    public void ifButtonClicked()
    {
        SceneManager.LoadScene("OpenWorld");
    }
}
