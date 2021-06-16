using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostScript : MonoBehaviour
{
    public VehicleMovement player1Speed;
    public VechicleMovementPlayer2 player2Speed;

    public float boostDurationCar1;
    public float boostTimeCar1;

    public float boostDurationCar2;
    public float boostTimeCar2;

    public AudioSource boostSound;

    // Start is called before the first frame update

    public void Start()
    {
        boostTimeCar1 = 0;

        boostTimeCar2 = 0;
    }

    public void Update()
    {
        boostTimeCar1 += Time.deltaTime;

        boostTimeCar2 += Time.deltaTime;

        if (boostTimeCar1 >= boostDurationCar1)
        {
            player1Speed.GetComponent<VehicleMovement>().Power = 1.5f;

            boostTimeCar1 = 0;
        }

        if (boostTimeCar2 >= boostDurationCar2)
        {
            player2Speed.GetComponent<VechicleMovementPlayer2>().Power = 1.5f;

            boostTimeCar2 = 0;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player1")
        {
            boostTimeCar1 = 0;
            boostSound.Play();
            player1Speed.GetComponent<VehicleMovement>().Power = 2f;

        }

        if (other.gameObject.tag == "player2")
        {
            boostTimeCar2 = 0;
            boostSound.Play();
            player2Speed.GetComponent<VechicleMovementPlayer2>().Power = 2f;
        }
    }
}
