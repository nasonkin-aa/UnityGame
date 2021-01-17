using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerMusic : MonoBehaviour
{
    public Animator startAnim;
    public GameObject musician;
    public string questname;



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && PlayerPrefs.GetInt(questname) > 0)
        {
            startAnim.SetBool("startOpen", true);
            musician.GetComponent<FollowPathMusic>().flag = false;
            DialogueTrigger.ID = gameObject.GetComponent<InstantiateDialog>();
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            musician.GetComponent<FollowPathMusic>().flag = true;
            startAnim.SetBool("startOpen", false);
        }
    }
}
