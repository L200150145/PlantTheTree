using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoringLevel3 : MonoBehaviour
{

    public Text scoreText;
    public int score;
    
    // Use this for initialization

    void OnMouseEnter()
    {
        score++;
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.GetComponent<Text>().text = "" + score;

        
    }
}