using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task : MonoBehaviour {
	public GameObject joystic, image1;
	public Quest_Event QE;
    public Dialog_NextClick DN;
    public bool Fin_Dialog, EndDialog;
    private bool onhide;
    public Animator AnimMiniGaem;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if (QE.end_Quest1 == true)
        {
            Fin_Dialog = true;
        }
		if (EndDialog == true) {
			Time.timeScale = 1;
			QE.Quest1 = true;
			Dialog1.SetActive (false);
            joystic.SetActive (true);
        }
        if (Fin_Dialog == true)
        {
            Time.timeScale = 1;
            QE.Quest1 = false;
            Dialog1.SetActive(false);
            joystic.SetActive(true);
        }*/
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
                        DN.dialog_on = true;
                        AnimMiniGaem.SetTrigger("IsTriggered");
                        joystic.SetActive(false);
                    }
                }
            }
            Button.flag = false;
        }
	}
}