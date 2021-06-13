using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapManager : MonoBehaviour
{
    public UIscript ui;
    List<long> lapTimes = new List<long>();

    public Text player1LapCounter;
    public Text player2LapCounter;
    private int player1Lap;
    private int player2Lap;


    public Text timerText;
    public Text timerTextPlayer2;

    public Text Player1LapTimerText;
    public Text Player2LapTimerText;
  
    
    public float lapTimer;
    public float lapTimer2;

    public Text P1lap1;
    public Text P1lap2;
    public Text P1lap3;

    public Text P2lap1;
    public Text P2lap2;
    public Text P2lap3;


    public GameObject WinGamePanel;
    public Text WinningPlayer;
    public Text PlayerWinningTime;
    void Start()
    {
        
        lapTimer = Time.time;
        lapTimer2 = Time.time;
    }
    void ResetPlayer1Time()
    {
        lapTimer = Time.time;       
    }
    void ResetPlayer2Time()
    {
        lapTimer2 = Time.time;
    }

    public void Update()
    {
        
        float tx = Time.time - lapTimer;
        float txx = Time.time - lapTimer2;

        string Player1minutes = ((int)tx / 60).ToString();
        string Player1seconds = (tx % 60).ToString("f2");

        string Player2minutes = ((int)txx / 60).ToString();
        string Player2seconds = (txx % 60).ToString("f2");

        Player1LapTimerText.text = Player1minutes + ":" + Player1seconds;
        Player2LapTimerText.text = Player2minutes + ":" + Player2seconds;

        
     }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "player1")
        {
            player1Lap++;
            player1LapCounter.text = player1Lap.ToString();
            ResetPlayer1Time();
            if(player1Lap >= 3)
            {
                WinGamePanel.SetActive(true);
                PlayerWinningTime.text = lapTimer.ToString();
                WinningPlayer.text = ("Player 1 Is Our Winner");
            }
        }
        if (other.tag == "player2")
        {
            player2Lap++;
            player2LapCounter.text = player2Lap.ToString();
            ResetPlayer2Time();
            if(player2Lap >= 3)
            {
                WinGamePanel.SetActive(true);
                WinningPlayer.text = ("Player 2 Is Our Winner");
                PlayerWinningTime.text = lapTimer.ToString();
            }
        }
    }
}
