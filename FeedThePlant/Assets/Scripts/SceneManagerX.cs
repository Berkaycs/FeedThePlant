using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerX : MonoBehaviour
{
    public AudioSource clickSound;

    public void Play()
    {
        clickSound.Play();
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        clickSound.Play();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        clickSound.Play();
        Application.Quit();
    }

    public void Menu()
    {
        clickSound.Play();
        SceneManager.LoadScene(0);
    }

    public void SelectCharacter()
    {
        clickSound.Play();
        SceneManager.LoadScene(2);
    }
}
