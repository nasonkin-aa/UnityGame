using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMiniGame1 : MonoBehaviour
{
    public Animator AnimMiniGaem;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Exit()
    {
        AnimMiniGaem.SetTrigger("IsTriggered");
        Move.ZA = false;
        NewController.MiniGameStatus = false;
        InstantiateQuestList.flag = true;
    }
}
