using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    private bool FacingRight = true;
    public static bool ZA = false;
    public bool ZoneActive = ZA;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ZoneActive = ZA;
        if (ZoneActive)
        {
            float horizontal = Input.GetAxis("Horizontal"); //объявляем переменную,которая берет значение из настроек управления
            Vector3 position = rigidbody2d.position;
            position.x = position.x + 21f * horizontal * Time.deltaTime;
            rigidbody2d.MovePosition(position);
            if (FacingRight == false && horizontal > 0)
            {
                Flip();
            }
            else if (FacingRight == true && horizontal < 0)
            {
                Flip();
            }
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
