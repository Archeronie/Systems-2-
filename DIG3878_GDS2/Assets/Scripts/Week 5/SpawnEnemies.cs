using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public bool isSpawned=false;

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
            if (col.gameObject.tag == "Spawner")
            {
                if (isSpawned == false)
                {
                    enemy.SetActive(true);
                    isSpawned = true;
                }
                else if (isSpawned == true)
                {
                    enemy.SetActive(false);
                    isSpawned = false;
                }


            }
    }
    
}
