using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Cube_RED")
        {
            ScoreCount.gscore += 1; //addscore
        }
    }
}
