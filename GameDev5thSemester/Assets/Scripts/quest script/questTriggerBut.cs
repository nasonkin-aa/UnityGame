using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questTriggerBut : MonoBehaviour
{
    public static InstantiateDialog ID;
    public bool pressed;
    public GameObject controller;

    void Start()
    {
        
    }

    public void TriggerGame()
    {
        controller.SetActive(false);
        questClicker.gameanim.GetComponent<Animator>().SetTrigger("IsTriggered");
    }
}

