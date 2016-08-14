using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lessons : MonoBehaviour {

    public Sprite[] LessonsImage;
    public Image displayImage;
    public Button nextImage, prevImage;
    public int i = 0;



	public void BtnNext()
    {
        if(i + 1 < LessonsImage.Length)
        {
            i++;
        }
    }
    public void BtnPrev()
    {
        if(i - 1 >= 0)
        {
            i--;
        }
    }
    void Update()
    {
        displayImage.sprite = LessonsImage[i];
    }
}
