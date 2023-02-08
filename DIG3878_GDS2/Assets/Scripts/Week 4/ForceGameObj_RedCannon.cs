using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceGameObj_RedCannon : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 1000.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
