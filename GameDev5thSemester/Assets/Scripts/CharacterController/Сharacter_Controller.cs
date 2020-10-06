using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Сharacter_Controller : MonoBehaviour
{
    public float Speed;
    private float MoveImputHorizontal;
    private float MoveImputVertical;
    private Rigidbody2D rb;
    private bool FacingRight = true;
    public Joystick joystick;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        MoveImputHorizontal = joystick.Horizontal;
        MoveImputVertical = joystick.Vertical;
        rb.velocity = new Vector2(MoveImputHorizontal * Speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, MoveImputVertical * Speed);
        if (FacingRight == false && MoveImputHorizontal > 0)
        {
            Flip();
        }
        else if (FacingRight == true && MoveImputHorizontal < 0)
        {
            Flip();
        }
    }


    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }


}
