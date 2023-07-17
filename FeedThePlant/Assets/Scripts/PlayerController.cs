using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private Rigidbody2D playerRb;
    private float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move1();
        Move2();
        Move3();
        Move4();
    }

    // First way to move
    void Move1()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            playerRb.velocity = new Vector2 (-speed, 0);
        }

        else if (Input.GetKey(KeyCode.RightArrow)) 
        {
            playerRb.velocity = new Vector2(speed, 0);
        }

        else
        {
            playerRb.velocity = new Vector2 (0, 0);
        }
    }

    // Second way to move
    void Move2()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerRb.AddForce(new Vector2(-speed, 0)); // for the instant movement you can add Impulse force mode
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRb.AddForce(new Vector2(speed, 0));
        }
    }

    // Third way to move (if there is no rigidbody)
    void Move3()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }

        else if (Input.GetKey(KeyCode.E))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
    }
    
    // Fourth way to move
    void Move4()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed); // you can use parameter which is space / localspace
        }

        else if (Input.GetKey(KeyCode.C))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
    }

}
