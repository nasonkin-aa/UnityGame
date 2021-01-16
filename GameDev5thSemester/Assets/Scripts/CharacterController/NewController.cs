/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //объявляем переменную,которая берет значение из настроек управления
        float vertikal = Input.GetAxis("Vertical");
        Vector3 position = transform.position;
        position.x = position.x + 7f * horizontal * Time.deltaTime;
        position.y = position.y + 7f * vertikal * Time.deltaTime;
        transform.position = position;
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    private bool FacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //объявляем переменную,которая берет значение из настроек управления
        float vertikal = Input.GetAxis("Vertical");
        Vector3 position = rigidbody2d.position;
        position.x = position.x + 14f * horizontal * Time.deltaTime;
        position.y = position.y + 14f * vertikal * Time.deltaTime;
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

    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
