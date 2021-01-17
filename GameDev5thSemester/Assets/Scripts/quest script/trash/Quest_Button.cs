using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Button : MonoBehaviour
{

    public Animator AnimMiniGaem;
    public string questname;
    public int flag;

    // Start is called before the first frame update
    void Start()
    {
        //controller = GameObject.Find("Controller");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (flag == 0)
        {
            if (PlayerPrefs.GetInt(questname) == 1)
            {
                PlayerPrefs.SetInt(questname, 2);
            }
        }
        else if (flag == 1)
        {
            if (PlayerPrefs.GetInt(questname) == 0)
            {
                PlayerPrefs.SetInt(questname, 1);
            }
        }
        else if (flag == 2)
        {
            if (PlayerPrefs.GetInt(questname) == 2)
            {
                PlayerPrefs.SetInt(questname, 3);
            }
        }
        if (questname == "questClicker")
        {
            Score.scre += 30;
        }

        AnimMiniGaem.SetTrigger("IsTriggered");
        NewController.MiniGameStatus = false;
        InstantiateQuestList.flag = true;
    }
}
