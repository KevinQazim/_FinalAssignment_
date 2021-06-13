using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoints : MonoBehaviour
{
    private LevelCheckpoints levelCheckpoints;

    

    private void OnTriggerEnter(Collider other)
    {
        
        //Checking if the player passed the checkpoint
        if (other.gameObject.tag == "player1")
        {
            Debug.Log("checkpointpassedCar1");
            
            levelCheckpoints.Car1PassedCheckpoint(this, other.transform);
        }

        if (other.gameObject.tag == "player2")
        {
            Debug.Log("checkpointpassedCar2");

            levelCheckpoints.Car2PassedCheckpoint(this, other.transform);
        }
    }

    public void SetLevelCheckpoints(LevelCheckpoints levelCheckpoints)
    {
        //setting up the order of the checkpoints
        this.levelCheckpoints = levelCheckpoints;
    }
}
