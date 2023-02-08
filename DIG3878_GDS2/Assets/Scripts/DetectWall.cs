using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectWall : MonoBehaviour
{
    void OnCollisionEnter(Collision col1)
    {
        if (col1.gameObject.name == "Wall")
        {
            Debug.Log("Hit the Wall");
            //do something

        }
    }
}
