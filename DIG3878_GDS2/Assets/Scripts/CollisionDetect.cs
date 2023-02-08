using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Cube")
        {
            Debug.Log("Hit the CUBE");
        }
        if (col.gameObject.tag == "Sphere")
        {
            Debug.Log("Hit the SPHERE");
        }
        if (col.gameObject.tag == "Cylinder")
        {
            Debug.Log("Hit the CYLINDER");
        }
    }
}
