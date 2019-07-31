using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin2 : MonoBehaviour {


    public float spinValue = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, spinValue, 0);

    }
}
