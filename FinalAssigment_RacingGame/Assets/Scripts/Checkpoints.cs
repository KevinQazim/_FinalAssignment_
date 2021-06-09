using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    private LevelCheckpoints levelCheckpoints;


    private void OnTriggerEnter(Collider other)
    {

        //Checking if the player passed the checkpoint
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("checkpointpassed");

            levelCheckpoints.PlayerPassedCheckpoint(this);
        }
    }

    public void SetLevelCheckpoints(LevelCheckpoints levelCheckpoints)
    {
        this.levelCheckpoints = levelCheckpoints;
    }
}
