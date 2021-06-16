using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet_emitter;
    public float speed = 100f;
    public AudioSource shot;
    public int cdTimer;
    public int cdRequirment;


    void Update()
    {
        cdTimer++;
        if(cdTimer > cdRequirment)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GameObject temporaryBulletHandler;
                temporaryBulletHandler = Instantiate(bullet, bullet_emitter.transform.position, bullet_emitter.transform.rotation) as GameObject;
                temporaryBulletHandler.transform.Rotate(Vector3.left * 90);
                Rigidbody temporaryRigidBody;
                temporaryRigidBody = temporaryBulletHandler.GetComponent<Rigidbody>();
                temporaryRigidBody.AddForce(transform.forward * speed);
                Destroy(temporaryBulletHandler, 3.0f);
                shot.Play();
                cdTimer = 0;
            }
        }
  
    }
}
