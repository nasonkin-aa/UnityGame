using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    public Animator rulesAnim;

    public void Rul()
    {
        rulesAnim.SetTrigger("IsTriggered");
    }

    public void Back()
    {
        rulesAnim.SetTrigger("IsTriggered");
    }

}
