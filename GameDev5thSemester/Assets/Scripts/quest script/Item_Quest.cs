﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Quest : MonoBehaviour
{
    public Quest_Event QEvent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            QEvent.end_Quest1 = true;
            Destroy(gameObject);
        }
    }
}
