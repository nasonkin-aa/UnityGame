using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  static ButtonTrigger;
public class Button : MonoBehaviour
{
   
    private void Start()
    {
        
    }
    private void OnMouseDown()
    {
        if (ButtonTrigger.ButtonInTrigger == true)
        {
            if (ButtonTrigger.TriggerFlag == 0)
            {
                Debug.Log("1");
            }else if(ButtonTrigger.TriggerFlag == 1) {
                Debug.Log("2");
            }

      
            
        }
        else if (ButtonTrigger.ButtonInTrigger == false)
        {
            Debug.Log("0");
        }
        
    }
}
