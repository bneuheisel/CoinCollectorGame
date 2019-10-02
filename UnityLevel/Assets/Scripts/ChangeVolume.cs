using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Slider volume;
    public AudioSource myWorld;
    // Update is called once per frame
    void Update()
    {
        myWorld.volume = volume.value;

    }
}
