using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Animator startAnim;





    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            startAnim.SetBool("startOpen", true);
            DialogueTrigger.ID = gameObject.GetComponent<InstantiateDialog>();
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            startAnim.SetBool("startOpen", false);
        }
    }
}
