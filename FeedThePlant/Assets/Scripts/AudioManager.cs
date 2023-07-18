using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip water, sun, crush, fall, gameover;

    public void PlayWater()
    {
        source.clip = water;
        source.Play();
    }

    public void PlaySun()
    {
        source.clip = sun;
        source.Play();
    }

    public void PlayCrush()
    {
        source.clip = crush;
        source.Play();
    }

    public void PlayFall()
    {
        source.clip = fall;
        source.Play();
    }

    public void PlayGameOver()
    {
        source.clip = gameover;
        source.Play();
    }
}
