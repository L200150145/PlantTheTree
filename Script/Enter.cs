using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour {

    public GameObject WaterCanTrigger;

    private void OnTriggerEnter()
    {
        WaterCanTrigger.SetActive(true);
    }
}
