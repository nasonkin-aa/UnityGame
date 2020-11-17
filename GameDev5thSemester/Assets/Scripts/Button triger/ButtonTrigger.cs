using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Button;
public class ButtonTrigger: MonoBehaviour
{

    
    public static GameObject frame;
    public static GameObject frame1;
    public GameObject[] OtheFrame;
    public static int TriggerFlag = 0;
    public static bool ButtonInTrigger =false;
   
    private void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") )
        {
            
            Debug.Log("lol123");
            /* Debug.Log("OH SHIT A RAT");
             TriggerFlag = 0;

             ButtonInTrigger = true;
             foreach (GameObject frame in OtheFrame)
             {
                 frame.SetActive(false);
             }*/

        }
        else if(other.CompareTag("Player") )
        {
            
            Debug.Log("OH SHIT A RAT");
            TriggerFlag = 1;
            ButtonInTrigger = true;
            foreach (GameObject frame in OtheFrame)
            {
                frame.SetActive(false);
            }

        }
        

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           
            Debug.Log("lol");
            ButtonInTrigger = false;

        }
    }
}
