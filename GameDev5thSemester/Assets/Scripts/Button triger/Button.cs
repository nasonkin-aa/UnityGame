﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Button : MonoBehaviour
{
    public static bool flag = false;
   
    private void Start()
    {
        
    }
    private void OnMouseDown() => flag = true;

    private void OnMouseUp() => flag = false;
}
