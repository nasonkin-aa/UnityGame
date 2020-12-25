using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Button : MonoBehaviour
{

    public Quest_Event QE;
    public Animator AnimMiniGaem;
    public NPC_Task npc_taskScript;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        npc_taskScript = GameObject.FindGameObjectWithTag("Game3").GetComponent<NPC_Task>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        QE.end_Quest1 = true;
        AnimMiniGaem.SetTrigger("IsTriggered");
        npc_taskScript.EndDialog = false;
        Player.GetComponent<Score>().scre += 10;
    }
}
