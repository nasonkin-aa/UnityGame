using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_NextClick : MonoBehaviour {
	public GameObject Text1;
	public GameObject Text2;
    public GameObject joystic, image1, coin;
    private bool isText1 =true;
	public NPC_Task npc_taskScript;
    public Quest_Event QE;
    public bool Fin_Dialog, dialog_on;
    public Animator AnimMiniGaem;
    public int rng;

    // Use this for initialization
    void Start ()
    {
        npc_taskScript = GameObject.FindGameObjectWithTag("Game3").GetComponent<NPC_Task>();
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
                        dialog_on = false;
                        if (QE.n == 0)
                        {
                            QE.Quest1 = true;
                            image1.SetActive(false);
                        }
                        if (QE.n == 1)
                        {
                            QE.Quest2 = true;
                            QE.SubQuest2 = true;
                            rng = Random.Range(0, 2);
                            if (rng == 0)
                            {
                                Instantiate(coin, new Vector3(-3f, -10f, 10f), Quaternion.identity);
                            }
                            if (rng == 1)
                            {
                                Instantiate(coin, new Vector3(-7.7f, 6.48f, 10f), Quaternion.identity);
                            }
                            if (rng == 2)
                            {
                                Instantiate(coin, new Vector3(-29f, -11f, 10f), Quaternion.identity);
                            }
                            image1.SetActive(false);
                        }
                        AnimMiniGaem.SetTrigger("IsTriggered");
                        joystic.SetActive(true);
                        QE.n += 1;
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