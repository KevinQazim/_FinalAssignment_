using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet_emitter;
    public float speed = 100f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject temporaryBulletHandler;
            temporaryBulletHandler = Instantiate(bullet,bullet_emitter.transform.position,bullet_emitter.transform.rotation) as GameObject;
            temporaryBulletHandler.transform.Rotate(Vector3.left * 90);
            Rigidbody temporaryRigidBody;
            temporaryRigidBody = temporaryBulletHandler.GetComponent<Rigidbody>();
            temporaryRigidBody.AddForce(transform.forward * speed);
            Destroy(temporaryBulletHandler, 10.0f);
        }  
    }
}
