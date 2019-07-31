using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    public GameObject Panel;
    public GameObject Start;
    public GameObject Continue;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            bool isActive2 = Start.activeSelf;
            bool isActive3 = Continue.activeSelf;

            Panel.SetActive(!isActive);
            Start.SetActive(isActive);
            Continue.SetActive(isActive);
        }
    }
}
