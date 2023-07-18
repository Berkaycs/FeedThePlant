using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    public GameManager gameManager;
    private AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rock"))
        {
            Destroy(collision.gameObject);
            audioManager.PlayFall();
        }
        
        else if (collision.CompareTag("Sun") | collision.CompareTag("Water"))
        {
            Destroy(collision.gameObject);
            audioManager.PlayFall();
            gameManager.AddScore(-5);
        }
    }
}
