using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystemMiniGameMap2 : MonoBehaviour
{

    public GameObject scoreText;
    public static int theScore;
    public GameObject satu;


    void Update()
    {
        scoreText.GetComponent<Text>().text = "" + theScore;
        if (ScoringSystemMiniGameMap2.theScore == 4)
        {
            satu.SetActive(true);
        }
    }

}
