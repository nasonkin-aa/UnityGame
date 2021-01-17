using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public static InstantiateDialog ID;
    public bool pressed;

    private void Start()
    {
        
    }

    public void TriggerDialogue()
    {

        ID.ShowDialogue = true;
    }

}
