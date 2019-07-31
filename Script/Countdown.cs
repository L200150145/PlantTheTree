using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public float timeLeft = 3.0f;
    public Text startText;
    public GameObject gameover;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            gameover.SetActive(true);
            Debug.Break();
        }
	}
}
