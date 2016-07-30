using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MultipleChoiceQuiz : MonoBehaviour {

	public QuestionsSetA[] questionsSetA;
	private List<QuestionsSetA> unansweredQuestionsSetA;
	private QuestionsSetA currentQuestionSetA;

	public QuestionsSetB[] questionsSetB;
	private List<QuestionsSetB> unansweredQuestionsSetB;
	private QuestionsSetB currentQuestionSetB;

	private QuizController quizController;

	public GameObject setBButtons;

	public Image questionImage;
	private int currentQuestionIndex;

	public static bool setA = true, setB = false, setC = false;

	void Start () {
		if (setC == true){
			quizController = GetComponent <QuizController> ();
			quizController.transitionToSetC ();
		}
		hideDisableSetAButtons ();
		checkSet ();
		SetRandomQuestion ();
	}

	void checkSet () {
		if (setA) {
			unansweredQuestionsSetA = questionsSetA.ToList<QuestionsSetA> ();
		}

		if (setB) {
			unansweredQuestionsSetB = questionsSetB.ToList<QuestionsSetB> ();
		}
	}

	void SetRandomQuestion () {
		if (setA) {
			currentQuestionIndex = Random.Range (0, unansweredQuestionsSetA.Count);
			currentQuestionSetA = unansweredQuestionsSetA[currentQuestionIndex];
			questionImage.sprite = currentQuestionSetA.imageQuestionSetA;
			unansweredQuestionsSetA.RemoveAt (currentQuestionIndex);
		}

		if (setB) {
			currentQuestionIndex = Random.Range (0, unansweredQuestionsSetB.Count);
			currentQuestionSetB = unansweredQuestionsSetB[currentQuestionIndex];
			questionImage.sprite = currentQuestionSetB.ImageQuestionSetB;
			unansweredQuestionsSetB.RemoveAt (currentQuestionIndex);
		}
	}

	public void CheckAnswer (int ans) {
		if (ans == currentQuestionSetA.answerSetA) {
			Debug.Log ("Correct!");
			//memo: place score code here
			//Animation Please
		} else if (ans == currentQuestionSetB.answerSetB) {
			Debug.Log ("Correct");
			//memo: place score code here
			//Animation Please
		} else {
			Debug.Log ("Wrong!");
			//Animation Please
		}

		CheckQuestionList ();
	}

	void CheckQuestionList () {
		if (setA) {
			if (unansweredQuestionsSetA.Count == 0 || unansweredQuestionsSetA == null) {
				Debug.Log ("Finish SetA!");
				setA = false;
				setB = true;
				SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
				return;
				// SetB
				// Some kind of transition before starting setB
			} else {
				SetRandomQuestion ();
			}
		}

		if (setB) {
			if (unansweredQuestionsSetB.Count == 0 || unansweredQuestionsSetB == null) {
				Debug.Log ("Finish SetB!");
				setB = false;
				setC = true;
				SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
				// Some kind of transition before starting setC
			} else {
				SetRandomQuestion ();
			}
		}
	}

	void hideDisableSetAButtons () {
		if (setB) {
			GameObject.Find ("SetA").SetActive (false);
			if (setBButtons.activeInHierarchy == false) {
				setBButtons.SetActive (true);
			}
		} else {
			return;
		}
	}
}
