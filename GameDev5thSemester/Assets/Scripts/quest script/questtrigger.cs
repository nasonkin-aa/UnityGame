using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questtrigger : MonoBehaviour
{
    public Animator startAnim;
    public GameObject anim;
    public static GameObject gameanim;
    public string questname;
    public static string namequest;

    public int flag = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {
        namequest = questname;
        if (other.CompareTag("Player"))
        {
            if (flag == 0)
            {
                if (PlayerPrefs.GetInt(questname) == 0)
                {
                    startAnim.SetBool("startOpen", true);
                    gameanim = anim;
                }
            }
            else if (flag == 1)
            {
                if (PlayerPrefs.GetInt(questname) == 1)
                {
                    startAnim.SetBool("startOpen", true);
                    gameanim = anim;
                }
            }
            else if (flag == 2)
            {
                if (PlayerPrefs.GetInt(questname) == 2)
                {
                    startAnim.SetBool("startOpen", true);
                    gameanim = anim;
                }
            }
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
