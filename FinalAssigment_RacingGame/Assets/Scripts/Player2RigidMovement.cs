using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2RigidMovement : MonoBehaviour
{
    public Rigidbody Rig;

    public float forwardAccel = 10f, reverse = 5f, maxSpeed = 15f, turnStrength = 180f;

    
     void Update()
    {
        
        transform.position = Rig.transform.position;
    }
    private void FixedUpdate()
    {
        Rig.AddForce(transform.forward * forwardAccel);
    }
}
