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
        NewController.MiniGameStatus = true;
        ID.ShowDialogue = true;
        gameObject.GetComponent<Animator>().SetBool("startOpen", false);
    }

}
