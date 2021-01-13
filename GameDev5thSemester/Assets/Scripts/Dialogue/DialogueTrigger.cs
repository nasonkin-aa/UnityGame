using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public static InstantiateDialog ID;
    public bool pressed;
    public GameObject controller;

    private void Start()
    {
        controller = GameObject.Find("Controller");
    }

    public void TriggerDialogue()
    {

        ID.ShowDialogue = true;
    }

}
