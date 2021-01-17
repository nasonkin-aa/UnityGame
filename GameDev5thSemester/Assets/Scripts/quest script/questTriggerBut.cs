using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questTriggerBut : MonoBehaviour
{
    public static InstantiateDialog ID;
    public bool pressed;

    void Start()
    {
        
    }

    public void TriggerGame()
    {
        questtrigger.gameanim.GetComponent<Animator>().SetTrigger("IsTriggered");
    }
}

