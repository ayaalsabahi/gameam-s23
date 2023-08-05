using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UIOne : MonoBehaviour
{
    //create 4 containers for the texts
    public TMP_Text mainQuest;
    public TMP_Text subquestOne;
    public TMP_Text subquestTwo;
    public TMP_Text subquestThree;

    int fruitXCount = 0;
    int fruitYCount = 0;
    int fruitZCount = 0;

    public int fruitXGoal; //make sure we can change the goal number from UI
    public int fruitYGoal;
    public int fruitZGoal;


    // Start is called before the first frame update
    void Start()
    {
        mainQuest.text = "Go to the forest";
    }

    public void forestFound()
    {
        mainQuest.text = "Forest Reached";
        mainQuest.color = UnityEngine.ColorUtility.TryParseHtmlString("#79733B", out Color color) ? color : Color.green;
        subquestOne.text = "Strawberries: 0/" + fruitXGoal.ToString();
        subquestTwo.text = "Mushroom: 0/" + fruitYGoal.ToString();
        subquestThree.text = "Pumpkin: 0/" + fruitZGoal.ToString();
    }


    public void fruitXFound()
    {
        fruitXCount++;
        if (fruitXCount >= fruitXGoal)
        {
            subquestOne.color = UnityEngine.ColorUtility.TryParseHtmlString("#79A637", out Color color) ? color : Color.green;
            subquestOne.text = $"{fruitXGoal}/{fruitXGoal} strawberries";
            Debug.Log("found total fruit X!");
            StartEndQuestCoroutine();
        }

        else
        {
            subquestOne.text = $"strawberries:{fruitXCount}/{fruitXGoal}";
        }
    }

    public void fruitYFound()
    {
        fruitYCount++;
        if (fruitYCount >= fruitYGoal)
        {
            if (subquestTwo == null)
            {
               Debug.Log("NOT slayyyyy");
            }
            subquestTwo.color = UnityEngine.ColorUtility.TryParseHtmlString("#79A637", out Color color) ? color : Color.green;
            subquestTwo.text = $"{fruitYGoal}/{fruitYGoal} mushrooms";
            Debug.Log("found total fruit Y!");
            StartEndQuestCoroutine();
        }

        else
        {
            subquestTwo.text = $"mushrooms:{fruitYCount}/{fruitYGoal}";
        }
    }

    public void fruitZFound()
    {
        fruitZCount++;
        if (fruitZCount >= fruitZGoal)
        {
            subquestThree.color = UnityEngine.ColorUtility.TryParseHtmlString("#79A637", out Color color) ? color : Color.green;
            subquestThree.text = $"{fruitZGoal}/{fruitZGoal} pumpkin";
            Debug.Log("found total fruit Z!");
            StartEndQuestCoroutine();
        }

        else
        {
            subquestThree.text = $"pumpkin: {fruitZCount}/{fruitZGoal}";
        }
    }

    public void StartEndQuestCoroutine()
    {
        StartCoroutine(EndQuestCoroutine());
    }

    private IEnumerator EndQuestCoroutine()
    {
        if (fruitXCount == fruitXGoal && fruitYCount == fruitYGoal && fruitZCount == fruitZGoal)
        {
            Debug.Log("finished quest one!");
            data.currentQuest = questStates.Two;
            yield return new WaitForSeconds(2f); // coroutine that waits for 2 seconds
            mainQuest.text = "Go to the Fireplace";
            mainQuest.color = UnityEngine.ColorUtility.TryParseHtmlString("#572526", out Color color) ? color : Color.black;
            subquestOne.text = "";
            subquestOne.color = UnityEngine.ColorUtility.TryParseHtmlString("#572526", out Color color1) ? color1 : Color.black;
            subquestTwo.text = "";
            subquestTwo.color = UnityEngine.ColorUtility.TryParseHtmlString("#572526", out Color color2) ? color2 : Color.black;
            subquestThree.text = "";
            subquestThree.color = UnityEngine.ColorUtility.TryParseHtmlString("#572526", out Color color3) ? color3 : Color.black;
        }
    }
}

    

