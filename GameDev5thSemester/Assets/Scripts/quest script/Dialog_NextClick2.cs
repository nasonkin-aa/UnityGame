using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_NextClick2 : MonoBehaviour
{
    public GameObject joystic;
    public NPC_Task npc_taskScript;
    public Quest_Event QE;
    public bool dialog_on;
    public Animator AnimMiniGaem;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialog_on == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                QE.end_SubQuest2 = true;
                AnimMiniGaem.SetTrigger("IsTriggered");
                joystic.SetActive(true);
            }
        }
    }
}