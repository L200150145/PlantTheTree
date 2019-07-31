using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShovelIconAppear : MonoBehaviour
{

    [SerializeField] private Image shovelIcon;

    public AudioClip SoundToPlay;
    public float volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    public GameObject shovel;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shovelIcon.enabled = true;
            shovel.SetActive(false);
            audio.PlayOneShot(SoundToPlay, volume);
            alreadyPlayed = true;
        }
    }
}
