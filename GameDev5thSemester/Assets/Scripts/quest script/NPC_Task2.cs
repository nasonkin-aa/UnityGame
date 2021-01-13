using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task2 : MonoBehaviour
{
    public Quest_Event QE;

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
            QE.end_SubQuest2 = true;
            Score.scre += 15;
        }
    }
}