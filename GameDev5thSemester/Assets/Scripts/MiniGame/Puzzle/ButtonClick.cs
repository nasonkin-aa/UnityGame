using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public bool PsButton = false;
    public GameObject StButton;
    public GameObject Zone;



    public void OnMouseDown()
    {

        Zone.SetActive(true);
        PsButton = true;
        StButton.SetActive(false);
    }
}
