using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VechicleMovementPlayer2 : MonoBehaviour
{
    public GameObject deathbox;
    public GameObject player;
    private Vector3 startPosition;
    private Vector3 direction;
    private float xSpeed = 10f;
    private float Power = 1f;
    private float Friction = 0.1f;
    private bool Right = false;
    private bool left = false;


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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Right = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Right = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            left = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.P))
        {
            player.transform.position = startPosition;
        }

        xSpeed *= Friction;
        transform.Translate(Vector3.right * -xSpeed);
    }
}
