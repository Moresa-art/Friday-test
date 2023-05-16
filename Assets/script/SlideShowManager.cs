using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideShowManager : MonoBehaviour
{

    public GameObject[] slides;
    public int currentSlide;


    // Start is called before the first frame update
    void Start()
    {
        currentSlide= 0;
        ShowSlide(currentSlide);


    }


    void ShowSlide(int slideIndex)
    {
        foreach (var slide in slides)
        {
            slide.SetActive(false);
        }
        slides[slideIndex].SetActive(true);
    }

    public void NextSlide ()
    {
        currentSlide++;
        
        if(currentSlide >= slides.Length) { currentSlide = 0; }
        ShowSlide(currentSlide);

    }

    public void PreviousSlide()
    {
        currentSlide--;
        if (currentSlide < 0) { currentSlide = slides.Length - 1; }
        ShowSlide(currentSlide);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
