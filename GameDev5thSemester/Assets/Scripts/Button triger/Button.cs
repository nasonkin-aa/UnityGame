using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    ButtonTrigger ButtonTrigger;
    public GameObject obj;
    private void Start()
    {
        ButtonTrigger = obj.GetComponent<ButtonTrigger>();
    }
    private void OnMouseDown()
    {
        if (ButtonTrigger.ButtonInTrigger == true)
        {
            Debug.Log("1");
        }
        else if (ButtonTrigger.ButtonInTrigger == false)
        {
            Debug.Log("0");
        }
        
    }
}
