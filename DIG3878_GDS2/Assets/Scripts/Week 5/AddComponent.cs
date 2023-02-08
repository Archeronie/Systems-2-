using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddComponent : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col)
    {

       if (col.gameObject.name == "Cube_RED")
        {
            if (!col.gameObject.GetComponent<Rigidbody>())
            {
                col.gameObject.AddComponent<Rigidbody>();
            }
        }
    }
}
