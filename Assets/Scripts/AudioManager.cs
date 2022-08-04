using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public AudioSource audioSource;
    public AudioClip[] audios = new AudioClip[2];


    private void Awake()
    {
        instance = this;
    }

}
