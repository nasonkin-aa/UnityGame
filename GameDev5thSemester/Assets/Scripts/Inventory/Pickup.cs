﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject SlotButton;
    public Quest_Event QE;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        QE = GameObject.FindGameObjectWithTag("Event").GetComponent<Quest_Event>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for( int i = 0; i < inventory.slots.Length; i++)
            {
                if( inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(SlotButton, inventory.slots[i].transform);
                    QE.end_Quest2 = true;
                    Destroy(gameObject);
                    break;

                }
            }


        }
    }
}
