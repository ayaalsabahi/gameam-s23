using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIOne : MonoBehaviour
{
    //create 4 containers for the texts
    public TMP_Text mainQuest;
    public TMP_Text subquestOne;
    
    int fruitXCount = 0;
    //int fruitYCount = 0;
    //int fruitZCount = 0;

    public int fruitXGoal = 1; //make sure we can change the goal number from UI
    //public int fruitYGoal = 2;
    //public int fruitZGoal = 3;

    
    // Start is called before the first frame update
    void Start()
    {
        mainQuest.text = "Go to the forest";
    }

    public void forestFound()
    {
        mainQuest.text = "Forest Reached";
        //also change the text to green
        subquestOne.text = "Fruit X: 0/" + fruitXGoal.ToString();
    }


    public void fruitXFound()
    {
        fruitXCount++;
        if(fruitXCount == fruitXGoal)
        {
            //change the color of the text to green
            Debug.Log("found total fruit X!");
        }

        else
        {
            subquestOne.text = $"Fruit X:{fruitXCount}/{fruitXGoal}";
        }

    }
    
}
