using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonAtoms : MonoBehaviour
{
    public bool PressButton = false;
    public GameObject StartButton;
    public GameObject Zone;

    public void OnMouseDown()
    {
        
        Zone.SetActive(true);
        PressButton = true;
        StartButton.SetActive(false);



    }
}
