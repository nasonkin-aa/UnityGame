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

    public void LeftButtonDown()
    {
        speedX = -horizontalSpeed;
        
    }

    public void RightButtonDown()
    {
        speedX = horizontalSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        speedX = 0;
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

    
}
