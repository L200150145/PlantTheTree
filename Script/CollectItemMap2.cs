using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemMap2 : MonoBehaviour
{

    public AudioSource collectSound;


    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystemMiniGameMap2.theScore += 1;
        Destroy(gameObject);


    }


}
