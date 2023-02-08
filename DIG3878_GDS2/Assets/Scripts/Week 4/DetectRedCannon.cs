using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRedCannon : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "RedCannon")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            //Self Desctruction code
        }
    }
}
