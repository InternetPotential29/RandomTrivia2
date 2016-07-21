using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour {

    public GameObject Lessons, Quiz, Trivia, Exit, Back, 
        QU1, QU2, QU3, QU4, 
        Unita, Unitb, Unitc, Unitd, 
        U1C1,
        U1C1L1, U1C1L2, U1C1L3,
        U2C1, U2C2, U2C3, U2C4,
        U2C1L1, U2C1L2, U2C1L3, U2C1L4,
        U2C2L1, U2C2L2,
        U2C3L1, U2C3L2, U2C3L3,
        U2C4L1, U2C4L2, U2C4L3, U2C4L4, U2C4L5, U2C4L6;
    public string chosen;
    public void Start()
    {
        Lessons = GameObject.Find("Lessons");
        Quiz = GameObject.Find("Quiz");
        Trivia = GameObject.Find("Trivia");
        Exit = GameObject.Find("Exit");
        Back = GameObject.Find("Back");

        QU1 = GameObject.Find("QU1");
        QU2 = GameObject.Find("QU2");
        QU3 = GameObject.Find("QU3");
        QU4 = GameObject.Find("QU4");

        Unita = GameObject.Find("Unita");
        Unitb = GameObject.Find("Unitb");
        Unitc = GameObject.Find("Unitc");
        Unitd = GameObject.Find("Unitd");

        U1C1 = GameObject.Find("U1C1");
        U1C1L1 = GameObject.Find("U1C1L1");
        U1C1L2 = GameObject.Find("U1C1L2");
        U1C1L3 = GameObject.Find("U1C1L3");

        U2C1 = GameObject.Find("U2C1");
        U2C2 = GameObject.Find("U2C2");
        U2C3 = GameObject.Find("U2C3");
        U2C4 = GameObject.Find("U2C4");

        U2C1L1 = GameObject.Find("U2C1L1");
        U2C1L2 = GameObject.Find("U2C1L2");
        U2C1L3 = GameObject.Find("U2C1L3");
        U2C1L4 = GameObject.Find("U2C1L4");

        U2C2L1 = GameObject.Find("U2C2L1");
        U2C2L2 = GameObject.Find("U2C2L2");

        U2C3L1 = GameObject.Find("U2C3L1");
        U2C3L2 = GameObject.Find("U2C3L2");
        U2C3L3 = GameObject.Find("U2C3L3");

        U2C4L1 = GameObject.Find("U2C4L1");
        U2C4L2 = GameObject.Find("U2C4L2");
        U2C4L3 = GameObject.Find("U2C4L3");
        U2C4L4 = GameObject.Find("U2C4L4");
        U2C4L5 = GameObject.Find("U2C4L5");
        U2C4L6 = GameObject.Find("U2C4L6");

        Back.SetActive(false);
        QU1.SetActive(false);
        QU2.SetActive(false);
        QU3.SetActive(false);
        QU4.SetActive(false);
        Unita.SetActive(false);
        Unitb.SetActive(false);
        Unitc.SetActive(false);
        Unitd.SetActive(false);
        U1C1.SetActive(false);
        U1C1L1.SetActive(false);
        U1C1L2.SetActive(false);
        U1C1L3.SetActive(false);
        U2C1.SetActive(false);
        U2C2.SetActive(false);
        U2C3.SetActive(false);
        U2C4.SetActive(false);
        U2C1L1.SetActive(false);
        U2C1L2.SetActive(false);
        U2C1L3.SetActive(false);
        U2C1L4.SetActive(false);
        U2C2L1.SetActive(false);
        U2C2L2.SetActive(false);
        U2C3L1.SetActive(false);
        U2C3L2.SetActive(false);
        U2C3L3.SetActive(false);
        U2C4L1.SetActive(false);
        U2C4L2.SetActive(false);
        U2C4L3.SetActive(false);
        U2C4L4.SetActive(false);
        U2C4L5.SetActive(false);
        U2C4L6.SetActive(false);
    }

    public void CLICK(string name)
    {
        if (name == "Exit")
        {
            Application.Quit();
        }

        if(name == "Lessons")
        {
            
            Lessons.SetActive(false);
            Quiz.SetActive(false);
            Trivia.SetActive(false);
            Exit.SetActive(false);
            Back.SetActive(true);
            Unita.SetActive(true);
            Unitb.SetActive(true);
            Unitc.SetActive(true);
            Unitd.SetActive(true);
        }
        if(name == "Quiz")
        {
            Lessons.SetActive(false);
            Quiz.SetActive(false);
            Trivia.SetActive(false);
            Exit.SetActive(false);
            Back.SetActive(true);
            QU1.SetActive(true);
            QU2.SetActive(true);
            QU3.SetActive(true);
            QU4.SetActive(true);
        }
        if(name == "U1")
        {
            Unita.SetActive(false);
            Unitb.SetActive(false);
            Unitc.SetActive(false);
            Unitd.SetActive(false);
            U1C1.SetActive(true);
        }
        if(name == "U1C1")
        {
            U1C1.SetActive(false);
            U1C1L1.SetActive(true);
            U1C1L2.SetActive(true);
            U1C1L3.SetActive(true);
        }
        if(name == "U2")
        {
            Unita.SetActive(false);
            Unitb.SetActive(false);
            Unitc.SetActive(false);
            Unitd.SetActive(false);
            U2C1.SetActive(true);
            U2C2.SetActive(true);
            U2C3.SetActive(true);
            U2C4.SetActive(true);
        }
        if(name == "U2C1")
        {
            U2C1.SetActive(false);
            U2C2.SetActive(false);
            U2C3.SetActive(false);
            U2C4.SetActive(false);
            U2C1L1.SetActive(true);
            U2C1L2.SetActive(true);
            U2C1L3.SetActive(true);
            U2C1L4.SetActive(true);
        }
        if(name == "U2C2")
        {
            U2C1.SetActive(false);
            U2C2.SetActive(false);
            U2C3.SetActive(false);
            U2C4.SetActive(false);
            U2C2L1.SetActive(true);
            U2C2L2.SetActive(true);
        }
        if(name == "U2C3")
        {
            U2C1.SetActive(false);
            U2C2.SetActive(false);
            U2C3.SetActive(false);
            U2C4.SetActive(false);
            U2C3L1.SetActive(true);
            U2C3L2.SetActive(true);
            U2C3L3.SetActive(true);
        }
        if(name == "U2C4")
        {
            U2C1.SetActive(false);
            U2C2.SetActive(false);
            U2C3.SetActive(false);
            U2C4.SetActive(false);
            U2C4L1.SetActive(true);
            U2C4L2.SetActive(true);
            U2C4L3.SetActive(true);
            U2C4L4.SetActive(true);
            U2C4L5.SetActive(true);
            U2C4L6.SetActive(true);
        }
    }
    public void BackPress()
    {
        if (QU1.activeSelf == true)
        {
            Lessons.SetActive(true);
            Quiz.SetActive(true);
            Trivia.SetActive(true);
            Exit.SetActive(true);
            Back.SetActive(false);
            QU1.SetActive(false);
            QU2.SetActive(false);
            QU3.SetActive(false);
            QU4.SetActive(false);
        }
        else if (U1C1L1.activeSelf == true)
        {
            U1C1.SetActive(true);
            U1C1L1.SetActive(false);
            U1C1L2.SetActive(false);
            U1C1L3.SetActive(false);
        } else if (U1C1.activeSelf == true)
        {
            Unita.SetActive(true);
            Unitb.SetActive(true);
            Unitc.SetActive(true);
            Unitd.SetActive(true);
            U1C1.SetActive(false);
        } else if (Unita.activeSelf == true)
        {

            Lessons.SetActive(true);
            Quiz.SetActive(true);
            Trivia.SetActive(true);
            Exit.SetActive(true);
            Back.SetActive(false);
            Unita.SetActive(false);
            Unitb.SetActive(false);
            Unitc.SetActive(false);
            Unitd.SetActive(false);
        } else if (U2C1.activeSelf == true) {
            Unita.SetActive(true);
            Unitb.SetActive(true);
            Unitc.SetActive(true);
            Unitd.SetActive(true);
            U2C1.SetActive(false);
            U2C2.SetActive(false);
            U2C3.SetActive(false);
            U2C4.SetActive(false);
        } else if (U2C1L1.activeSelf == true)
        {
            U2C1.SetActive(true);
            U2C2.SetActive(true);
            U2C3.SetActive(true);
            U2C4.SetActive(true);
            U2C1L1.SetActive(false);
            U2C1L2.SetActive(false);
            U2C1L3.SetActive(false);
            U2C1L4.SetActive(false);
        } else if (U2C2L1.activeSelf == true)
        {
            U2C1.SetActive(true);
            U2C2.SetActive(true);
            U2C3.SetActive(true);
            U2C4.SetActive(true);
            U2C2L1.SetActive(false);
            U2C2L2.SetActive(false);
        } else if (U2C3L1.activeSelf == true)
        {
            U2C1.SetActive(true);
            U2C2.SetActive(true);
            U2C3.SetActive(true);
            U2C4.SetActive(true);
            U2C3L1.SetActive(false);
            U2C3L2.SetActive(false);
            U2C3L3.SetActive(false);
        } else if (U2C4L1.activeSelf == true)
        {
            U2C1.SetActive(true);
            U2C2.SetActive(true);
            U2C3.SetActive(true);
            U2C4.SetActive(true);
            U2C4L1.SetActive(false);
            U2C4L2.SetActive(false);
            U2C4L3.SetActive(false);
            U2C4L4.SetActive(false);
            U2C4L5.SetActive(false);
            U2C4L6.SetActive(false);
        }
    }
}
