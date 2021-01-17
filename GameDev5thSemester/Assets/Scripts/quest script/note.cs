using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    public Animator startAnim;
    public static GameObject gameanim;
    public string questname;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && PlayerPrefs.GetInt(questname) == 0)
        {
            startAnim.SetBool("startOpen", true);
            notetrigger.IN = gameObject.GetComponent<InstantiateNote>();
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
