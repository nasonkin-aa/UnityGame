using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Coin")
        {
            Destroy(col.gameObject);
            Score.scre += 15;
        }
    }
}