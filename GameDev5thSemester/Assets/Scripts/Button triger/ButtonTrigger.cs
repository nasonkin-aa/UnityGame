using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger: MonoBehaviour
{
    public GameObject frame;
    public GameObject[] OtheFrame;
    public bool ButtonInTrigger =false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("OH SHIT A RAT");
            frame.SetActive(true);
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
