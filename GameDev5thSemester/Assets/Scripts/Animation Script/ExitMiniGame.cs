using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMiniGame : MonoBehaviour
{
    public Animator AnimMiniGaem;
    private void OnMouseDown() => AnimMiniGaem.SetTrigger("IsTriggered");
 
}
