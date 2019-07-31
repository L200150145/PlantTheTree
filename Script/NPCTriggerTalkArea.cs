using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCTriggerTalkArea : MonoBehaviour {

    [SerializeField] private Image Icon;
    [SerializeField] private Image seru;
    [SerializeField] private Text text;
    

    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Icon.enabled = true;
            seru.enabled = true;
            text.enabled = true;
        } else
        {
            Icon.enabled = false;
            seru.enabled = false;
            text.enabled = false;
        }
    }
}
