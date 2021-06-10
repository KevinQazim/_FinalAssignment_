using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionsManager : MonoBehaviour
{
    public Text positions;
    public Text positions2;
    public bool playerpass;
    public bool playerpass2;
    public bool playerpass3;
    public bool playerpass4;
    public bool playerpass5;
    public bool playerpass6;
    public bool playerpass7;
    public bool playerpass8;
    public bool playerpass9;
    public bool playerpass10;
    

    public void OnTriggerEnter(Collider other)
    {
        if(playerpass == false)
        {
            if (other.tag == "player1")
            {
                playerpass = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass2 = false;
            }
            if (other.tag == "player2")
            {
                playerpass = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass2 = false;
            }
            
        }

        if (playerpass2 == false)
        {
            if (other.tag == "player1")
            {
                playerpass2 = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass3 = false;
            }
            if (other.tag == "player2")
            {
                playerpass2 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass3 = false;
            }
            
        }
        if (playerpass3 == false)
        {
            if (other.tag == "player1")
            {
                playerpass3 = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass4 = false;
            }
            if (other.tag == "player2")
            {
                playerpass3 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass4 = false;
            }
            
        }
        if (playerpass4 == false)
        {
            if (other.tag == "player1")
            {
                playerpass4 = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass5 = false;
            }
            if (other.tag == "player2")
            {
                playerpass4 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass5 = false;
            }
           
        }
        if (playerpass5 == false)
        {
            if (other.tag == "player1")
            {
                playerpass5 = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass6 = false;
            }
            if (other.tag == "player2")
            {
                playerpass5 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass6 = false;
            }
          
        }
        if (playerpass6 == false)
        {
            if (other.tag == "player1")
            {
                playerpass6 = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass7 = false;
            }
            if (other.tag == "player2")
            {
                playerpass6 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass7 = false;
            }
           
        }
        if (playerpass7 == false)
        {
            if (other.tag == "player1")
            {
                playerpass7 = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass8 = false;
            }
            if (other.tag == "player2")
            {
                playerpass7 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass8 = false;
            }
           
        }
        if (playerpass8 == false)
        {
            if (other.tag == "player1")
            {
                playerpass8  = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass9 = false;
            }
            if (other.tag == "player2")
            {
                playerpass8 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass9 = false;
            }
            
        }
        if (playerpass9 == false)
        {
            if (other.tag == "player1")
            {
                playerpass9 = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                playerpass10 = false;
            }
            if (other.tag == "player2")
            {
                playerpass9 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                playerpass10 = false;
            }
            
        }
        if (playerpass10 == false)
        {
            if (other.tag == "player1")
            {
                playerpass10 = true;
                positions.text = ("1/2");
                positions2.text = ("2/2");
                
               
                
            }
            if (other.tag == "player2")
            {
                playerpass10 = true;
                positions.text = ("2/2");
                positions2.text = ("1/2");
                
               
                
            }
            
            
        }
    }
}
