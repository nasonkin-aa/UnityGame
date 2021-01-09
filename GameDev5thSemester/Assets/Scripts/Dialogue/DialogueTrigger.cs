using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueAnimator da;
    public bool pressed;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(da.d);
    }
}
