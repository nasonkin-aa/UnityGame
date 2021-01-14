using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task3 : MonoBehaviour
{
    public GameObject coin;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (Button.flag == true)
        {
            if (col.tag == "Player")
            {
                Instantiate(coin, new Vector3(-3f, -10f, 10f), Quaternion.identity);
            }
            Button.flag = false;
        }
    }
}
