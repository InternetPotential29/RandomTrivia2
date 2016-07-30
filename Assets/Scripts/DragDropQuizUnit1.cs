using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragDropQuizUnit1 : MonoBehaviour {
	public QuestionsSetC[] questionsSetC;
	private static List<QuestionsSetC> unansweredQuestionsSetC;
	private QuestionsSetC currentQuestionSetC;

	public Image answerImageA;
	public Image answerImageB;
	public Text questionText;

	public static int currentQuestionIndex;

	private DragHandler dragHandler;

	void Start () {
		unansweredQuestionsSetC = questionsSetC.ToList<QuestionsSetC> ();
		SetRandomQuestion ();
	}

	void SetRandomQuestion () {
		currentQuestionSetC = unansweredQuestionsSetC[currentQuestionIndex];
		answerImageA.sprite = currentQuestionSetC.imageGiven1SetC;
		answerImageB.sprite = currentQuestionSetC.imageGiven2SetC;
		questionText.text = currentQuestionSetC.QuestionSetC;
	}

	public void checkImageAnswer (GameObject objAnswer) {
		if (objAnswer.tag == currentQuestionSetC.answerSetC) {
			Debug.Log ("Correct!");
			// Animation of Correct (Transition Before next Question)
		} else {
			Debug.Log ("Wrong!");
		}

		checkQuestList ();
	}

	void checkQuestList () {
		if (currentQuestionIndex == 1) {
			Debug.Log ("Finish!");
		} else {
			Debug.Log ("WAT");
			currentQuestionIndex++;
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}
}
