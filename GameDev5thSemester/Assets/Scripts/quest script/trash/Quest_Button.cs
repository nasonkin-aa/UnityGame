using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Button : MonoBehaviour
{

    public Animator AnimMiniGaem;
    public GameObject controller;

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
        if (PlayerPrefs.GetInt ("questClicker") == 1)
        {
            PlayerPrefs.SetInt ("questClicker", 2);
        }
        controller.SetActive(true);
        AnimMiniGaem.SetTrigger("IsTriggered");
    }
}
