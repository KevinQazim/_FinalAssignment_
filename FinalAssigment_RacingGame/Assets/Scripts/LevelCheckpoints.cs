using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckpoints : MonoBehaviour
{

    private List<Checkpoints> checkpointsList;
    private List<int> nextCheckpointIndexList;
    [SerializeField] private List<Transform> carTransformList;

    public VechicleMovementPlayer2 player2Start;
    public VehicleMovement playerstart;
    



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
    public void Car1PassedCheckpoint(Checkpoints checkpoints, Transform carTransform)
    {
        Debug.Log(checkpoints.transform.name);
        Debug.Log("Car 1 Has passed");
        Debug.Log(checkpointsList.IndexOf(checkpoints));

        //setting start position

        playerstart.GetComponent<VehicleMovement>().spawnPosition = checkpoints.transform.position;

       

        int nextCheckpointIndex = nextCheckpointIndexList[carTransformList.IndexOf(carTransform)];

        if (checkpointsList.IndexOf(checkpoints) == nextCheckpointIndex)
        {
            //showing the player if they are going the right way by checking if they hit the checkpoint in order
            nextCheckpointIndexList[carTransformList.IndexOf(carTransform)] = (nextCheckpointIndex + 1) % checkpointsList.Count;

          
        }
       

    }

    public void Car2PassedCheckpoint(Checkpoints checkpoints, Transform carTransform)
    {
        Debug.Log(checkpoints.transform.name);
        Debug.Log("car 2 has passed");
        Debug.Log(checkpointsList.IndexOf(checkpoints));

        //setting start position
        player2Start.GetComponent<VechicleMovementPlayer2>().spawnPosition2 = checkpoints.transform.position;


        int nextCheckpointIndex = nextCheckpointIndexList[carTransformList.IndexOf(carTransform)];

        if (checkpointsList.IndexOf(checkpoints) == nextCheckpointIndex)
        {
            //showing the player if they are going the right way by checking if they hit the checkpoint in order
            nextCheckpointIndexList[carTransformList.IndexOf(carTransform)] = (nextCheckpointIndex + 1) % checkpointsList.Count;

           
        }
    }
}
