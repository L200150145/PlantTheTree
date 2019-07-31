using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySound : MonoBehaviour {

    public AudioSource InventSound;
    public AudioClip collisionSound;

    // Use this for initialization
    void Start () {
        InventSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Player")
        {
            InventSound.PlayOneShot(collisionSound);
        }
    }
}
