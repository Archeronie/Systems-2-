using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateGameObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1, 0, -1);
        transform.Rotate(2, 1, 1);
        transform.Translate(-1, 0, 1);
    }
}
