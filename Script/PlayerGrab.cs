using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour {

    public GameObject seed;
    public GameObject myHand;

    bool inHands;
    Vector3 seedPos;

	// Use this for initialization
	void Start () {

        seedPos = seed.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                seed.transform.SetParent(myHand.transform);
                seed.transform.localPosition = new Vector3(0f, -.482f, 0f);
                inHands = true;
            }
             else if (inHands)
            {
                this.GetComponent<PlayerGrab>().enabled = false;
                seed.transform.SetParent(null);
                seed.transform.localPosition = seedPos;
                inHands = false;
            }
        }
		
	}
}
