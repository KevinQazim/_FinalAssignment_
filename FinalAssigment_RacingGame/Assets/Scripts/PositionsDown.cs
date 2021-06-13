using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionsDown : MonoBehaviour
{
    public Text positions;
    public Text positions2;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == ("CarPos"))
        {
            positions.text = "2/2";
            positions2.text = "1/2";
        }
    }
}
