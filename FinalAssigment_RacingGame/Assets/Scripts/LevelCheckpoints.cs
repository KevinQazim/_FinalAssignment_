using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckpoints : MonoBehaviour
{
    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");

        foreach (Transform checkpoints1Transform in checkpointsTransform)
        {
            

            Checkpoints checkpoints = checkpoints1Transform.GetComponent<Checkpoints>();
            checkpoints.SetLevelCheckpoints(this);
        }
    }

    //This shows the specific checkpoint that the player has just passed
    public void PlayerPassedCheckpoint(Checkpoints checkpoints)
    {
        Debug.Log(checkpoints.transform.name);
    }
}
