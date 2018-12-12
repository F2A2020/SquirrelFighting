using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [HideInInspector] public static AudioManager Instance;

    private AudioSource audioSource;

    void Start()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayerSound(string audioName)
    {
        AudioClip audioClip = Resources.Load<AudioClip>(audioName);
        audioSource.PlayOneShot(audioClip);
    }
}
