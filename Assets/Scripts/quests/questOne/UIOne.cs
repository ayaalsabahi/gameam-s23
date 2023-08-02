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

    public int fruitXGoal = 1; //make sure we can change the goal number from UI
    public int fruitYGoal = 1;
    public int fruitZGoal = 1;


    // Start is called before the first frame update
    void Start()
    {
        mainQuest.text = "Go to the forest";
    }

    public void forestFound()
    {
        mainQuest.text = "Forest Reached";
        mainQuest.color = Color.green; //can change to hex later on
        subquestOne.text = "Fruit X: 0/" + fruitXGoal.ToString();
        subquestTwo.text = "Fruit Y: 0/" + fruitYGoal.ToString();
        subquestThree.text = "Fruit Z: 0/" + fruitZGoal.ToString();
    }


    public void fruitXFound()
    {
        fruitXCount++;
        if (fruitXCount >= fruitXGoal)
        {
            subquestOne.color = Color.green; //can change to hex later on
            subquestOne.text = $"Found {fruitXGoal}/{fruitXGoal} X";
            Debug.Log("found total fruit X!");
            StartEndQuestCoroutine();
        }

        else
        {
            subquestOne.text = $"Fruit X:{fruitXCount}/{fruitXGoal}";
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
            subquestTwo.color = Color.green; //can change to hex later on
            subquestTwo.text = $"Found {fruitYGoal}/{fruitYGoal} Y";
            Debug.Log("found total fruit Y!");
            StartEndQuestCoroutine();
        }

        else
        {
            subquestTwo.text = $"Fruit Y:{fruitYCount}/{fruitYGoal}";
        }
    }

    public void fruitZFound()
    {
        fruitZCount++;
        if (fruitZCount >= fruitZGoal)
        {
            subquestThree.color = Color.green; //can change to hex later on
            subquestThree.text = $"Found {fruitZGoal}/{fruitZGoal} Z";
            Debug.Log("found total fruit Z!");
            StartEndQuestCoroutine();
        }

        else
        {
            subquestThree.text = $"Fruit Z:{fruitZCount}/{fruitZGoal}";
        }
    }

    public void StartEndQuestCoroutine()
    {
        StartCoroutine(EndQuestCoroutine());
    }

    private IEnumerator EndQuestCoroutine()
    {
        // also add for other fruits later
        if (fruitXCount == fruitXGoal && fruitYCount == fruitYGoal && fruitZCount == fruitZGoal)
        {
            Debug.Log("finished quest one!");
            data.currentQuest = questStates.Two;
            yield return new WaitForSeconds(2f); // coroutine that waits for 2 seconds

            mainQuest.text = "Go to the Fireplace";
            mainQuest.color = Color.white;
            subquestOne.text = "";
            subquestOne.color = Color.white;
        }
    }
}

    

