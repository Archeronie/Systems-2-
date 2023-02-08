using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static int gscore = 0;
    public GameObject youWin;

    public TMPro.TMP_Text scoreText;
    void Update()
    {
        scoreText.text = "SCORE: " + gscore;

        if (gscore >=5)
        {
            youWin.SetActive(true);
        }
    }
}
