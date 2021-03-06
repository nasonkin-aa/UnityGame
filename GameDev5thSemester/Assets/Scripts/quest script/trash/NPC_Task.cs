﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task : MonoBehaviour {
	public GameObject joystic, image1, image2;
	public Quest_Event QE;
    public Dialog_NextClick DN1, DN2;
    public bool Fin_Dialog, EndDialog;
    private bool onhide;
    public Animator QuestW1, QuestW2;

    // Use this for initialization
    void Start ()
    {
        QE = GameObject.FindGameObjectWithTag("Event").GetComponent<Quest_Event>();
        joystic = GameObject.FindGameObjectWithTag("cntrl");
        image1 = GameObject.Find("Image (2)");
        image2 = GameObject.Find("Image (3)");
        DN1 = GameObject.Find("Image (2)").GetComponent<Dialog_NextClick>();
        DN2 = GameObject.Find("Image (3)").GetComponent<Dialog_NextClick>();
        QuestW1 = GameObject.Find("Image (2)").GetComponent<Animator>();
        QuestW2 = GameObject.Find("Image (3)").GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}
	void OnTriggerStay2D(Collider2D col)
	{
        if (Button.flag == true)
        {
            if (col.tag == "Player")
            {
                if (EndDialog == false)
                {
                    if (QE.end_Quest1 == false)
                    {
                        DN1.dialog_on = true;
                        QuestW1.SetTrigger("IsTriggered");
                        joystic.SetActive(false);
                    }
                    else if (QE.end_Quest2 == false && QE.end_Quest1 == true)
                    {
                        DN2.dialog_on = true;
                        QuestW2.SetTrigger("IsTriggered");
                        joystic.SetActive(false);
                    }
                }
            }
            Button.flag = false;
        }
	}
}