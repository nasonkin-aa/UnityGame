using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_NextClick : MonoBehaviour {
	public GameObject Text1;
	public GameObject Text2;
    public GameObject joystic, image1;
    private bool isText1 =true;
	public NPC_Task npc_taskScript;
    public Quest_Event QE;
    public bool Fin_Dialog, dialog_on;
    public GameObject ObjectQuest;
    public Animator AnimMiniGaem;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (dialog_on == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (isText1 == true)
                {
                    isText1 = false;
                }
                else
                {
                    if (npc_taskScript.EndDialog == false)
                    {
                        npc_taskScript.EndDialog = true;
                        QE.Quest1 = true;
                        dialog_on = false;
                        AnimMiniGaem.SetTrigger("IsTriggered");
                        joystic.SetActive(true);
                        image1.SetActive(false);
                    }
                }
            }
            if (isText1 == true)
            {
                Text1.SetActive(true);
                Text2.SetActive(false);
            }
            else
            {
                Text1.SetActive(false);
                Text2.SetActive(true);
            }
        }
	}
}