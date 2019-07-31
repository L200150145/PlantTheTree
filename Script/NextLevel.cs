using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public GameObject canvas;
	
	// Update is called once per frame
	void Update () {

        if (canvas.activeInHierarchy == true)
        {
             if (Input.GetMouseButtonUp(0))
                    {
                        SceneManager.LoadScene("level_1");
                    }
        }
	}
}
