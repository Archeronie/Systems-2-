using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour
{
    public GameObject bouncyBall;
    public GameObject bouncyCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        { 
            Instantiate(bouncyBall, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(bouncyCube, transform.position, transform.rotation);
        }
    }
}
