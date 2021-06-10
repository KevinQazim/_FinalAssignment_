using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour
{
    public Text timerText;
    public Text timerTextPlayer2;

    public Text lapNumber;
    public Text lapNumber2;

    public Text lap;
    public Text lap2;

   
    public float startTimer;
    public float lapTimer;
    public float lapTimer2;

   
    
    void Start()
    {
        startTimer = Time.time;
        lapTimer = Time.time;
        lapTimer2 = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTimer;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
        timerTextPlayer2.text = minutes + ":" + seconds;
        

    }
    
}
