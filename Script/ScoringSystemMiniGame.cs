using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystemMiniGame : MonoBehaviour {

    public GameObject scoreText;
    public static int theScore;
    public GameObject satu;
    public audio;


    void Update()
    {
        scoreText.GetComponent<Text>().text = "" + theScore;
        if (ScoringSystemMiniGame.theScore == 5)
        {
            satu.SetActive(true);
            audio.setActive(false);
        }
    }

}
