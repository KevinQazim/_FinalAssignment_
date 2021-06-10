using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour
{
    public Text timerText;
    public Text timerTextPlayer2;
    public Text laptext;
    public Text laptext2;
    public Text positions1;
    public Text positions2;
    private float startTimer;

    private bool playerhitcheckpoint1;
    
    void Start()
    {
        startTimer = Time.time;
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
