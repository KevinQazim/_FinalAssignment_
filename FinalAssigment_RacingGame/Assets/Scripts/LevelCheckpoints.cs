using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckpoints : MonoBehaviour
{

    private List<Checkpoints> checkpointsList;
    private List<int> nextCheckpointIndexList;
    [SerializeField] private List<Transform> carTransformList;



    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");

        checkpointsList = new List<Checkpoints>();

        foreach (Transform checkpoints1Transform in checkpointsTransform)
        {
            Checkpoints checkpoints = checkpoints1Transform.GetComponent<Checkpoints>();
            checkpoints.SetLevelCheckpoints(this);
            checkpointsList.Add(checkpoints);
        }

        nextCheckpointIndexList = new List<int>();

        foreach (Transform carTransform in carTransformList)
        {
            nextCheckpointIndexList.Add(0);
        }
        

    }

    //This shows the specific checkpoint that the player has just passed
    public void CarPassedCheckpoint(Checkpoints checkpoints, Transform carTransform)
    {
        Debug.Log(checkpoints.transform.name);
        Debug.Log(checkpointsList.IndexOf(checkpoints));

        int nextCheckpointIndex = nextCheckpointIndexList[carTransformList.IndexOf(carTransform)];

        if (checkpointsList.IndexOf(checkpoints) == nextCheckpointIndex)
        {
            //showing the player if they are going the right way by checking if they hit the checkpoint in order
            nextCheckpointIndexList[carTransformList.IndexOf(carTransform)] = (nextCheckpointIndex + 1) % checkpointsList.Count;

            Debug.Log("Right Way");
        }
        else
        {
            Debug.Log("Wrong Way");
        }

    }
}
