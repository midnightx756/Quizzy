using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    float timerValue;

    public bool LoadNextQuestion = true;
    public bool isAnsweringQuestion = false;
    public float fillFraction;
    
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
            timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if(isAnsweringQuestion)
        {
            if(timerValue <= 0){
                  timerValue = timeToShowCorrectAnswer;
                  isAnsweringQuestion = false;
            }
            else if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
        }
        else
        {
                  if(timerValue <= 0)
                  {
                     isAnsweringQuestion = true;
                     timerValue = timeToCompleteQuestion;
                     LoadNextQuestion = true;
                  }
                  else if(timerValue > 0)
                  {
                     fillFraction = timerValue / timeToShowCorrectAnswer;
                  }
        }

        Debug.Log(isAnsweringQuestion+ ":" + timerValue + "=" + fillFraction);
    }
}
