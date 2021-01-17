using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questTriggerBut : MonoBehaviour
{
    public bool pressed;

    void Start()
    {
        
    }

    public void TriggerGame()
    {
        questtrigger.gameanim.GetComponent<Animator>().SetTrigger("IsTriggered");
        gameObject.GetComponent<Animator>().SetBool("startOpen", false);
        NewController.MiniGameStatus = true;
        InstantiateQuestList.flag = false;
        if (questtrigger.namequest == "questFallBooks")
        {
            Move.ZA = true;
        }
    }
}