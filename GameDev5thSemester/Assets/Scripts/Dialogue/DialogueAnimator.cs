 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class DialogueAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogueManager dm;
    public Dialogue d;
    public DialogueTrigger DT;



   

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            startAnim.SetBool("startOpen", true);
            DT.da = gameObject.GetComponent<DialogueAnimator>();
        }
            
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            startAnim.SetBool("startOpen", false);
            dm.EndDialogue();
        }   
    }
}
