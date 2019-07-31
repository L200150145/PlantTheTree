using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_PopUp : MonoBehaviour {

    public GameObject FirstMessage;

    public void CloseMessage()
    {
        if (FirstMessage != null)
        {
            bool isActive = FirstMessage.activeSelf;

            FirstMessage.SetActive(!isActive);
        }
    }
}
