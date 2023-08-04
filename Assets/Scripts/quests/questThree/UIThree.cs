using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIThree : MonoBehaviour
{
    [SerializeField] GameObject buttonBook;
    [SerializeField] TMP_Text buttonText;
    [SerializeField] TMP_Text mainQuestText;
    [SerializeField] TMP_Text subQuestOneText;

    private void Start()
    {
        buttonBook.SetActive(false);
        buttonText.text = "";
    }

    public void libraryFound()
    {
        buttonBook.SetActive(true);
        buttonText.text = "Read";
        mainQuestText.color = UnityEngine.ColorUtility.TryParseHtmlString("#79733B", out Color color) ? color : Color.green;
        subQuestOneText.text = "Read a book";
    }


    public void buttonPressed()
    {
        SceneManager.LoadScene("BookScene");
    }

    //this is when the player would have returned to the scene
    public void doneReading()
    {
        StartCoroutine(EndQuestCoroutine());
    }

    private IEnumerator EndQuestCoroutine()
    {
        yield return new WaitForSeconds(2f);
        subQuestOneText.text = "";
        subQuestOneText.color = Color.white;
        mainQuestText.color = Color.white;
        mainQuestText.text = "";
        //destroy the background canvas image by slowly fading out
        //possibly add a fade to night lighting change
    }
}
