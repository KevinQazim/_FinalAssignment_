using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour
{
    public GameObject bullet2;
    public GameObject bullet_emitter2;
    public float speed2 = 100f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            GameObject temporaryBulletHandler;
            temporaryBulletHandler = Instantiate(bullet2,bullet_emitter2.transform.position,bullet_emitter2.transform.rotation) as GameObject;
            temporaryBulletHandler.transform.Rotate(Vector3.left * 90);
            Rigidbody temporaryRigidBody;
            temporaryRigidBody = temporaryBulletHandler.GetComponent<Rigidbody>();
            temporaryRigidBody.AddForce(transform.forward * speed2);
            Destroy(temporaryBulletHandler, 3.0f);
        }  
    }
}
