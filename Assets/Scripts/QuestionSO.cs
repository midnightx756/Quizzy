using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 10)]
    [SerializeField]string question = "Enter new question text here";
    [SerializeField]string[] answers = new string[4];
    [SerializeField]int correct_answer_index;

    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correct_answer_index;
    }

    public string getAnswer(int index)
    {
        return answers[index];
    }
}


