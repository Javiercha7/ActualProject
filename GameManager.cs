using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GoodandBad> QnA;
    public GameObject[] options;
    public int currentOptions;

    public Text QuestionTxt;

    private void Start()
    {
        generateQuestion();
    }

    public void correct()
    {
        generateQuestion();
    }

    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentOptions].Answers[i];

            if (QnA[currentOptions].CorrectOptions == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        currentOptions = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentOptions].Options;
        SetAnswer();

        QnA.RemoveAt(currentOptions);
    }
}
