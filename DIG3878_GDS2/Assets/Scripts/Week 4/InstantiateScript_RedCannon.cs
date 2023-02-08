using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript_RedCannon : MonoBehaviour
{
    public GameObject RedCannon;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Launch Red Cannon");
            Instantiate(RedCannon, transform.position, transform.rotation);
        }
    }
}
