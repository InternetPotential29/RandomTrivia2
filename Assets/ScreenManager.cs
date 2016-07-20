using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour {

    public GameObject Unita, Unitb, Unitc, Unitd, U1C1, U1C1L1, U1C1L2, U1C1L3;

    public void Start()
    {
        Unita = GameObject.Find("Unita");
        Unitb = GameObject.Find("Unitb");
        Unitc = GameObject.Find("Unitc");
        Unitd = GameObject.Find("Unitd");
        U1C1 = GameObject.Find("U1C1");
        U1C1L1 = GameObject.Find("U1C1L1");
        U1C1L2 = GameObject.Find("U1C1L2");
        U1C1L3 = GameObject.Find("U1C1L3");
        Unita.SetActive(false);
        Unitb.SetActive(false);
        Unitc.SetActive(false);
        Unitd.SetActive(false);
        U1C1.SetActive(false);
        U1C1L1.SetActive(false);
        U1C1L2.SetActive(false);
        U1C1L3.SetActive(false);
    }

    public void CLICK(string name)
    {

        if (name == "Exit")
        {
            Application.Quit();
        }
        if(name == "Return")
        {
            GameObject.Find("Lessons").SetActive(true);
            GameObject.Find("Quiz").SetActive(true);
            GameObject.Find("Trivia").SetActive(true);
            GameObject.Find("Exit").SetActive(true);
            Unita.SetActive(false);
            Unitb.SetActive(false);
            Unitc.SetActive(false);
            Unitd.SetActive(false);
        }
        if(name == "Lessons")
        {
            
            GameObject.Find("Lessons").SetActive(false);
            GameObject.Find("Quiz").SetActive(false);
            GameObject.Find("Trivia").SetActive(false);
            GameObject.Find("Exit").SetActive(false);
            Unita.SetActive(true);
            Unitb.SetActive(true);
            Unitc.SetActive(true);
            Unitd.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CLICK("Return");
            }
        }
        if(name == "U1")
        {
            Unita.SetActive(false);
            Unitb.SetActive(false);
            Unitc.SetActive(false);
            Unitd.SetActive(false);
            U1C1.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CLICK("Lessons");
            }
        }
        if(name == "U1C1")
        {
            U1C1.SetActive(false);
            U1C1L1.SetActive(true);
            U1C1L2.SetActive(true);
            U1C1L3.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CLICK("U1");
            }
        }
    }

}
