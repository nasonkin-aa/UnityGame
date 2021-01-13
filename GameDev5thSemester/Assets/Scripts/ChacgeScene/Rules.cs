using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    public Animator rulesAnim;

    public void Rul()
    {
        rulesAnim.SetBool("rulesOpen", true);
    }

    public void Back()
    {
        rulesAnim.SetBool("rulesOpen", false);
    }
}
