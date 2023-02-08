using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDestroyObj : MonoBehaviour
{
    public GameObject myCube;
    public GameObject mySphere;
    private bool cubeActive = true;
    private bool sphereActive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        { 
            if (cubeActive==true)
            {
                myCube.SetActive(false);
                cubeActive = false;
            }
            else if (cubeActive==false)
            {
                myCube.SetActive(true);
                cubeActive = true;
            }
        }
        if (sphereActive == true)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                myCube.SetActive(false);
                sphereActive = false;
            }
        }
        if (cubeActive == false)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                mySphere.SetActive(true);
                sphereActive = true;
            }
        }

    }
}
