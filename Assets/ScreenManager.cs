using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour {

    GameObject unita, unitb, unitc, unitd;

    public void Start()
    {
        unita = GameObject.Find("unita");
        unitb = GameObject.Find("unitb");
        unitc = GameObject.Find("unitc");
        unitd = GameObject.Find("unitd");
    }

    public void Exit()
    {
            Application.Quit();
    }
    public void Lessons()
    {
        unita.SetActive(true);
        unitb.SetActive(true);
        unitc.SetActive(true);
        unitd.SetActive(true);
        GameObject.Find("Lessons").SetActive(false);
        GameObject.Find("Quiz").SetActive(false);
        GameObject.Find("Trivia").SetActive(false);
        GameObject.Find("Exit").SetActive(false);

    }
}
