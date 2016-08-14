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
	public Animator animator;

	public Text outCome1, outCome2, outCome3, outCome4, outCome5;

	public Image questionImage;
	private int currentQuestionIndex;

	public static bool setA = true, setB = false, setC = false;
	private bool answerCorrect;

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
			answerCorrect = true;
			//memo: place score code here
			//Animation Please
		} else if (ans == currentQuestionSetB.answerSetB) {
			Debug.Log ("Correct");
			answerCorrect = true;
			//memo: place score code here
			//Animation Please
		} else {
			Debug.Log ("Wrong!");
			answerCorrect = false;
			//Animation Please
		}

		AnimateButtons (ans);
		CheckQuestionList ();
		GiveOutcomeAnswer (ans, answerCorrect);
	}

	void CheckQuestionList () {
		if (setA) {
			if (unansweredQuestionsSetA.Count == 0 || unansweredQuestionsSetA == null) {
				Debug.Log ("Finish SetA!");
				StartCoroutine (CountToSetB ());
				return;
				// SetB
				// Some kind of transition before starting setB
			} else {
				StartCoroutine (CountToTransition ());
			}
		}

		if (setB) {
			if (unansweredQuestionsSetB.Count == 0 || unansweredQuestionsSetB == null) {
				Debug.Log ("Finish SetB!");
				StartCoroutine (CountToSetC ());
				// Some kind of transition before starting setC
			} else {
				StartCoroutine (CountToTransition ());
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

	IEnumerator CountToTransition () {
		yield return new WaitForSeconds (1.5f);
		SetRandomQuestion ();
		animator.SetTrigger ("4");
	}

	IEnumerator CountToSetB () {
		yield return new WaitForSeconds (1.5f);
		setA = false;
		setB = true;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	IEnumerator CountToSetC () {
		yield return new WaitForSeconds (1.5f);
		setB = false;
		setC = true;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	void GiveOutcomeAnswer (int answ, bool answerCorrect) {
		if (setA) {
			if (answ == 1 && answerCorrect == true) {
				outCome1.text = "Correct";
			} else if (answ == 2 && answerCorrect == true) {
				outCome2.text = "Correct"; 
			} else if (answ == 3 && answerCorrect == true) {
				outCome3.text = "Correct";
			} else {
				outCome1.text = "Wrong";
				outCome2.text = "Wrong";
				outCome3.text = "Wrong";
			}
		}


		if (setB) {
			if (answ == 1 && answerCorrect == true) {
				outCome4.text = "Correct";
			} else if (answ == 2 && answerCorrect == true) {
				outCome5.text = "Correct";
			} else {
				outCome4.text = "Wrong";
				outCome5.text = "Wrong";
			}
		}
	}

	void AnimateButtons (int answe) {
		if (answe == 1) {
			animator.SetTrigger ("1");
		} else if (answe == 2) {
			animator.SetTrigger ("2");
		} else if (answe == 3) {
			animator.SetTrigger ("3");
		} else {
			return;
		}
	}
}
