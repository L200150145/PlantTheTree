using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {

    public void GameQuit()
    {
        Debug.Log("Player has quit");
        Application.Quit();
    }
}
