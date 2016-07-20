using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MultipleChoiceQuiz : MonoBehaviour {
	public Questions[] questions;
	private List<Questions> unansweredQuestions;
	private Questions currentQuestion;
	private int currentQuestionIndex;

	void Start () {
		unansweredQuestions = questions.ToList<Questions> ();

		setRandomQuestion ();
		Debug.Log (currentQuestion.answer);
	}

	void setRandomQuestion(){
		currentQuestionIndex = Random.Range (0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions[currentQuestionIndex];

		//unansweredQuestions.RemoveAt (currentQuestionIndex);
	}
}
