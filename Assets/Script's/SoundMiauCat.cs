using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMiauCat : MonoBehaviour
{
    AudioSource miauSound;
    private void Start()
    {
        miauSound = GetComponent<AudioSource>();
    }
    public void MiauSound()
    {
        miauSound.Play();
    }
}
