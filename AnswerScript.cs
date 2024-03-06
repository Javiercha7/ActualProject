using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public GameManager gameManager;


    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Good Answer");
            gameManager.correct();
        }
        else
        {
            Debug.Log("Bad Answer");
                gameManager.correct();
        }        
    }
}
