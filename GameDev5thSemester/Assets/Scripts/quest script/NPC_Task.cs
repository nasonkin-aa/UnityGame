using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task : MonoBehaviour {
	public bool EndDialog;
	public GameObject Dialog1, Dialog2, joystic;
	public Quest_Event QE;
    public bool Fin_Dialog;
    private bool onhide;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (QE.end_Quest1 == true)
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
        }
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player") {
            if (Fin_Dialog == false)
            {
                Time.timeScale = 0;
                if (QE.end_Quest1 == false)
                {
                    Dialog1.SetActive(true);
                    joystic.SetActive(false);
                }
                else
                {
                    Dialog2.SetActive(true);
                    joystic.SetActive(false);
                }
            }
            else
            {
                if (onhide == false)
                {
                    Dialog2.SetActive(true);
                    onhide = true;
                }
            }
        }
	}
}