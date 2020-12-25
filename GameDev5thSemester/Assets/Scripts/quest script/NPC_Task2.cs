using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task2 : MonoBehaviour
{
    public Quest_Event QE;
    public GameObject Player;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Player");
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
            Player.GetComponent<Score>().scre += 15;
        }
    }
}