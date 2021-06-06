using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    

    private float xSpeed = 10f;
    private float Power = 1.5f;
    private float Friction = 0.1f;
    private bool Right = false;
    private bool left = false;


    public GameObject deathbox;
    public GameObject player ;
    private Vector3 startPosition;
    private Vector3 direction;

    private void Start()
    {
        
        startPosition = player.transform.position;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "deathbox")
        {
            player.transform.position = startPosition;
        }
    }

    private void FixedUpdate()
    {
        if (Right)
        {
            xSpeed += Power;
        }
        if (left)
        {
            xSpeed -= Power;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Right = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Right = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            left = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1.5f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1.5f, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
            player.transform.position = startPosition;
        }
        xSpeed *= Friction;
        transform.Translate(Vector3.right * -xSpeed);
    }
}
