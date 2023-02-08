using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScript_2 : MonoBehaviour
{
    public GameObject cube;
    public Material matDW;
    public Material matUF;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            cube.GetComponent<Renderer>().material = matDW;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            cube.GetComponent<Renderer>().material = matUF;
        }
    }
}
