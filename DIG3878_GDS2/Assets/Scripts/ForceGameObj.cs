using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceGameObj : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, speed);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
