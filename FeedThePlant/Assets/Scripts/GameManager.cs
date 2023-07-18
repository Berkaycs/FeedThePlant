using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    private float time = 0;
    private int seconds;
    private int score = 0;
    public bool gameOver = false;

    void Start()
    {
        scoreText.text = "Score: " + score;
        timerText.text = "Timer: " + time;
    }

    void Update()
    {
        Timer();
    }

    public void AddScore(int value)
    {
        if (gameOver == false)
        {
            score += value;
            scoreText.text = "Score: " + score;
        }       
    }

    public void Timer()
    {
        if (gameOver == false)
        {
            time += Time.deltaTime;
            seconds = Convert.ToInt32(time % 60);
            timerText.text = "Timer: " + seconds;
        }
    }
}
