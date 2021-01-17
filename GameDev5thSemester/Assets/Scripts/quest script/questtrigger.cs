using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questtrigger : MonoBehaviour
{
    public Animator startAnim;
    public GameObject anim;
    public static GameObject gameanim;
    public string questname;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && PlayerPrefs.GetInt(questname) == 1)
        {
            startAnim.SetBool("startOpen", true);
            gameanim = anim;
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
