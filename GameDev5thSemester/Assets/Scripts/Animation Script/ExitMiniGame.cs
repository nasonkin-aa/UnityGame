using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMiniGame : MonoBehaviour
{
    public Animator AnimMiniGaem;
    public void Exit()
    {
        AnimMiniGaem.SetTrigger("IsTriggered");
    }
}
