﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notetrigger : MonoBehaviour
{
    public static InstantiateNote IN;
    public bool pressed;
    public string questname;

    private void Start()
    {

    }

    public void TriggerDialogue()
    {
        if (PlayerPrefs.GetInt(questname) == 0)
        {
            IN.ShowDialogue = true;
        }
    }

}
