using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //объявляем переменную,которая берет значение из настроек управления
        Vector3 position = transform.position;
        position.x = position.x + 7f * horizontal * Time.deltaTime;
        transform.position = position;
    }
}
