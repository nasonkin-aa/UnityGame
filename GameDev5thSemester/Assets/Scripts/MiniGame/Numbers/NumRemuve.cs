using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumRemuve : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag != gameObject.tag)
        {

            Destroy(GameObject.FindGameObjectWithTag("MGBFirst"));
            Destroy(GameObject.FindGameObjectWithTag("MGBSecond"));
            Destroy(GameObject.FindGameObjectWithTag("MGBThird"));

        }

    }
}
