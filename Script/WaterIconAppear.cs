using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterIconAppear : MonoBehaviour {

    [SerializeField] private Image WaterCan;

    public AudioClip SoundToPlay;
    public float volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    public GameObject WateringCan;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WaterCan.enabled = true;
            WateringCan.SetActive(false);
            audio.PlayOneShot(SoundToPlay, volume);
            alreadyPlayed = true;
        }
    }
}
