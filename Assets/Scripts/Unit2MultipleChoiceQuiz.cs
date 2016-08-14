using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class Unit2MultipleChoiceQuiz : MonoBehaviour {

	public Unit2QuestionsSetA[] Unit2QuestionsSetA;
	private List<Unit2QuestionsSetA> unansweredUnit2QuestionsSetA;
	private Unit2QuestionsSetA currentUnit2QuestionSetA;

	private QuizController quizController;

	public Animator animator;

	public Text unit2OutCome1,  unit2OutCome2,  unit2OutCome3;

	public Image questionImage;
	private int currentQuestionIndex;

	private bool isAnswerCorrect;

	void Start () {
		unansweredUnit2QuestionsSetA = Unit2QuestionsSetA.ToList<Unit2QuestionsSetA> ();

		SetRandomQuestions ();
	}

	void SetRandomQuestions () {
		currentQuestionIndex = Random.Range (0, unansweredUnit2QuestionsSetA.Count);
		currentUnit2QuestionSetA = unansweredUnit2QuestionsSetA[currentQuestionIndex];
		questionImage.sprite = currentUnit2QuestionSetA.unit2ImageGivenSetA;
		unansweredUnit2QuestionsSetA.RemoveAt (currentQuestionIndex);
	}

	public void Unit2CheckAnswers (int ans) {
		if (ans == currentUnit2QuestionSetA.unit2AnswerSetA) {
			Debug.Log ("Correct");
			isAnswerCorrect = true;
		} else {
			Debug.Log ("Wrong");
		}

		CheckQuestionsList ();
		AnimateButtons (ans);
		SetOutcomes (ans, isAnswerCorrect);
	}

	void CheckQuestionsList () {
		if (unansweredUnit2QuestionsSetA == null || unansweredUnit2QuestionsSetA.Count == 0) {
			Debug.Log ("FinishSetA");

		} else {
			StartCoroutine (CountToTransitionUnit2 ());
		}
	}

	void AnimateButtons (int answ) {
		if (answ == 1) {
			animator.SetTrigger ("1");
		} else if (answ == 2) {
			animator.SetTrigger ("2");
		} else if (answ == 3) {
			animator.SetTrigger ("3");
		} else {
			return;
		}
	}

	IEnumerator CountToTransitionUnit2 () {
		yield return new WaitForSeconds (1.5f);
		SetRandomQuestions ();
		animator.SetTrigger ("4");
	}

	void SetOutcomes (int answe, bool isAnswer) {
		if (answe == 1 && isAnswer == true) {
			unit2OutCome1.text = "Correct";
		} else if (answe == 2 && isAnswer == true) {
			unit2OutCome2.text = "Correct";
		} else if (answe == 3 && isAnswer == true) {
			unit2OutCome3.text = "Correct";
		} else {
			unit2OutCome1.text = "Wrong";
			unit2OutCome2.text = "Wrong";
			unit2OutCome3.text = "Wrong";
			return;
		}
	}
}