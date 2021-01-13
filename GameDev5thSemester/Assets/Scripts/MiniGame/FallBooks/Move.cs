using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float horizontalSpeed;
    float speedX;
    private Rigidbody2D rb;
    float PosX;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        //PosX = transform.position.x;
        //print(transform.position.x);
    }

    public void LeftButtonDown()
    {
        //while (true)
        //{
            if (PosX > -11)
            {
                speedX = -horizontalSpeed;
            }
            else
            {
                speedX = 0;
            }
       // }
        
    }

    public void RightButtonDown()
    {
        if(PosX < 8)
        {
            speedX = horizontalSpeed;
        }
        else
        {
            speedX = 0;
        }
    }

    public void Stop()
    {
        speedX = 0;
    }

    void FixedUpdate()
    {
        PosX = transform.position.x;
        transform.Translate(speedX/20, 0, 0);
    }

    private void Movement(float horizontalInput)
    {
        rb.AddForce(new Vector2(horizontalInput * speedX * Time.deltaTime, 0));
    }
}
