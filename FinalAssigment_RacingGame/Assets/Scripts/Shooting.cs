using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    private Rigidbody therigidbody;
    public int speed = 5;
    public int lifeTime = 120;
    public int timeAlive = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            therigidbody.velocity = new Vector3(0, 0, speed);
        }  
    }
}
