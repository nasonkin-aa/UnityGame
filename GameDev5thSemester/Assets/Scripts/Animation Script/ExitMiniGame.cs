using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMiniGame : MonoBehaviour
{
    public Animator AnimMiniGaem;
    private Transform player;
    public GameObject book1, bg;

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
        Vector3 playerPos = new Vector3(player.position.x, player.position.y);
        Instantiate(book1, playerPos, Quaternion.identity);
        bg.SetActive(false);
        if (PlayerPrefs.GetInt("questFallBooks") == 1)
        {
            PlayerPrefs.SetInt("questFallBooks", 2);
        }
    }
}
