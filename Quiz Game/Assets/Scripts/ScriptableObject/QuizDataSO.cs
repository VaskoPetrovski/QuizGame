using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuizData", menuName = "Quiz/Create New Quiz", order = 1)]
public class QuizDataSO : ScriptableObject
{
    [Serializable]
    public class QuestionData
    {
        public string question;

        [Tooltip("List of possible answers.")]
        public List<string> answers = new List<string>();

        [Tooltip("Index of the correct answer in the 'answers' list.")]
        public int correctAnswerIndex;
    }

    [Header("All Questions for the Quiz")]
    public List<QuestionData> questions = new List<QuestionData>();
}
