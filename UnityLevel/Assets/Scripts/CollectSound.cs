using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSound : MonoBehaviour
{
    public AudioSource tickSource;

    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter (Collider coll)
    {
        if (coll.gameObject.tag == "Coin")
        {
            tickSource.Play();
        }
    }
}
