using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITwo : MonoBehaviour
{
    //create an event for when the button and text appear, when the collision to cook basically happens

    //quest two animation button
    [SerializeField] GameObject buttonAnim;
    [SerializeField] TMP_Text buttonText;
    [SerializeField] TMP_Text mainQuestText;
    [SerializeField] TMP_Text subQuestOneText;
    [SerializeField] CookingCauldron cauldron;

    //add two invisible buttons for at the library;

    private void Start()
    {
        buttonAnim.SetActive(false);
        buttonText.text = "";
    }

    public void fireplaceFound()
    {
        buttonAnim.SetActive(true);
        buttonText.text = "Cook";
        mainQuestText.color = UnityEngine.ColorUtility.TryParseHtmlString("#79733B", out Color color) ? color : Color.green;
        subQuestOneText.text = "Cook";
    }

    public void activateAnimation()
    {
        //here will be the functionality to activate the animation that ruben is working on
        cauldron.startCooking();
        subQuestOneText.color = UnityEngine.ColorUtility.TryParseHtmlString("#79A637", out Color color) ? color : Color.green;
        buttonText.text = "";
        StartEndQuestCoroutine();
    }

    public void StartEndQuestCoroutine()
    {
        StartCoroutine(EndQuestCoroutine());
    }

    private IEnumerator EndQuestCoroutine()
    {
        yield return new WaitForSeconds(2f);
        subQuestOneText.text = "";
        subQuestOneText.color = UnityEngine.ColorUtility.TryParseHtmlString("#572526", out Color color) ? color : Color.black;
        mainQuestText.color = UnityEngine.ColorUtility.TryParseHtmlString("#572526", out Color color1) ? color1 : Color.black;
        mainQuestText.text = "Go to the library";
        data.currentQuest = questStates.Three;
    }

    
    
}
